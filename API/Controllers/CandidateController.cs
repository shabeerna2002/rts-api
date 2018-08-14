using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTS.Controllers
{
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        string NewToken = "";
        IConfiguration configuration;
        public CandidateController(IConfiguration iconfiguration)
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

     


        // GET: api/<controller>
        [HttpGet("listTest")]
        public ActionResult<string> GetCandidates()
        {
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }


          
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();


            DataSet  ds = new DataSet("CandidateList");
            MySql.Data.MySqlClient.MySqlConnection con = RTS.JobStation.DatabaseCommands.OpenConnection();
            MySql.Data.MySqlClient.MySqlTransaction MyTran;
            MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

            //Get Candidate Basic Info  GetCandidateBasicInfo
            RTS.JobStation.Models.CandidateRequestInfo RequestInfo = new RTS.JobStation.Models.CandidateRequestInfo ();
            RequestInfo.UserID = 4;
            RequestInfo.PageID = 1;
            RequestInfo.Count = 50;
            RequestInfo.FilterType = "none";
          

            // RequestInfo.NationalityIDList = "3";
            // RequestInfo.LanguageSkillsList = "2";
            RequestInfo.Keywords = "good";
  

            ds = Candidate.GetCandidateList(ref con, ref MyTran,RequestInfo  );
            ds.Tables.Add(RTS.JobStation.DatabaseCommands.GetNewTokenTable(NewToken));
           // dt = Candidate.GetCandidateList(ref con, ref MyTran,4,1,50).Tables[0];req
            string jsonResult = JsonConvert.SerializeObject(ds);
            RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
            RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            return  Ok(jsonResult);
        }



        [HttpGet("timeline/{ApplicationID}")]
        public ActionResult<string> GetTimelineUpdates(int CandidateID, int ApplicationID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con =null ;
            MySql.Data.MySqlClient.MySqlTransaction MyTran=  null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetCandidateTimeLine(ref con, ref MyTran, ApplicationID);

                if (ds != null) {

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

       




        [HttpGet("activitylog/{CandidateID}")]
        public ActionResult<string> GetActivityLogs(int CandidateID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetCandidateActivityLogs(ref con, ref MyTran, CandidateID);

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

        [HttpGet("ActiveJobApplications/{CandidateID}")]
        public ActionResult<string> GetActiveJobApplications(int CandidateID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetActiveJobApplications(ref con, ref MyTran, CandidateID);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables[0].TableName = "ActiveJobApplications";
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

        [HttpGet("CandidateApplicationStatus/{ApplicationID}")]
        public ActionResult<string> GetCandidateApplicationStatus(int ApplicationID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetCandidateApplicationStatus(ref con, ref MyTran, ApplicationID);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables[0].TableName = "ApplicationStatus";
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

        [HttpGet("PastJobApplications/{CandidateID}")]
        public ActionResult<string> GetPastJobApplications(int CandidateID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetPastJobApplications(ref con, ref MyTran, CandidateID);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables[0].TableName = "PastJobApplications";
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





        [HttpGet("documents/{CandidateID}")]
        public ActionResult<string> GetCandidateDocuments(int CandidateID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetCandidateDocuments(ref con, ref MyTran, CandidateID);

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




        [HttpGet("bancandidate/{cAction}/{CandidateID}/{BannedByUserID}")]
        public ActionResult<string> BanCandidate(string cAction, int CandidateID, int BannedByUserID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            BanCandidateAsync(cAction, CandidateID, BannedByUserID);

            if (cAction.ToLower() == "block")
            {
              return Ok("candidate blocked successfully");
             
            }
            else if (cAction.ToLower() == "unblock")
            {
                return Ok("candidate unblocked successfully"); 
               
            }

            return Ok(jsonResult);



        }

        private void BanCandidateAsync(string cAction, int CandidateID, int BannedByUserID)
        {
            Thread ApplicationProcessFlow = new Thread(() => BanCandidateSync(cAction,CandidateID,BannedByUserID));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();

        }
        private void BanCandidateSync(string cAction, int CandidateID, int BannedByUserID)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidatesbanned Candidate = new RTS.JobStation.Controller.Candidatesbanned();
            RTS.JobStation.Models.Candidatesbanned CandidateModel = new RTS.JobStation.Models.Candidatesbanned();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                CandidateModel.BannedByUserID = BannedByUserID;
                CandidateModel.CandidateID = CandidateID;
                CandidateModel.BannedOn = DateTime.Now;
                CandidateModel.UpdatedBy = BannedByUserID.ToString();
                CandidateModel.UpdatedOn = DateTime.Now;


                if (cAction.ToLower() == "block")
                {
                    if (Candidate.Insert(CandidateModel, ref con, ref MyTran) == "200")
                    {
                        //return Ok("candidate blocked successfully");
                    }
                    else {
                       // return StatusCode(301, "Application Error")
                            };

                }
                else if (cAction.ToLower() == "unblock")
                {
                    if (Candidate.Delete(CandidateModel, ref con, ref MyTran) == "200") {
                        //return Ok("candidate unblocked successfully"); 
                    }
                    else {
                       // return StatusCode(301, "Application Error");
                    }
                }



            }
            catch (System.IO.IOException e)
            {
               // return StatusCode(501, "Unkown Error. Error:" + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }

        }




        [HttpGet("favouritecandidate/{cAction}/{CandidateID}/{FavouritedByUserID}")]
        public ActionResult<string> FavouriteCandidate(string cAction, int CandidateID, int FavouritedByUserID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }


            FavouriteCandidateAsync(cAction, CandidateID, FavouritedByUserID);
            if (cAction.ToLower() == "fav")
            {
                
                    return Ok("candidate favourited successfully");
              
            }
            else if (cAction.ToLower() == "unfav")
            {
                
                    return Ok("candidate unfavourited successfully");
             
            }
            return Ok(jsonResult);



        }

        private void FavouriteCandidateAsync(string cAction, int CandidateID, int FavouritedByUserID)
        {
            Thread ApplicationProcessFlow = new Thread(() => FavouriteCandidateSync(cAction, CandidateID, FavouritedByUserID));
            ApplicationProcessFlow.IsBackground = true;
            ApplicationProcessFlow.Start();
        }
        private void FavouriteCandidateSync(string cAction, int CandidateID, int FavouritedByUserID)
        {

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidatesfavourite Candidate = new RTS.JobStation.Controller.Candidatesfavourite();
            RTS.JobStation.Models.Candidatesfavourite CandidateModel = new RTS.JobStation.Models.Candidatesfavourite();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                CandidateModel.FavouritedByUserID = FavouritedByUserID;
                CandidateModel.FavouritedOn = DateTime.Now;
                CandidateModel.CandidateID = CandidateID;
                CandidateModel.UpdatedBy = FavouritedByUserID.ToString();
                CandidateModel.UpdatedOn = DateTime.Now;


                if (cAction.ToLower() == "fav")
                {
                    if (Candidate.Insert(CandidateModel, ref con, ref MyTran) == "200") {
                       // return Ok("candidate favourited successfully");
                    }
                    else {
                       // return StatusCode(301, "Application Error");
                    };

                }
                else if (cAction.ToLower() == "unfav")
                {
                    if (Candidate.Delete(CandidateModel, ref con, ref MyTran) == "200") {
                      //  return Ok("candidate unfavourited successfully");
                    }
                    else {
                     //   return StatusCode(301, "Application Error");
                    }
                }



            }
            catch
            {
                //return StatusCode(501, "Unkown Error. Error:" + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            int userID = Int32.Parse( Request.Headers["userid"]);
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                ds = Candidate.GetCandidateDetails(ref con, ref MyTran, id, userID);

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
                return StatusCode (501,"Error");
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);

        }


        [HttpGet("applicationstatusdetails/{CandidateID}")]
        public ActionResult<string> GetApplicationStatusDetails(int CandidateID)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            int userID = Int32.Parse(Request.Headers["userid"]);
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();
            // DataSet ds = new DataSet("CandidateTimeline");
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                DataTable dtActiveJobApplications = new DataTable();
                DataTable dtCurrentApplicationStatusDetails = new DataTable();
                DataTable dtCurrentApplicationTimeLine = new DataTable();
                DataTable dtCandidatePastApplicationStatus = new DataTable();
                dtActiveJobApplications = Candidate.GetActiveJobApplications(ref con, ref MyTran, CandidateID).Tables[0];

                int CurrentApplicationID = 0;
                if (dtActiveJobApplications != null)
                {
                    if (dtActiveJobApplications.Rows.Count > 0)
                    {
                        CurrentApplicationID = Int32.Parse(dtActiveJobApplications.Rows[0]["ApplicationID"].ToString());
                       
                        dtCurrentApplicationStatusDetails = Candidate.GetCandidateApplicationStatus(ref con, ref MyTran, CurrentApplicationID).Tables[0];

                        dtCurrentApplicationTimeLine = Candidate.GetCandidateTimeLine(ref con, ref MyTran, CurrentApplicationID).Tables[0];
                    }
                }

                dtCandidatePastApplicationStatus = Candidate.GetPastJobApplications(ref con, ref MyTran, CandidateID).Tables[0];



                ds.DataSetName = "ApplicationDetails";
                dtActiveJobApplications.TableName = "ActiveJobApplications";
                dtCurrentApplicationStatusDetails.TableName = "CurrentAppliationStatus";
                dtCurrentApplicationTimeLine.TableName = "Timeline";
                dtCandidatePastApplicationStatus.TableName = "PastApplications";
                ds.Tables.Add(dtActiveJobApplications.Copy());
                ds.Tables.Add(dtCurrentApplicationStatusDetails.Copy());
                ds.Tables.Add(dtCurrentApplicationTimeLine.Copy());
                ds.Tables.Add(dtCandidatePastApplicationStatus.Copy());

                dtActiveJobApplications.Dispose();
                dtCurrentApplicationStatusDetails.Dispose();
                dtCurrentApplicationTimeLine.Dispose();
                dtCandidatePastApplicationStatus.Dispose();

                DataTable ResultInfo = new DataTable("ResultInfo");
                ResultInfo.Columns.Add("ActiveJobApplications", typeof(int));
                ResultInfo.Columns.Add("CurrentAppliationStatus", typeof(int));
                ResultInfo.Columns.Add("Timeline", typeof(int));
                ResultInfo.Columns.Add("PastApplications", typeof(int));
                DataRow rDr;
                rDr = ResultInfo.NewRow();
                rDr["ActiveJobApplications"] = dtActiveJobApplications.Rows.Count;
                rDr["CurrentAppliationStatus"] = dtCurrentApplicationStatusDetails.Rows.Count;
                rDr["Timeline"] = dtCurrentApplicationTimeLine.Rows.Count;
                rDr["PastApplications"] = dtCandidatePastApplicationStatus.Rows.Count;

                ResultInfo.Rows.Add(rDr);
                ds.Tables.Add(ResultInfo);
                ResultInfo.Dispose();



                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                     
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else { return NoContent(); }
                }
                else { return NoContent(); }


                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error");
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);

        }


        // POST api/<controller>
        [HttpPost("list")] 
        public ActionResult<string> Post([FromBody] CandidateRequestInfo value)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate Candidate = new RTS.JobStation.Controller.Candidate();


            DataSet ds = new DataSet("CandidateList");
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;


            try
            {
                con= RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                //Get Candidate Basic Info  GetCandidateBasicInfo
                RTS.JobStation.Models.CandidateRequestInfo RequestInfo = new RTS.JobStation.Models.CandidateRequestInfo();
                RequestInfo.UserID = Int32.Parse(value.UserID);
                RequestInfo.PageID = Int32.Parse( value.PageNo);
                RequestInfo.Count = Int32.Parse( value.Count) ;
                RequestInfo.FilterType = value.FilterType;

                RequestInfo.Keywords = value.Filter.Keywords;
                RequestInfo.VacanyID = Int32.Parse(value.Filter.VacanyID);
                RequestInfo.JobIndustryIDList = value.Filter.JobIndustryIDList;
                RequestInfo.TotalExperience = Int32.Parse(value.Filter.Experience);
                RequestInfo.AgeList = value.Filter.Age;
                RequestInfo.CandidateStatusIDList = value.Filter.CandidateStatusID;
                RequestInfo.GenderList = value.Filter.Gender;
                RequestInfo.NationalityIDList = value.Filter.NationalityID;
                RequestInfo.EducationList = value.Filter.Education;
                RequestInfo.LanguageSkillsList = value.Filter.LanguageSkills;

                RequestInfo.showBanned = value.Filter.showOnlyBanned;
                RequestInfo.showFavourites = value.Filter.showOnlyFavourites;



                ds = Candidate.GetCandidateList(ref con, ref MyTran, RequestInfo);


                


                ds.Tables.Add(RTS.JobStation.DatabaseCommands.GetNewTokenTable(NewToken));
                // dt = Candidate.GetCandidateList(ref con, ref MyTran,4,1,50).Tables[0];req
                jsonResult = JsonConvert.SerializeObject(ds);

                return Ok(jsonResult);

            }
            catch
            {
                return StatusCode(500);
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }

        }



        // POST api/<controller>
        [HttpPost("create")]
        public ActionResult<string> CreateCandidate([FromBody] CandidateCVInfo value)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate CandidateController = new RTS.JobStation.Controller.Candidate();

            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;


            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                //Get Candidate Basic Info  GetCandidateBasicInfo
                RTS.JobStation.Models.Candidate candidate = new RTS.JobStation.Models.Candidate();
                candidate.cvTitle = value.cvTitle;
                candidate.Objective = value.Objective;
                candidate.RefNo = value.RefNo;
                candidate.ExternalRefNo = value.ExternalRefNo;
                candidate.NameFirst = value.NameFirst;
                candidate.NameMiddle = value.NameMiddle;
                candidate.NameLast = value.NameLast;
                candidate.cvFIle = value.cvFIle;
                candidate.cvMimeType = value.cvFIle.Substring(value.cvFIle.IndexOf(".")+1, 3);
                candidate.DateOfBirth = value.DateOfBirth;
                candidate.Gender = value.Gender;
                candidate.ReligionID = value.ReligionID;
                candidate.CasteID = value.CasteID;
                candidate.MaritialStatus = value.MaritialStatus;
                candidate.NoOfDependant = value.NoOfDependant;
                candidate.Nationality = value.Nationality;
                candidate.CountryOfResidence = value.CountryOfResidence;
                candidate.CityID = value.CityID;
                candidate.VisaStatusID = value.VisaStatusID;
                candidate.NoticePeriod = value.NoticePeriod;
                candidate.Email = value.Email;
                candidate.uPassword = value.uPassword;
                candidate.MobileCountryCode = value.MobileCountryCode;
                candidate.MobileNo = value.MobileNo;
                candidate.Address = value.Address;
                candidate.PoBox = value.PoBox;
                candidate.FaxCountryCode = value.PoBox;
                candidate.FaxNo = value.FaxNo;
                candidate.isRelativeAtCompany = value.isRelativeAtCompany;
                candidate.RelativeDetails = value.RelativeDetails;
                candidate.WhyShurooq = value.WhyShurooq;
                candidate.WorkExperienceTotal = value.WorkExperienceTotal;
                candidate.WorkExperienceUAE = value.WorkExperienceUAE;
                candidate.WorkExperienceNonUAE = value.WorkExperienceNonUAE;
                candidate.UpdatedBy= Request.Headers["userid"];
                candidate.UpdatedOn = DateTime.Now;

              string result=  CandidateController.Insert(candidate, ref con, ref MyTran);
                if (result == "300")
                {
                    return StatusCode(501, "A candidate with " + value.Email + " already exist");
                }

                int CandidateID =  Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());
                if (CandidateID == 0)
                {
                    return StatusCode(500, "Error. ");
                }

                jsonResult =  CandidateID.ToString();
                CreateCandidateProfileAsync(value, CandidateID);
                return Ok(jsonResult);

            }
            catch
            {
                return StatusCode(500);
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }

        }


        private void CreateCandidateProfileAsync(CandidateCVInfo value, int CandidateID)
        {
            Thread createCandidate = new Thread(() => CreateCandidateProfile(value, CandidateID));
            createCandidate.IsBackground = true;
            createCandidate.Start();
        }
        private void CreateCandidateProfile(CandidateCVInfo value, int CandidateID)
        {
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
           
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;

            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                //Add Work History, Employee Profile
                RTS.JobStation.Controller.Workhistory EmployeeProfileController = new RTS.JobStation.Controller.Workhistory();
                RTS.JobStation.Models.Workhistory EmployeeProfileModel = new RTS.JobStation.Models.Workhistory();
                foreach (var WorkHistory in value.EmployeeProfile)
                {
                    EmployeeProfileModel.CandidateID = CandidateID;
                    EmployeeProfileModel.CountryID = WorkHistory.CountryID;
                    EmployeeProfileModel.Description = WorkHistory.Description;
                    EmployeeProfileModel.Designation = WorkHistory.Designation;
                    EmployeeProfileModel.Employer = WorkHistory.Employer;
                    EmployeeProfileModel.GrossMonthlySalary = WorkHistory.GrossMonthlySalary;
                    EmployeeProfileModel.isLatestJob = WorkHistory.isLatestJob;
                    EmployeeProfileModel.ReasonForLeaving = WorkHistory.ReasonForLeaving;
                    EmployeeProfileModel.ReportingTo = WorkHistory.ReportingTo;
                    EmployeeProfileModel.ToDate = WorkHistory.ToDate;
                    EmployeeProfileModel.FromDate = WorkHistory.FromDate;
                    EmployeeProfileModel.UpdatedBy = Request.Headers["userid"];
                    EmployeeProfileModel.UpdatedOn = DateTime.Now;
                    EmployeeProfileController.Insert(EmployeeProfileModel, ref con, ref MyTran);
                }


                //Add Education History, Education Profile
                RTS.JobStation.Controller.Educationhistory EducationHistoryController = new RTS.JobStation.Controller.Educationhistory();
                RTS.JobStation.Models.Educationhistory EducationHistoryModel = new RTS.JobStation.Models.Educationhistory();

                foreach (var EducationHistory in value.EducationProfile)
                {
                    EducationHistoryModel.CandidateID = CandidateID;
                    EducationHistoryModel.CompletionYear = EducationHistory.CompletionYear;
                    EducationHistoryModel.CountryID = EducationHistory.CountryID;
                    EducationHistoryModel.Description = EducationHistory.Description;
                    EducationHistoryModel.EducationQualificationID = EducationHistory.EducationQualificationID;
                    EducationHistoryModel.ExamResult = EducationHistory.ExamResult;
                    EducationHistoryModel.Institute = EducationHistory.Institute;
                    EducationHistoryModel.UpdatedBy = Request.Headers["userid"];
                    EducationHistoryModel.UpdatedOn = DateTime.Now;

                    EducationHistoryController.Insert(EducationHistoryModel, ref con, ref MyTran);
                }

                //Add Preffered Location
                RTS.JobStation.Controller.Candidateprefferedlocation CandidatePrefferedLocationController = new RTS.JobStation.Controller.Candidateprefferedlocation();
                RTS.JobStation.Models.Candidateprefferedlocation CandidatePrefferedLocationModel = new RTS.JobStation.Models.Candidateprefferedlocation();
                foreach (var Location in value.PrefferedLocation)
                {
                    CandidatePrefferedLocationModel.CandidateID = CandidateID;
                    CandidatePrefferedLocationModel.LocationID = Location.LocationID;
                    CandidatePrefferedLocationModel.UpdatedBy = Request.Headers["userid"];
                    CandidatePrefferedLocationModel.UpdatedOn = DateTime.Now;
                    CandidatePrefferedLocationController.Insert(CandidatePrefferedLocationModel, ref con, ref MyTran);
                }


                //Add Job Industry
                RTS.JobStation.Controller.Candidatejobindustry CandidatejobindustryController = new RTS.JobStation.Controller.Candidatejobindustry();
                RTS.JobStation.Models.Candidatejobindustry CandidatejobindustryModel = new RTS.JobStation.Models.Candidatejobindustry();
                foreach (var Industry in value.JobIndustry)
                {
                    CandidatejobindustryModel.CandidateID = CandidateID;
                    CandidatejobindustryModel.IndustryID = Industry.IndustryID;
                    CandidatejobindustryModel.UpdatedBy = Request.Headers["userid"];
                    CandidatejobindustryModel.UpdatedOn = DateTime.Now;
                    CandidatejobindustryController.Insert(CandidatejobindustryModel, ref con, ref MyTran);
                }
            }
            catch
            {
              
            }
            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);
            };

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



    }


    public class CandidateRequestInfo
    {
        public string  UserID { get; set; }
        public string  isGetType { get; set; } // All | Active | Inactive
        public string FilterType { get; set; } // None | Filtered | Single 
        public string  RequestType { get; set; }
        public string  Count { get; set; }
        public string  PageNo { get; set; }
        public CandidateFilterInfo Filter { get; set; }
    }

    public class CandidateFilterInfo
    {
        public string  VacanyID { get; set; }
        public string Keywords { get; set; } 
        public string JobIndustryIDList { get; set; } 
        public string  Experience { get; set; }
        public string Age { get; set; }
        public string  CandidateStatusID { get; set; }
        public string Gender { get; set; }
        public string NationalityID { get; set; }
        public string Education { get; set; }
        public string LanguageSkills { get; set; }
        public Boolean showOnlyFavourites { get; set; }
        public Boolean showOnlyBanned { get; set; }

    }

    public class CandidateCVInfo
    {
        public string cvTitle { get; set; }
        public string Objective { get; set; }
        public string RefNo { get; set; }
        public string ExternalRefNo { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string cvFIle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int ReligionID { get; set; }
        public int CasteID { get; set; }
        public string MaritialStatus { get; set; }
        public int NoOfDependant { get; set; }
        public int Nationality { get; set; }
        public int CountryOfResidence { get; set; }
        public int CityID { get; set; }
        public int VisaStatusID { get; set; }
        public string NoticePeriod { get; set; }
        public string Email { get; set; }
        public string uPassword { get; set; }
        public string MobileCountryCode { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string PoBox { get; set; }
        public string FaxCountryCode { get; set; }
        public string FaxNo { get; set; }
        public bool isRelativeAtCompany { get; set; }
        public string RelativeDetails { get; set; }
        public string WhyShurooq { get; set; }
        public int WorkExperienceTotal { get; set; }
        public int WorkExperienceUAE { get; set; }
        public int WorkExperienceNonUAE { get; set; }
        public List<CandidateWorkHistory> EmployeeProfile { get; set; }
        public List<CandidateEducationHistory> EducationProfile { get; set; }
        public List<CandidatePrefferedJobLocation> PrefferedLocation { get; set; }
        public List<CandidateJobIndustry> JobIndustry { get; set; }
    }

    public class CandidateWorkHistory
    {
       // public int CandidateID { get; set; }
        public string Designation { get; set; }
        public string Employer { get; set; }
        public string ReportingTo { get; set; }
        public string ReasonForLeaving { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool isLatestJob { get; set; }
        public int GrossMonthlySalary { get; set; }
        public int CountryID { get; set; }
        public string Description { get; set; }

    }

    public class CandidateEducationHistory
    {
       // public int CandidateID { get; set; }
        public int EducationQualificationID { get; set; }
        public string Institute { get; set; }
        public DateTime CompletionYear { get; set; }
        public string ExamResult { get; set; }
        public int CountryID { get; set; }
        public string Description { get; set; }

    }

    public class CandidatePrefferedJobLocation
    {
       // public int CandidateID { get; set; }
        public int LocationID { get; set; }
    }

    public class CandidateJobIndustry
    {
       // public int CandidateID { get; set; }
        public int IndustryID { get; set; }
    }



}
