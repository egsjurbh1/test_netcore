using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace test_netcore.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // CTRL+F5 运行，可以所写即所见
        // GET: /HelloWorld/Welcome/ 
        // http://localhost:1849/HelloWorld/Welcome/?name=liqin&numtimes=3  
        //localhost:xxxx/controller类/方法?参数1&参数2
        public string Welcome(string name, int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes:{numtimes}");
        }

        // http://localhost:1849/HelloWorld/Welcome/3?name=Rick
        // StartUp中的routes.MapRoute  "{controller=Home}/{action=Index}/{id?}"，
        // 定义入参id为变量，匹配到Welcome方法的ID变量
        public string Welcome1(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID:{ID}");
        }
    }
}
