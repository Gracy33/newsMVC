using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL
{
    public class Author
    {
        #region Fields
        private int _idAuthor;
        private string _authorName;
        private string _authorFirstName;
        private string _authorPicture;
        public List<InfoNews> _autNews;
        #endregion

        #region Properties
        public int IdAuthor
        {
            get { return _idAuthor; }
            set { _idAuthor = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string AuthorFirstName
        {
            get { return _authorFirstName; }
            set { _authorFirstName = value; }
        }

        public string AuthorPicture
        {
            get { return _authorPicture; }
            set { _authorPicture = value; }
        }

        public List<InfoNews> AutNews
        {
            get
            {
                if (_autNews == null) _autNews = ChargeNews();
                return _autNews;
            }
        }
        #endregion

        private static Author Associe(Dictionary<string, object> item){
             Author aut = new Author()
            {
                IdAuthor = int.Parse(item["idAuthor"].ToString()),
                AuthorName = item["authorName"].ToString(),
                AuthorFirstName = item["authorFirstName"].ToString(),
                AuthorPicture = item["authorPicture"].ToString()
            };
            return aut;
        }

        private List<InfoNews> ChargeNews()
        {
            return InfoNews.getAuthorArticles(this.IdAuthor);
        }

        public static Author ChargeAuthor(int id)
        {
            List<Dictionary<string, object>> anAuthor = GestionConnexion.Instance.getData("select * from Author where idAuthor=" + id);
            return Associe(anAuthor[0]);
        }

        public static List<Author> ChargeAllAuthors()
        {
            List<Dictionary<string, object>> lstAuthors = GestionConnexion.Instance.getData("select * from Author");
            List<Author> lstAuthor = new List<Author>();
            foreach (Dictionary<string, object> item in lstAuthors)
            {
                lstAuthor.Add(Associe(item));
            }
            return lstAuthor;
        }
    }
}
