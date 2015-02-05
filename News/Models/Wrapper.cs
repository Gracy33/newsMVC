using News.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Models
{
    public class Wrapper
    {
        //List<InfoNews> _lstNews;
        InfoNews _anews;
        private Author _auteur;

        //public List<InfoNews> LstNews
        //{
        //    get { return _lstNews; }
        //    set { _lstNews = value; }
        //}

        public Author Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public InfoNews Anews
        {
            get { return _anews; }
            set { _anews = value;  }
        }
    }
}