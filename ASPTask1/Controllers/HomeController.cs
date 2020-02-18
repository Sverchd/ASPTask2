using System.Web.Mvc;
using BLL;

namespace ASPTask1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// instance of article Service
        /// </summary>
        private readonly ArticleService articleService = new ArticleService();
        /// <summary>
        /// Action for requests to home page
        /// </summary>
        /// <returns>view of home page</returns>
        public ActionResult Index()
        {
            var articles = articleService.GetAllArticles();
            return View(articles);
        }
    }
}