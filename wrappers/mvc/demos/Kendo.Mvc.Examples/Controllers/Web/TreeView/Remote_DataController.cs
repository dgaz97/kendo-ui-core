﻿using System.Web.Mvc;
using System.Linq;
using Kendo.Mvc.Examples.Models;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class TreeViewController : Controller
    {
        public ActionResult Remote_Data()
        {
            return View();
        }

        public JsonResult Employees()
        {
            var dataContext = new NorthwindDataContext();

            var employees = from e in dataContext.Employees
                            where e.ReportsTo == null
                            select e;

            return new JsonResult { Data = employees };
        }
    }
}