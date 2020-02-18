using System.Collections.Generic;
using DataAcess;
using Models;
using ViewModels;

namespace BLL
{
    public class ReviewService
    {
        /// <summary>
        /// instance of article context used to communicate to data layer
        /// </summary>
        private readonly ReviewContext reviewContext = new ReviewContext();

        /// <summary>
        /// Method to get all review
        /// </summary>
        /// <returns>list of review</returns>
        public List<ViewReview> GetAllReviews()
        {
            var reviews = reviewContext.GetAllReviews();
            var viewReviews = new List<ViewReview>();
            foreach (var rev in reviews) viewReviews.Add(new ViewReview(rev.name, rev.date, rev.content));

            return viewReviews;
        }

        /// <summary>
        /// method to add a review
        /// </summary>
        /// <param name="viewReview">review</param>
        public void AddReview(ViewReview viewReview)
        {
            var review = new Review(viewReview.name, viewReview.date, viewReview.content);
            reviewContext.AddReview(review);
        }
    }
}