using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTS.Controllers
{
    [Route("api/[controller]")]
    public class CommonController : Controller
    {



        string NewToken = "";
        IConfiguration configuration;

        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.OK };
        }


        public CommonController(IConfiguration iconfiguration)
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

            //if (UserKey != "apple" && ApiKey != "mango" && ConsumerKey != "good" && Token != "123")
            //{
            //    return false;
            //}



            if ((NewToken.ToLower().IndexOf("valid") >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [HttpGet("loginsystemuser")]
        public ActionResult<string> LogInSystemUser([FromQuery] string UserName, [FromQuery] string Password)
        {

            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }
            string jsonResult = "";
            DataSet ds = new DataSet();
            ds.DataSetName = "UserDetails";
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.User UserController = new RTS.JobStation.Controller.User();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);


                ds = UserController.CheckLoginUserInfo(ref con, ref MyTran, UserName,Password, 1);  //User Type ID 1 is for System User
                DataTable dt = new DataTable("UserDetails");
                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        //ds.DataSetName = "UserDetails";
                        //string xml = ds.GetXml();
                        //XmlDocument doc = new XmlDocument();
                        //doc.LoadXml(xml);

                        //var xTag = doc.GetElementsByTagName("UserDetails");

                        //if (xTag.Count == 1)
                        //{
                        //    var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                        //    attribute.InnerText = "true";
                        //    attribute.Value = "true";

                        //    var node = xTag.Item(0) as XmlElement;
                        //    node.Attributes.Append(attribute);
                        //}

                        //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
                        ds.Tables[0].TableName = "UserDetails";
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else {
                        ds.Tables.Add(dt);
                        jsonResult = JsonConvert.SerializeObject(ds);

                    }
                }
                else {
                    ds.Tables.Add(dt);
                    jsonResult = JsonConvert.SerializeObject(ds);
                }




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


        [HttpGet("getdashboard/{dashboardid}")]
        public ActionResult<string> GetDashboard(int dashboardid=1, [FromQuery] int ChartDailyPlotDisplayCount=7)
        {

            if (AuthenticateUser() == false)
            {
                return Unauthorized();
            }
            string jsonResult = "";
            DataSet ds = new DataSet();
            ds.DataSetName = "Dashboard";
            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Dashboard DashboardController = new RTS.JobStation.Controller.Dashboard();
            MySql.Data.MySqlClient.MySqlConnection con = null;
            MySql.Data.MySqlClient.MySqlTransaction MyTran = null;
            try
            {
                con = RTS.JobStation.DatabaseCommands.OpenConnection();
                MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);


               ds = DashboardController.GetDashboard(ref con, ref MyTran, ChartDailyPlotDisplayCount);  //User Type ID 1 is for System User
                DataTable dt = new DataTable("dashboard");
                if (ds != null)
                {

                    if (ds.Tables.Count > 0)
                    {
                        //ds.DataSetName = "UserDetails";
                        //string xml = ds.GetXml();
                        //XmlDocument doc = new XmlDocument();
                        //doc.LoadXml(xml);

                        //var xTag = doc.GetElementsByTagName("UserDetails");

                        //if (xTag.Count == 1)
                        //{
                        //    var attribute = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                        //    attribute.InnerText = "true";
                        //    attribute.Value = "true";

                        //    var node = xTag.Item(0) as XmlElement;
                        //    node.Attributes.Append(attribute);
                        //}

                        //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
                        ds.Tables[0].TableName = "dashboard";
                        jsonResult = JsonConvert.SerializeObject(ds);
                    }
                    else
                    {
                        ds.Tables.Add(dt);
                        jsonResult = JsonConvert.SerializeObject(ds);

                    }
                }
                else
                {
                    ds.Tables.Add(dt);
                    jsonResult = JsonConvert.SerializeObject(ds);
                }




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
    }
}
