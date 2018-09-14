using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTS.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {


        string NewToken = "";
        IConfiguration configuration;
        public JobsController(IConfiguration iconfiguration)
        {
            this.configuration = iconfiguration;
        }
        private bool AuthenticateUser()
        {
            string UserID = Request.Headers["userid"];
            string ApiKey = Request.Headers["apikey"];
            string UserKey = Request.Headers["userkey"];
            string ConsumerKey = Request.Headers["consumerkey"];
            string Token = Request.Headers["token"];
            NewToken = RTS.JobStation.DatabaseCommands.AuthenticateUser(UserID, UserKey, ApiKey, ConsumerKey, Token);
            if ((NewToken.ToLower().IndexOf("valid") >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        
  
        [HttpGet("listingsummaryOld")]
        public ActionResult<string> GetJobListingSummaryOld()
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy ();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Jobs.GetJobInfoSummary(ref con, ref MyTran);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        string xml = ds.GetXml();
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);
                        //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
                        jsonResult = JsonConvert.SerializeObject(doc);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {

            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);



        }


        [HttpGet("listingsummary")]
        public ActionResult<string> GetJobListingSummary([FromQuery]int VacancyID  = 0, [FromQuery]int DepartmentID = 0, [FromQuery]int EntityID = 0, [FromQuery]string  JobTitle = "" , [FromQuery]bool isClosed = false)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Jobs.GetJobListSummary(ref con, ref MyTran, VacancyID, DepartmentID,EntityID,JobTitle,isClosed);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.DataSetName = "JobListSummary";
                        string xml = ds.GetXml();
                        XmlDocument doc = new XmlDocument();

                        doc.LoadXml(xml);

                        var xTag = doc.GetElementsByTagName("JobInfo");
                        if (xTag.Count == 2)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }


                        //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
                        jsonResult = JsonConvert.SerializeObject(doc);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error :" + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);



        }

        [HttpGet("vacancydetails/{vacancyid}")]
        public ActionResult<string> GetVacancyDetails(int vacancyid)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Jobs.GetVacancyDetails(ref con, ref MyTran, vacancyid);
                ds.DataSetName = "VacancyDetails";
                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables[0].TableName= "VacancyDetails";
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {

            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);



        }

        [HttpGet("PublishJob/{vacancyid}/{isPublish}")]
        public ActionResult<string> PublishJob(int vacancyid, bool isPublish =true)
        {
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();
            
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                Jobs.PublishJob(ref con, ref MyTran, vacancyid, isPublish);
                return Ok();
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error : " + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }




        }



        

        [HttpGet("CloseJob/{vacancyid}/{isClosed}")]
        public ActionResult<string> CloseJob(int vacancyid, bool isClosed = true)
        {
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();

            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                Jobs.CloseJob(ref con, ref MyTran, vacancyid, isClosed);
                return Ok();
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error : " + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }




        }


        [HttpGet("jobgroupsummary")]
        public ActionResult<string> GetJobListSummary(int vacancyid)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Jobs.GetVacancyDetails(ref con, ref MyTran, vacancyid);
                ds.DataSetName = "VacancyDetails";
                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables[0].TableName = "VacancyDetails";
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {

            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);



        }



        [HttpPost("applyjob/{candidateID}/{vacancyid}")]

        public ActionResult<string> ApplyJob(int candidateID, int vacancyid, [FromQuery]int ApplicationSourceID = 1, [FromQuery]int AppliedByUserID = 0, [FromQuery]int RequesterUserID = 0, [FromQuery]int StateID = 1000)
        {
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            ProcessApplicationWorkflowAsync(candidateID, vacancyid, ApplicationSourceID, AppliedByUserID, RequesterUserID, StateID);


            return Ok("Under Process, If there is an error admin will receive notification");



        }

        //*******************Previous Method -- Synchronous Approach
        //public ActionResult<string> ApplyJob(int candidateID, int vacancyid, [FromQuery]int ApplicationSourceID =1, [FromQuery]int AppliedByUserID = 0 , [FromQuery]int RequesterUserID = 0, [FromQuery]int StateID = 1000)
        //{
        //    string jsonResult = "";
        //    if (AuthenticateUser() == false)
        //    {
        //        return Unauthorized();
        //    }

        //    string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
        //    RTS.JobStation.Models.Jobapplication JobApplicationModel = new RTS.JobStation.Models.Jobapplication();
        //    RTS.JobStation.Controller.Jobapplication JobApplicationController = new RTS.JobStation.Controller.Jobapplication();
        //    MySql.Data.MySqlClient.MySqlConnection con = null;
        //    MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
        //    try
        //    {
        //        con = RTS.JobStation.DatabaseCommands.OpenConnection();
        //        MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
        //        JobApplicationModel.ApplicationSourceID = ApplicationSourceID;
        //        JobApplicationModel.AppliedByUser = AppliedByUserID;
        //        JobApplicationModel.AppliedOn = DateTime.Now;
        //        JobApplicationModel.CanidateID = candidateID;
        //        JobApplicationModel.VacancyID = vacancyid;
        //        JobApplicationModel.UpdatedBy= Request.Headers["userid"];
        //        JobApplicationModel.UpdatedOn = DateTime.Now;

        //        string result=  JobApplicationController.Insert(JobApplicationModel, ref con, ref MyTran);

        //        int ApplicationID = Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());
        //        RTS.JobStation.Controller.Request  RequestWorkFlowController = new RTS.JobStation.Controller.Request();
        //        RequestWorkFlowController.TransitionAction(ref con, ref MyTran, 100, 0, ApplicationID, RequesterUserID,StateID,0,AppliedByUserID,0);

        //        if (result== "200")
        //        {

        //            return Ok("Applied Successfully");
        //        }
        //        else { return StatusCode(500, "Error"); }


        //        // jsonResult = JsonConvert.SerializeObject(ds);
        //    }
        //    catch (System.IO.IOException e)
        //    {

        //    }

        //    finally
        //    {
        //        RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
        //        RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

        //    }


        //    return Ok(jsonResult);



        //}

        [HttpPost("shortlistcandidate/{candidateID}/{vacancyid}")]
        public ActionResult<string> ShortlistCandidate(int candidateID, int vacancyid, [FromQuery]int ApplicationSourceID = 1, [FromQuery]int AppliedByUserID = 0, [FromQuery]int RequesterUserID = 0, [FromQuery]int StateID = 1000)
        {
          
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            ProcessApplicationWorkflowAsync(candidateID, vacancyid, ApplicationSourceID, AppliedByUserID, RequesterUserID, StateID);


            return Ok("Under Process, If there is an error admin will receive notification");



        }


        private void ProcessApplicationWorkflowAsync(int candidateID, int vacancyid, int ApplicationSourceID, int AppliedByUserID, int RequesterUserID, int StateID)
        {
            Thread ApplicationProcessFlow = new Thread(() => ProcessApplicationWorkflow( candidateID,  vacancyid,  ApplicationSourceID ,  AppliedByUserID, RequesterUserID,  StateID));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();
        }

        private void ProcessApplicationWorkflow(int candidateID, int vacancyid, int ApplicationSourceID , int AppliedByUserID,int RequesterUserID, int StateID)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
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
                JobApplicationModel.UpdatedBy = Request.Headers["userid"];
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
                else if (result == "0") {
                    //return StatusCode(505, "Error,  Error during inserting candidate");

                //send admin error email
                }
                else {
                    //return StatusCode(510, "Error, Cannot create of find application id");
                   //send admin error email
                }

                if (ApplicationID > 0)
                {

                    RTS.JobStation.Controller.Request RequestWorkFlowController = new RTS.JobStation.Controller.Request();
                    RequestWorkFlowController.TransitionAction(ref con, ref MyTran,  100, 0, ApplicationID, RequesterUserID, StateID, 0, AppliedByUserID, 0);

                }


                if (result == "200")
                {

                   // return Ok("Shortlisted Successfully");
                }
                else {
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

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/<controller>
        [HttpPost("addvacancy")]
        public ActionResult<string> AddVacancy([FromBody] VacancyInfo value)
        {
           
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            // AddVacancyAsync(value);

            AddVacancySync(value);
            return Ok();


        }

        // POST api/<controller>
        [HttpPost("updatevacancy/{VacancyID}")]
        public ActionResult<string> UpdateVacancy([FromBody] VacancyInfo value, int VacancyID)
        {

            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            UpdateVacancyAsync(value, VacancyID);
            return Ok("Vacancy Updated");


        }

        private void AddVacancyAsync(VacancyInfo value)
        {
            Thread ApplicationProcessFlow = new Thread(() => AddVacancySync(value));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();
        }

        private void AddVacancySync(VacancyInfo value)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy VacancyController = new RTS.JobStation.Controller.Vacancy();

            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;


            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                //Get Candidate Basic Info  GetCandidateBasicInfo
                RTS.JobStation.Models.Vacancy vacancy = new RTS.JobStation.Models.Vacancy();
                vacancy.ProcessID = value.ProcessID;
                vacancy.OpenPositions = value.OpenPositions;
                vacancy.DesignationID = value.DesignationID;
                vacancy.Title = value.JobTitle;
                vacancy.JobDescription = value.JobDescription;
                vacancy.JobSkill = value.JobSkill;
                vacancy.JobSkill = value.JobDuty;
                vacancy.EducationInfo = value.EducationInfo;
                vacancy.NationalityInfo = value.NationalityInfo;
                vacancy.UpdatedBy = Request.Headers["userid"];
                vacancy.UpdatedOn = DateTime.Now;

                string result = VacancyController.Insert_vacancy_AddVacancy(vacancy, ref con, ref MyTran);
                int VacancyID = Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());

                RTS.JobStation.Controller.Employeerequest EmpReqController = new RTS.JobStation.Controller.Employeerequest();
                RTS.JobStation.Models.Employeerequest EmpReqModel = new RTS.JobStation.Models.Employeerequest();

                EmpReqModel.RequestedByUserID = value.RequestedByUserID;
                EmpReqModel.RequestingDepartment = value.RequestingDepartmentID;
                EmpReqModel.PositionName = value.JobTitle;
                EmpReqModel.PositionTypeID = value.PositionTypeID;
                EmpReqModel.NoOfEmployeeRequired = value.OpenPositions;
                EmpReqModel.UpdatedBy = Request.Headers["userid"];
                EmpReqModel.UpdatedOn = DateTime.Now;
                EmpReqController.Insert(EmpReqModel, ref con, ref MyTran);
                int EmployeeRequestID = Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());

                RTS.JobStation.Controller.Jobrequestederf JobReqController = new RTS.JobStation.Controller.Jobrequestederf();
                RTS.JobStation.Models.Jobrequestederf JobReqModel = new RTS.JobStation.Models.Jobrequestederf();

                JobReqModel.VacancyID = VacancyID;
                JobReqModel.EmployeeRequestID = EmployeeRequestID;
                JobReqModel.UpdatedBy = Request.Headers["userid"];
                JobReqModel.UpdatedOn = DateTime.Now;
                JobReqController.Insert(JobReqModel, ref con, ref MyTran);


                AddJobInterviewerInfo(value.JobInterviewerList,VacancyID,ref con, ref MyTran);

                // return Ok("Vacancy Created");

                //Add to JobDepartment and JobEntity

                RTS.JobStation.Controller.Jobentity JobEntityController = new RTS.JobStation.Controller.Jobentity();
                RTS.JobStation.Models.Jobentity JobEntityModel = new RTS.JobStation.Models.Jobentity();

                JobEntityModel.EntityID = value.RequestingEntityID;
                JobEntityModel.VacancyID = VacancyID;
                JobEntityModel.UpdatedBy = Request.Headers["userid"];
                JobEntityController.Insert(JobEntityModel, ref con, ref MyTran);



                RTS.JobStation.Controller.Jobdepartment JobDepartmentController = new RTS.JobStation.Controller.Jobdepartment();
                RTS.JobStation.Models.Jobdepartment JobDepartmentModel = new RTS.JobStation.Models.Jobdepartment();

                JobDepartmentModel.DepartmentID = value.RequestingDepartmentID;
                
                JobDepartmentModel.VacancyID = VacancyID;
                JobDepartmentModel.UpdatedBy = Request.Headers["userid"];
                JobDepartmentController.Insert(JobDepartmentModel, ref con, ref MyTran);




            }
            catch
            {
              //  return StatusCode(500);
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }
        }


        private void UpdateVacancyAsync(VacancyInfo value, int VacacnyID)
        {
            Thread ApplicationProcessFlow = new Thread(() => UpdateVacancySync(value, VacacnyID));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();
        }

        private void UpdateVacancySync(VacancyInfo value, int VacacnyID)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy VacancyController = new RTS.JobStation.Controller.Vacancy();

            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;


            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                //Get Candidate Basic Info  GetCandidateBasicInfo
                RTS.JobStation.Models.Vacancy vacancy = new RTS.JobStation.Models.Vacancy();
                vacancy.VacancyID = VacacnyID;
                vacancy.ProcessID = value.ProcessID;
                vacancy.OpenPositions = value.OpenPositions;
                vacancy.DesignationID = value.DesignationID;
                vacancy.Title = value.JobTitle;
                vacancy.JobDescription = value.JobDescription;
                vacancy.JobSkill = value.JobSkill;
                vacancy.JobSkill = value.JobDuty;
                vacancy.EducationInfo = value.EducationInfo;
                vacancy.NationalityInfo = value.NationalityInfo;
                vacancy.UpdatedBy = Request.Headers["userid"];
                vacancy.UpdatedOn = DateTime.Now;

                string result = VacancyController.Update_vacancy_UpdateVacancy(vacancy, ref con, ref MyTran);

                RTS.JobStation.Controller.Employeerequest EmpReqController = new RTS.JobStation.Controller.Employeerequest();
                RTS.JobStation.Models.Employeerequest EmpReqModel = new RTS.JobStation.Models.Employeerequest();

                EmpReqModel.RequestedByUserID = value.RequestedByUserID;
                EmpReqModel.RequestingDepartment = value.RequestingDepartmentID;
                EmpReqModel.PositionName = value.JobTitle;
                EmpReqModel.PositionTypeID = value.PositionTypeID;
                EmpReqModel.NoOfEmployeeRequired = value.OpenPositions;
                EmpReqModel.UpdatedBy = Request.Headers["userid"];
                EmpReqModel.UpdatedOn = DateTime.Now;
                EmpReqModel.EmployeeRequestID = EmpReqController.GetEmployeeRequestID(ref con, ref MyTran, VacacnyID);
                EmpReqController.Update(EmpReqModel, ref con, ref MyTran);



                



                // return Ok("Vacancy Created");

            }
            catch
            {
                //  return StatusCode(500);
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }
        }

        private void AddJobInterviewerInfo(List<JobInterviewerInfo> value, int VacancyID, ref MySql.Data.MySqlClient.MySqlConnection con, ref MySql.Data.MySqlClient.MySqlTransaction MyTran)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;

           

            try
            {              
                //Add Work History, Employee Profile
                RTS.JobStation.Controller.JobInterviewer JobInterviewerController = new RTS.JobStation.Controller.JobInterviewer();
                RTS.JobStation.Models.JobInterviewer JobInterviewerModel = new RTS.JobStation.Models.JobInterviewer();
                foreach (var Interviewer in value)
                {
                    JobInterviewerModel.VacancyID = VacancyID;
                    JobInterviewerModel.InterviewerUserID = Interviewer.InterviewerUserID;
                    JobInterviewerModel.isEvaluator = Interviewer.isEvaluator;
                    JobInterviewerModel.isMandatory = Interviewer.isMandatory;
                    JobInterviewerModel.UpdatedBy = Request.Headers["userid"];
                    JobInterviewerModel.UpdatedOn = DateTime.Now;
                    JobInterviewerController.Insert(JobInterviewerModel, ref con, ref MyTran);
                }


                //Add Education History, Education Profile
                RTS.JobStation.Controller.Educationhistory EducationHistoryController = new RTS.JobStation.Controller.Educationhistory();
                RTS.JobStation.Models.Educationhistory EducationHistoryModel = new RTS.JobStation.Models.Educationhistory();

                
            }
            catch
            {

            }
           

        }


        [HttpGet("JobAddFormDisplayComponents")]
        public ActionResult<string> GetCandidateAddFormDropDownContents()
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }


            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Vacancy Jobs = new RTS.JobStation.Controller.Vacancy();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Jobs.GetCandidateAddFormDropDownContents(ref con, ref MyTran);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        //string xml = ds.GetXml();
                        //XmlDocument doc = new XmlDocument();
                        //doc.LoadXml(xml);
                        //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error" + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);

        }


    }

    public class VacancyInfo
    {
        public int ProcessID { get; set; }
        public int OpenPositions { get; set; }
        public int DesignationID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobSkill { get; set; }
        public string JobDuty { get; set; }
        public string EducationInfo { get; set; }
        public string NationalityInfo { get; set; }
        public int RequestedByUserID { get; set; }
        public int RequestingDepartmentID { get; set; }
        public int RequestingEntityID { get; set; }
        public int PositionTypeID { get; set; }
        public string RefNo { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime TargetJoiningDate { get; set; }
        public List<JobInterviewerInfo> JobInterviewerList { get; set; }
        // public DateTime OpeningDate { get; set; }


    }




    public class JobInterviewerInfo
    {
      
        public int InterviewerUserID { get; set; }
        public bool isMandatory { get; set; }
        public bool isEvaluator { get; set; }
        public string Description { get; set; }
      

        // public DateTime OpeningDate { get; set; }


    }

}
