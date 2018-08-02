using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_task1.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        // GET: api/info/fromfile
        [HttpGet("fromfile")]
        public string Get()
        {
            string res = "";
            try
            {
                StreamReader myReader = new StreamReader(new FileStream("assets/text.txt", FileMode.Open, FileAccess.Read));
                res = myReader.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }
}
