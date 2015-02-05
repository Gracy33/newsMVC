using News.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class AuthorController : Controller
    {
        //
        // GET: /Author/
        [HttpGet]
        public ActionResult Index(int id)
        {
            Author aut = Author.ChargeAuthor(id);
            return View(aut);
        }
	}
}