using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApp.Controllers
{
    public class HelloWorldController : Controller
    { 

        // GET: /HelloWorld/ 

        public string Index()
        {
            return "这是我的默认动作...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "我是一个欢迎方法...";
        }
        public string Welcome2(string name, int ID = 1)
        {           
            return HtmlEncoder.Default.HtmlEncode(
                "hello,name:" + name + ",id:" + ID);
        }
    }
}
