using System.Collections.Generic;
using System.Linq;
using Models;

namespace DataAcess
{
    public class ArticleContext
    {
        /// <summary>
        /// Method to get all article from db context
        /// </summary>
        /// <returns>list of articles</returns>
        public List<Article> GetAllArticles()
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                var datalist = lineageContext.Articles.ToList();
                return datalist;
            }
        }
        /// <summary>
        /// Method to add an article to the db context
        /// </summary>
        /// <param name="article">article</param>
        public void AddArticle(Article article)
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                lineageContext.Articles.Add(article);
                lineageContext.SaveChanges();
            }
        }
    }
}