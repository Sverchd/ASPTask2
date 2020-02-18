using System.Collections.Generic;
using System.Linq;
using Models;

namespace DataAcess
{
    public class ReviewContext
    {
        /// <summary>
        /// Method to get all reviews from db context
        /// </summary>
        /// <returns>List of reviews</returns>
        public List<Review> GetAllReviews()
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                var datalist = lineageContext.Reviews.ToList();
                return datalist;
            }
        }

        /// <summary>
        /// Method to ad a review to db context
        /// </summary>
        /// <param name="review">review</param>
        public void AddReview(Review review)
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                lineageContext.Reviews.Add(review);
                lineageContext.SaveChanges();
            }
        }
    }
}