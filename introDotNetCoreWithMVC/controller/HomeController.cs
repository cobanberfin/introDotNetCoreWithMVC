using introDotNetCoreWithMVC.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            ViewBag.Name = "sena"; //vieve deger tasıcak

            ViewBag.IsRedPill = true;
            ViewBag.products = new string[] { "soda", "ayran", "kola", "kahve" };

            return View();
        }
        public IActionResult useModel()
        {               // drınks bır modeldır burda
            List<Drink> drinks = new List<Drink>
            {
                new Drink{ Name="su",Price=1.5},
                new Drink{ Name="soda",Price=3},
                new Drink{ Name="kahve",Price=7},
                new Drink{ Name="ayran",Price=8},


            };
            return View(drinks);


        }

        public IActionResult userRegister()
        {
            return View();
        }

        [HttpPost] //butona bastıktan sonra  buraya gelcek

        public IActionResult userRegister(user user )
        {//backend tarafında valıdation : modelState : bu actioana göderilen parametrenın kurala uyup uymadıgna bakar
            if (ModelState.IsValid) //arguman olarak aldığı  user kurallara uygun mu değilmi yanı boş gecılmemısse vt ekle
            {
                
            }

            return View();
        }

    }
}
