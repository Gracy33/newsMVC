using News.DAL;
using News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            List<InfoNews> infos = InfoNews.ChargeFive();
            return View(infos);
        }

        public ActionResult Infos()
        {
            List<InfoNews> infos = InfoNews.ChargeAll();
            return View("Index", infos);
        }

        [HttpGet]
        public ActionResult Details(int idNews, int idAuthor)
        {
            Wrapper wrap = new Wrapper();
            wrap.Anews = InfoNews.ChargeInfo(idNews);
            wrap.Auteur = Author.ChargeAuthor(idAuthor);
            return View(wrap);
        }
	}
}