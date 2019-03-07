using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();
        }
        public string showAuthor()
        {
            return "le khac huy";
        }
        public double Factorial(int n)
        {

            double fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
        public int Sum(int a, int b)
        {
            int tong = a + b;
            return tong;
        }
	}
}