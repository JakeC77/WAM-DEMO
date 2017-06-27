using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAM_DEMO.Models;

namespace WAM_DEMO.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Search(string query)
        {
            var data = Record.GetDummyData();
            var searched = data.Where(d => d.FirstName.Contains(query) || d.LastName.Contains(query) || d.Position.Contains(query));
            return Json(searched);
        }
    }
}