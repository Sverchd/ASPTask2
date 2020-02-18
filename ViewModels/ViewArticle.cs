using System;

namespace ViewModels
{
    public class ViewArticle
    {
        public int ArticleId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }

        public ViewArticle()
        {
        }

        public ViewArticle(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }
    }
}