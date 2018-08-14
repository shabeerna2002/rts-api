using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTS.Controllers
{




    [Route("api/[controller]")]

    public class DocumentUploadController : Controller
    {

        string NewToken = "";
        IConfiguration configuration;
        public DocumentUploadController(IConfiguration iconfiguration)
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



        [HttpPost]
        public IActionResult Post(List<IFormFile> files)
        {
            //Do something with the files here. 
            return Ok();
        }


        [HttpPost("uploadCV/")]
        public async Task<IActionResult> UploadDocument(List<IFormFile> files)
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
                        NewFileName = "cv-1510-" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.DayOfYear.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + DateTime.Now.Millisecond + "-" + DateTime.Now.Ticks.ToString() + "-gd-" + Guid.NewGuid().ToString() + Extention;
                        var path = Path.Combine(
                                    Directory.GetCurrentDirectory(),  "wwwroot", "cvs", NewFileName);

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
                return StatusCode(500);
            }
            finally
            {
                RTS.JobStation.DatabaseCommands.CloseTransaction(ref MyTran);
                RTS.JobStation.DatabaseCommands.CloseConnection(ref con);

            }






        }

    }


}
