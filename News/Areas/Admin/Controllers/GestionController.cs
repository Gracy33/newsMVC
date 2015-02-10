using News.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Areas.Admin.Controllers
{
    public class GestionController : Controller
    {
        //
        // GET: /Admin/Gestion/
        public ActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjouterNews(string newsTitle, string newsResume, string newsText, int idAuthor, string newsImage)
        {
            InfoNews nouvelle = new InfoNews();
            nouvelle.insertNews(newsTitle, newsResume, newsText, idAuthor, newsImage);

            return RedirectToRoute(new { area = "", controller = "Home", action = "Index" });
        }

        [HttpGet]
        public ActionResult ModifierNews(int id)
        {
            InfoNews info = InfoNews.ChargeInfo(id);
            return View(info);            
        }


        [HttpPost]
        public ActionResult ModifierNews(InfoNews info)
        {
            info.updateNews();
            return RedirectToRoute(new { area = "", controller = "Home", action = "Index" });
        }

        public ActionResult supprimernews(int id)
        {
            InfoNews info = InfoNews.ChargeInfo(id);
            info.deleteNews(id);
            return RedirectToRoute(new { area = "", controller = "home", action = "index" });
        }
    }
}