using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTS.Controllers
{
    [Route("api/[controller]")]
    public class PortalController : Controller
    {


        string NewToken = "";
        IConfiguration configuration;
        public PortalController(IConfiguration iconfiguration)
        {
            this.configuration = iconfiguration;
        }
        private bool AuthenticateUser()
        {
            string UserID = "2";
            string ApiKey = Request.Headers["apikey"];
            string UserKey = Request.Headers["userkey"];
            string ConsumerKey = Request.Headers["consumerkey"];
            string Token = Request.Headers["token"];
            NewToken = RTS.JobStation.DatabaseCommands.AuthenticateUser(UserID, UserKey, ApiKey, ConsumerKey, Token);

            // if (UserKey = "abc" && ApiKey != "23Aw87%^ksjdfk*sdkf" && ConsumerKey != "AJDFKT564" && Token != "jd$#sdf8*kfjks#949389jdskfj")
            if (UserKey != "abc")
            {
               return false;
           }



            if ((NewToken.ToLower().IndexOf("valid") >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // POST api/<controller>
        [HttpPost("create")]
        public ActionResult<string> CreateCandidate([FromBody] CandidateCVInfo value, [FromQuery] string apikey, [FromQuery] string userkey, [FromQuery] string consumerkey, [FromQuery] string token, [FromQuery] int userid)
        {
            string jsonResult = "";
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            /* if (apikey != "123")
             {
                 return Unauthorized();
             }*/

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
                candidate.cvMimeType = value.cvFIle.Substring(value.cvFIle.IndexOf(".") + 1, 3);
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
                candidate.RelevantExperience = value.RelevantExperience;
                candidate.UpdatedBy = Request.Headers["userid"];
                candidate.UpdatedOn = DateTime.Now;

                string result = CandidateController.Insert(candidate, ref con, ref MyTran);
                if (result == "300")
                {
                    return StatusCode(501, "A candidate with " + value.Email + " already exist");
                }

                int CandidateID = Int32.Parse(JobStation.DatabaseCommands.GetLastInsertedID(ref con, ref MyTran).ToString());
                if (CandidateID == 0)
                {
                    return StatusCode(500, "Error. ");
                }

                jsonResult = CandidateID.ToString();
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
                ds = Jobs.GetVacancyDetailsForCareerPortal(ref con, ref MyTran, vacancyid);
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

        [HttpGet("vacancylist")]
        public ActionResult<string> GetVacancyList()
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
                ds = Jobs.GetVacancyListActiveForCareerPortal(ref con, ref MyTran);
                ds.DataSetName = "Vacancies";
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

        // GET api/<controller>/5
        [HttpGet("getcandidate/{id}")]
        public ActionResult<string> Get(int id)
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
                ds = Candidate.GetCandidateDetails(ref con, ref MyTran, id, userID);

                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        string xml = ds.GetXml();




                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);

                        var xTag = doc.GetElementsByTagName("EmploymentProfile");

                        if (xTag.Count == 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }

                        xTag = doc.GetElementsByTagName("AcademicProfile");
                        if (xTag.Count == 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }

                        xTag = doc.GetElementsByTagName("PastApplications");
                        if (xTag.Count == 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }

                        xTag = doc.GetElementsByTagName("ShortlistableJobs");
                        if (xTag.Count == 1)
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
                return StatusCode(501, "Error" + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


            return Ok(jsonResult);

        }


        [HttpPost("uploadCV/")]
        public async Task<IActionResult> UploadDocument(List<IFormFile> files, [FromQuery] string apikey, [FromQuery] string userkey, [FromQuery] string consumerkey, [FromQuery] string token, [FromQuery] int userid)
        {

            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            //if (apikey != "123")
            //{
            //    return Unauthorized();
            //}

            //Do something with the files here. 

            String FileName = "";
            String NewFileName = "";
            String Extention = "";

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Models.Requestfile RequestFileModel = new RTS.JobStation.Models.Requestfile();
            RTS.JobStation.Controller.Requestfile RequestFileController = new RTS.JobStation.Controller.Requestfile();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;



            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        if (file == null || file.Length == 0)
                            return Content("file not selected");
                        FileName = file.FileName;

                        Extention = System.IO.Path.GetExtension(file.FileName);
                        NewFileName = "cv-1510-" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.DayOfYear.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + DateTime.Now.Millisecond + "-" + DateTime.Now.Ticks.ToString() + "-gd-" + Guid.NewGuid().ToString() + Extention;
                        var path = Path.Combine(
                                    Directory.GetCurrentDirectory(), "wwwroot", "cvs", NewFileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }


                }

                return Ok(NewFileName);
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Error:" + ex.Message.ToString());
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



    }


}
