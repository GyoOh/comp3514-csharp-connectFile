using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStar.Models;
using System.Diagnostics;

namespace WebStar.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            var files = Directory.GetFiles("TextFiles");

            return View();

        }
        public IActionResult content(int id)
        {
            string texts = System.IO.File.ReadAllText("TextFiles/File" + id + ".txt");
            ViewBag.Data = texts;
            return View();
        }


    }
}