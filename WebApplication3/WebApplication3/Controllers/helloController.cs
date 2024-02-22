using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class helloController : Controller
    {
        // GET: hello
        public ActionResult Index()
        {
            List<FileName> nightmarket = new List<FileName>();
            nightmarket.Add(new FileName { id = "A01", name="五甲夜市",address= "407台中市西屯區文華路" });
            nightmarket.Add(new FileName { id = "A02", name = "五甲夜市", address = "404台中市北區一中街" });
            nightmarket.Add(new FileName { id = "A03", name = "五甲夜市", address = "400台中市中區公園路" });
            nightmarket.Add(new FileName { id = "A04", name = "五甲夜市", address = "402台中市南區忠孝路" });
            nightmarket.Add(new FileName { id = "A05", name = "五甲夜市", address = "420台中市豐原區中正路167巷" });
            nightmarket.Add(new FileName { id = "A06", name = "五甲夜市", address = "433台中市龍井區新興路" });


            return View(nightmarket);
        }
    }
}