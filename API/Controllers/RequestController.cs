using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
    public class RequestController : Controller


    {

        string NewToken = "";
        IConfiguration configuration;
        public RequestController(IConfiguration iconfiguration)
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

        [HttpGet("groupdetails/{CurrentLoggedInUserID}/{StateGroupID}")]
        public ActionResult<string> GetRequestGroupWiseDetails(int StateGroupID, int CurrentLoggedInUserID, [FromQuery]int VacancyID = 0, [FromQuery]string GroupResultBy = "tDate")
        {

            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }
            string jsonResult = "";
            DataSet ds = new DataSet();
            ds.DataSetName = "Request";
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Request RequestController = new RTS.JobStation.Controller.Request();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);


                ds= RequestController.GetRequestGroupWiseDetails(ref con, ref MyTran, StateGroupID,CurrentLoggedInUserID, VacancyID, GroupResultBy);
                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        ds.DataSetName = "Request";
                        string xml = ds.GetXml();
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);

                        var xTag = doc.GetElementsByTagName("RequestList");

                        if (xTag.Count == 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }

                        xTag = doc.GetElementsByTagName("RequestDetails");

                        if (xTag.Count == 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            var node = xTag.Item(0) as XmlElement;
                            node.Attributes.Append(attribute);
                        }

                        xTag = doc.GetElementsByTagName("RequestDetails");
                        if (xTag.Count >= 1)
                        {
                            var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                            attribute.InnerText = "true";
                            attribute.Value = "true";

                            // var node = xTag.Item(0) as XmlElement;
                            var xtagCount = xTag.Count;
                            for (int i = 0; i < xtagCount; i++)
                            {
                                var node = xTag.Item(i);
                                node.Attributes.Append(attribute);
                            }

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
                return StatusCode(501, "Error - " + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }

            return Ok(jsonResult);
        }


        



        // GET api/<controller>/5
        [HttpGet("transitstate")]
        public ActionResult<string> TransitState([FromQuery] int ActionTypeID, [FromQuery] int  ActionID, [FromQuery] int ApplicationID, [FromQuery] int ReuqesterUserID, [FromQuery] int DesiredStateID, [FromQuery] int RequestID, [FromQuery] int TransactionUserID, [FromQuery] int TransitionID)
        {
            
            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }

            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Models.Request requestModel = new RTS.JobStation.Models.Request();
            RTS.JobStation.Controller.Request requestController = new RTS.JobStation.Controller.Request();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

                RTS.JobStation.Controller.Request RequestWorkFlowController = new RTS.JobStation.Controller.Request();
                RequestWorkFlowController.TransitionAction(ref con, ref MyTran,ActionTypeID,ActionID,ApplicationID,ReuqesterUserID,DesiredStateID,RequestID,TransactionUserID, TransitionID);

               

                return Ok("Applied Successfully");

                // jsonResult = JsonConvert.SerializeObject(ds);
            }
            catch (System.IO.IOException e)
            {
                return StatusCode(501, "Error - " + e.Message.ToString());
            }

            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }


           
        }


        [HttpPost("uploadfiles/{candidateID}/{RequestID}" )]
        public async Task<IActionResult> UploadDocument(List<IFormFile> files, int candidateID, int RequestID)
        {
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
                        NewFileName = Guid.NewGuid().ToString() + Extention;
                        var path = Path.Combine(
                                    Directory.GetCurrentDirectory(), "wwwroot", "cvs", NewFileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }

              
                    RequestFileModel.UserID = Int32.Parse(Request.Headers["UserID"].ToString());
                    RequestFileModel.FileName = FileName;
                    RequestFileModel.FileURL = NewFileName;
                    RequestFileModel.MIMEType = Extention;
                    RequestFileModel.RequestID = RequestID;
                    RequestFileModel.UpdatedBy = Request.Headers["UserID"];
                    RequestFileModel.UpdatedOn = DateTime.Now;

                    RequestFileController.Insert(RequestFileModel, ref con, ref MyTran);

                }

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }






        }


        [HttpGet("downloadfile")]
        public async Task<IActionResult> DownloadFile([FromQuery] string filename, [FromQuery]string DownloadFileName )
        {
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", "cvs", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), DownloadFileName);

            // return File(memory, GetContentType(path), Path.GetFileName(path));  
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
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
