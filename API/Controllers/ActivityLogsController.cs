using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace RTS.Controllers
//{
//    [Route("api/[controller]")]
//    //public class ActivityLogsController : Controller
//    //{
//    //    string NewToken = "";
//    //    Microsoft.Extensions.Configuration.IConfiguration configuration;

//    //    public ActivityLogsController(IConfiguration iconfiguration)
//    //    {
//    //        this.configuration = iconfiguration;
//    //    }

//    //    private bool AuthenticateUser()
//    //    {
//    //        string UserID = Request.Headers["userid"];
//    //        string ApiKey = Request.Headers["apikey"];
//    //        string UserKey = Request.Headers["userkey"];
//    //        string ConsumerKey = Request.Headers["consumerkey"];
//    //        string Token = Request.Headers["token"];
//    //        NewToken = RTS.JobStation.DatabaseCommands.AuthenticateUser(UserID, UserKey, ApiKey, ConsumerKey, Token);
//    //        if ((NewToken.ToLower().IndexOf("valid") >= 0))
//    //        {
//    //            return true;
//    //        }
//    //        else
//    //        {
//    //            return false;
//    //        }

//    //    }
//    //    // GET: api/<controller>
//    //    [HttpGet]
//    //    public IEnumerable<string> Get()
//    //    {
//    //        return new string[] { "value1", "value2" };
//    //    }

//    //    // GET api/<controller>/5
//    //    [HttpGet("{candidateid}")]
//    //    public ActionResult<string>  Get(int candidateid)
//    //    {
//    //        if (AuthenticateUser() == false)
//    //        {
//    //            return Unauthorized();
//    //        }



//    //        string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
//    //        RTS.JobStation.Controller.Activitylog Activitylog = new RTS.JobStation.Controller.Activitylog();


//    //        DataSet ds = new DataSet("ActivityLogs");
//    //        MySql.Data.MySqlClient.MySqlConnection con = RTS.JobStation.DatabaseCommands.OpenConnection();
//    //        MySql.Data.MySqlClient.MySqlTransaction MyTran;
//    //        MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);





//    //     //   ds = Activitylog.GetActivityLogs(ref con, ref MyTran, candidateid);
//    //        // ds.Tables[0].TableName = "ActivityLogs";

//    //        ds = Activitylog.ge (ref con, ref MyTran, 1);
//    //        ds.Tables[0].TableName = "ActivityLogsDocuments";

//    //        ds.Tables.Add(RTS.JobStation.DatabaseCommands.GetNewTokenTable(NewToken));
//    //        // dt = Candidate.GetCandidateList(ref con, ref MyTran,4,1,50).Tables[0];req
//    //        string jsonResult = JsonConvert.SerializeObject(ds);
//    //        RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
//    //        RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

//    //        return Ok(jsonResult);
//    //    }

//    //    // POST api/<controller>
//    //    [HttpPost]
//    //    public void Post([FromBody]string value)
//    //    {
//    //    }

//    //    // PUT api/<controller>/5
//    //    [HttpPut("{id}")]
//    //    public void Put(int id, [FromBody]string value)
//    //    {
//    //    }

//    //    // DELETE api/<controller>/5
//    //    [HttpDelete("{id}")]
//    //    public void Delete(int id)
//    //    {
//    //    }
//    //}
//}
