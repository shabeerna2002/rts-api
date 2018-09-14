using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RTS.Controllers
{
    public class Common
    {
        public void ProcessApplicationWorkflowAsync(string connectionString, string LoggedInUserID , int candidateID, int vacancyid, int ApplicationSourceID, int AppliedByUserID, int RequesterUserID, int StateID)
        {
            Thread ApplicationProcessFlow = new System.Threading.Thread(() => ProcessApplicationWorkflow(connectionString, LoggedInUserID, candidateID, vacancyid, ApplicationSourceID, AppliedByUserID, RequesterUserID, StateID));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();
        }

        private void ProcessApplicationWorkflow(string conStr, string LoggedInUserID, int candidateID, int vacancyid, int ApplicationSourceID, int AppliedByUserID, int RequesterUserID, int StateID)
        {
            //string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Models.Jobapplication JobApplicationModel = new RTS.JobStation.Models.Jobapplication();
            RTS.JobStation.Controller.Jobapplication JobApplicationController = new RTS.JobStation.Controller.Jobapplication();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                JobApplicationModel.ApplicationSourceID = ApplicationSourceID;
                JobApplicationModel.AppliedByUser = AppliedByUserID;
                JobApplicationModel.AppliedOn = DateTime.Now;
                JobApplicationModel.CanidateID = candidateID;
                JobApplicationModel.VacancyID = vacancyid;
                JobApplicationModel.UpdatedBy = LoggedInUserID;
                JobApplicationModel.UpdatedOn = DateTime.Now;

                string result = JobApplicationController.Insert(JobApplicationModel, ref con, ref MyTran);


                int ApplicationID = 0;
                if (result == "200")
                {
                    ApplicationID = Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());
                }
                else if (result == "300")
                {
                    ApplicationID = JobApplicationController.GetJobApplicationID(ref con, ref MyTran, candidateID, vacancyid);
                }
                else if (result == "0")
                {
                    //return StatusCode(505, "Error,  Error during inserting candidate");

                    //send admin error email
                }
                else
                {
                    //return StatusCode(510, "Error, Cannot create of find application id");
                    //send admin error email
                }

                if (ApplicationID > 0)
                {

                    RTS.JobStation.Controller.Request RequestWorkFlowController = new RTS.JobStation.Controller.Request();
                    RequestWorkFlowController.TransitionAction(ref con, ref MyTran, 100, 0, ApplicationID, RequesterUserID, StateID, 0, AppliedByUserID, 0);

                }


                if (result == "200")
                {

                    // return Ok("Shortlisted Successfully");
                }
                else
                {
                    //send admin error email
                }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {
                //send admin error email
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }
        }
    }
}
