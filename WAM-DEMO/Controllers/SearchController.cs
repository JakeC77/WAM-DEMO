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
            query = query.ToLower();
            var searched = data.Where(d => d.FirstName.ToLower().Contains(query) || d.LastName.ToLower().Contains(query) || d.Position.ToLower().Contains(query));
            return Json(searched);
        }
    }
}