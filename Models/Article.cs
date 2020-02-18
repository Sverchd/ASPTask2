using System;

namespace Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }
        /// <summary>
        /// empty constructor
        /// </summary>
        public Article()
        {
        }
        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="ct">content</param>
        public Article(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }
    }
}