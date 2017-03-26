using AutoMapper;
using CustomerRelations.Service;
using CustomerRelations.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerRelations.Model;

namespace CustomerRelations.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringResourceService stringResourceService;

        public HomeController(IStringResourceService _stringResourceService)
        {
            this.stringResourceService = _stringResourceService;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}