using System.Collections.Generic;
using DataAcess;
using Models;
using ViewModels;

namespace BLL
{
    public class ArticleService
    {
        /// <summary>
        /// instance of article context used to communicate to data layer
        /// </summary>
        private readonly ArticleContext articleContext = new ArticleContext();

        /// <summary>
        /// Method to get all articles
        /// </summary>
        /// <returns>list of articles</returns>
        public List<ViewArticle> GetAllArticles()
        {
            var articles = articleContext.GetAllArticles();
            var viewArticles = new List<ViewArticle>();
            foreach (var art in articles) viewArticles.Add(new ViewArticle(art.name, art.date, art.content));

            return viewArticles;
        }

        /// <summary>
        /// method to add an article
        /// </summary>
        /// <param name="viewArticle">article</param>
        public void AddArticle(ViewArticle viewArticle)
        {
            var article = new Article(viewArticle.name, viewArticle.date, viewArticle.content);
            articleContext.AddArticle(article);
        }
    }
}