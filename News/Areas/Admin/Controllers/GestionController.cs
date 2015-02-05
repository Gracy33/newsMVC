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
        public ActionResult Ajouter(){
            return View();
        }

        [HttpPost]
        public ActionResult AjouterNews(string newsTitle, string newsResume, string newsText, int idAuthor, string newsImage)
        {
            InfoNews nouvelle = new InfoNews();
            nouvelle.insertNews(newsTitle, newsResume, newsText,  idAuthor,  newsImage);

            return RedirectToRoute(new { area = "", controller = "Home", action = "Index" });   
        }
	}
}