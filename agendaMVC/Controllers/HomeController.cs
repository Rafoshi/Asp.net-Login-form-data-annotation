using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agendaMVC.Models;

namespace agendaMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var agenda = new Agenda();
            return View(agenda);
        }
        [HttpPost]
        public ActionResult Contato(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                return View("Lista", agenda);
            }
            return View(agenda);

        }
        public ActionResult Lista(Agenda agenda)
        {
                return View(agenda);
        }
        public ActionResult EmailUnic(string email)
        {
            var bd = new Collection<string>
            {
                "rafa.ioshi@gmail.com",
                "taty.imamura@gmail.com",
                "joao@gmail.com"
            };
            return Json(bd.All(x => x.ToLower() != email.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}