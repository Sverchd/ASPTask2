using System;
using System.Web.Mvc;
using BLL;
using ViewModels;

namespace ASPTask1.Controllers
{
    public class GuestController : Controller
    {
        /// <summary>
        ///     instance of review Service
        /// </summary>
        private readonly ReviewService reviewService = new ReviewService();

        /// <summary>
        ///     Action for Get request to Guest page
        /// </summary>
        /// <returns>Guest view</returns>
        [HttpGet]
        public ActionResult Guest()
        {
            HttpContext.Request.GetType();
            ViewBag.Text = "Text";
            return View(reviewService.GetAllReviews());
        }

        /// <summary>
        /// </summary>
        /// <param name="form">collection of form properties</param>
        /// <returns>view of guest page</returns>
        [HttpPost]
        public ActionResult Guest(FormCollection form)
        {
            ViewBag.TextReturn = "Вы ввели: " + form["Text"];
            ViewBag.TextReturn = form["UserName"];
            reviewService.AddReview(new ViewReview(form["UserName"], DateTime.Now, form["ReviewText"]));
            return View(reviewService.GetAllReviews());
        }
    }
}