using System;

namespace Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }

        /// <summary>
        /// empty constructor
        /// </summary>
        public Review()
        {
        }
        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="ct">content</param>
        public Review(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }
    }
}