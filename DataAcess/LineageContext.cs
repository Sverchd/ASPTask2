using System.Data.Entity;
using Models;

namespace DataAcess
{
    public class LineageContext : DbContext
    {
        /// <summary>
        /// db context
        /// </summary>
        /// <param name="nameOrConnectionString">db connection string</param>
        public LineageContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer(new LineageContextInitializer());
        }

        /// <summary>
        /// db set for articles
        /// </summary>
        public IDbSet<Article> Articles { get; set; }
        /// <summary>
        /// db set for reviews
        /// </summary>
        public IDbSet<Review> Reviews { get; set; }
        /// <summary>
        /// db set for surveys
        /// </summary>
        public IDbSet<Survey> Surveys { get; set; }
    }
}