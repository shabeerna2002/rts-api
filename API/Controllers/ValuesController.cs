using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RTS;
using StackExchange.Redis;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase

    {


        
        IConfiguration configuration;
        public ValuesController(IConfiguration iconfiguration)
        {
            this.configuration = iconfiguration;
        }
        // GET api/values
        [HttpGet]
        //  public ActionResult<IEnumerable<RTS.JobStation.Models.Religion>> Get()
        public ActionResult<string> Get()
        {




            string conStr = configuration.GetSection("Data").GetSection("ConntectionString").Value;
            RTS.JobStation.Controller.Candidate candidate = new RTS.JobStation.Controller.Candidate();


            DataTable dt = new DataTable();   
            List< RTS.JobStation.Models.Religion> ReligionList = new List<RTS.JobStation.Models.Religion>();
          
            MySql.Data.MySqlClient.MySqlConnection con = RTS.JobStation.DatabaseCommands.OpenConnection();
            MySql.Data.MySqlClient.MySqlTransaction MyTran;
            MyTran = RTS.JobStation.DatabaseCommands.OpenTransaction(ref con);

            //Get All Relgion
            RTS.JobStation.Controller.Religion religion = new RTS.JobStation.Controller.Religion();
            dt = religion.GetAllReligion(ref con, ref MyTran).Tables[0];
            string json1 = JsonConvert.SerializeObject(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RTS.JobStation.Models.Religion religionM = new RTS.JobStation.Models.Religion();
                religionM.ReligionID = Convert.ToInt32(dt.Rows[i]["ReligionID"]);
                religionM.Religion = dt.Rows[i]["Religion"].ToString();
                ReligionList.Add(religionM);
            }

          

            string json = JsonConvert.SerializeObject(ReligionList);
            //Deserialize the JSon value and assign it to datatable
            DataTable dtValue = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));






            DataSet ds = new DataSet("DataSet");
            // Table for parents
            DataTable parentTable = new DataTable("Parents");
            parentTable.Columns.Add("ParentId", typeof(int));
            parentTable.Columns.Add("ParentName", typeof(string));


            //Create some parents.


            parentTable.Rows.Add(new object[] { 1, "Parent # 1" });
            parentTable.Rows.Add(new object[] { 2, "Parent # 2" });
            parentTable.Rows.Add(new object[] { 3, "Parent # 3" });


            ds.Tables.Add(parentTable);

            // Table for childrend


            DataTable childTable = new DataTable("Childs");
            childTable.Columns.Add("ChildId", typeof(int));
            childTable.Columns.Add("ChildName", typeof(string));
            childTable.Columns.Add("ParentId", typeof(int));


            //Create some childs.


            childTable.Rows.Add(new object[] { 1, "Child # 1", 1 });
            childTable.Rows.Add(new object[] { 2, "Child # 2", 2 });
            childTable.Rows.Add(new object[] { 3, "Child # 3", 1 });
            childTable.Rows.Add(new object[] { 4, "Child # 4", 3 });
            childTable.Rows.Add(new object[] { 5, "Child # 5", 3 });
            ds.Tables.Add(childTable);


            // Create their relation.

    
            DataRelation parentChildRelation = new DataRelation("ParentChild", parentTable.Columns["ParentId"], childTable.Columns["ParentId"],true );
            parentChildRelation.Nested = true;
            ds.Relations.Add(parentChildRelation);
            ds.DataSetName = "Candidate";

            string xml = ds.GetXml();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            //string json2 = JsonConvert.SerializeObject(doc.GetElementsByTagName("Parents"));
           
            string json2 = JsonConvert.SerializeObject(doc);



            //Deserialize
            string jsonD = @"{'Parents':[{'ParentId':'1','ParentName':'Parent # 1','Childs':[{'ChildId':'1','ChildName':'Child # 1','ParentId':'1'},{'ChildId':'3','ChildName':'Child # 3','ParentId':'1'}]},{'ParentId':'2','ParentName':'Parent # 2','Childs':{'ChildId':'2','ChildName':'Child # 2','ParentId':'2'}},{'ParentId':'3','ParentName':'Parent # 3','Childs':[{'ChildId':'4','ChildName':'Child # 4','ParentId':'3'},{'ChildId':'5','ChildName':'Child # 5','ParentId':'3'}]}]}";
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jsonD);
            DataTable dataTable = dataSet.Tables[0];




            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost,password=shabeer");

            IDatabase db = redis.GetDatabase(2);

            //if (db.StringSet("shabeeraug2018", "testValue123"))
            // {
            //     var val = db.StringGet("testKey");

            //  Console.WriteLine(val);
            //   }

            db.KeyDelete("shabeeraug2018");
            db.StringSet("shabeeraug2018", "testValue123");
            db.StringSet("shabeeraug2018", "testValue12345");

            return json2;






            //return ReligionList;

            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Cars value, [FromHeader] string token)
        {
            variation v;
            v = value.Colors[0];
            string abc = v.color;
          

            return  Ok("250-" + token);
           
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public async void AsyncTask(int id)
        {
            Task<int> task = new Task<int>(LongTask);
            task.Start();
            string abc = "you can have many things here";
            abc = "next command";
            int count = await task;
            abc = abc + count;

        }

        private int LongTask()
        {
            return 1;
        }




    }

    public class Cars
    {
        public int id { get; set; }
        public string CarName { get; set; }
        public DateTime UpdateBy { get; set; }
        public List<variation> Colors { get; set; }
    }

    public class variation
    {
        public string color { get; set; }
    }






}
