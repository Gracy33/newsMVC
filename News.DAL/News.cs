using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL
{
    public class News
    {
        #region Fields
        private int _idNews;
        private string _newsTitle;
        private string _newsText;
        private int _idAuthor;
        private DateTime _newsDate;
        private string _newsImage;
        #endregion

        #region Properties
        public int IdNews
        {
            get { return _idNews; }
            set { _idNews = value; }
        }

        public string NewsTitle
        {
            get { return _newsTitle; }
            set { _newsTitle = value; }
        }

        public string NewsText
        {
            get { return _newsText; }
            set { _newsText = value; }
        }

        public int IdAuthor
        {
            get { return _idAuthor; }
            set { _idAuthor = value; }
        }

        public DateTime NewsDate
        {
            get { return _newsDate; }
            set { _newsDate = value; }
        }

        public string NewsImage
        {
            get { return _newsImage; }
            set { _newsImage = value; }
        }
        #endregion

        public static News ChargeInfo(int id)
        {
            List<Dictionary<string, object>> oneInfo = GestionConnexion.Instance.getData("select * from NewsTab where idNews=" + id);
            News info = new News();
            info.IdNews = int.Parse(oneInfo[0]["idNews"].ToString());
            info.NewsTitle = oneInfo[0]["newsTitle"].ToString();
            info.NewsText = oneInfo[0]["newsText"].ToString();
            info.IdAuthor = int.Parse(oneInfo[0]["idAuthor"].ToString());
            info.NewsDate = DateTime.Parse(oneInfo[0]["newsDate"].ToString());
            info.NewsImage = oneInfo[0]["newsImage"].ToString();
            return info;
        }

        public static List<News> ChargeAll()
        {
            List<Dictionary<string, object>> lstInfos = GestionConnexion.Instance.getData("select * from NewsTab");
            List<News> lstInfo = new List<News>();
            foreach (Dictionary<string, object> oneInfo in lstInfos)
            {
                News info = new News();
                info.IdNews = int.Parse(oneInfo["idNews"].ToString());
                info.NewsTitle = oneInfo["newsTitle"].ToString();
                info.NewsText = oneInfo["newsText"].ToString();
                info.IdAuthor = int.Parse(oneInfo["idAuthor"].ToString());
                info.NewsDate = DateTime.Parse(oneInfo["newsDate"].ToString());
                info.NewsImage = oneInfo["newsImage"].ToString();
                lstInfo.Add(info);
            }
            return lstInfo;
        }

        /* A verifier!!!!!!! Récupération de tous les articles écris par un auteur!*/
        public static List<News> getAuthorArticles(int idAut)
        {
            List<News> retour = new List<News>();
            List<Dictionary<string, object>> articles = GestionConnexion.Instance.getData("select * from NewsTab where idAuthor =" + idAut);

            foreach (Dictionary<string, object> item in articles)
            {
                News info = new News();
                info.IdNews = int.Parse(item["idNews"].ToString());
                info.NewsTitle = item["newsTitle"].ToString();
                info.NewsText = item["newsText"].ToString();
                info.IdAuthor = int.Parse(item["idAuthor"].ToString());
                info.NewsDate = DateTime.Parse(item["newsDate"].ToString());
                info.NewsImage = item["newsImage"].ToString();
                retour.Add(info);
            }
            return retour;
        }
    }
}
