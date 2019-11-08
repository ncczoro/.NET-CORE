using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
       public static InformationService informationService = new InformationService();
        // GET: /<controller>/
        public IActionResult Main()
        {
         var  InformationModle = new Information();
            
            return View(informationService.createData());
        }

        public IActionResult addNew()
        {
            return View();
        }

        public IActionResult addNewItem(Information InformationModle)
        {
            informationService.add(InformationModle);
            return Redirect("/Main/Main");
        }

        public IActionResult Details(int id)
        {
            informationService.details(id);
            return Redirect("/Main/Main");
        }
    }
}
