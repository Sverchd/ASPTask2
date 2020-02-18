using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string surname { get; set; }
        public IList<string> andVers = new List<string>();

        /// <summary>
        /// property that help to store list of strings inside db
        /// </summary>
        public string andVersAsString
        {
            get => string.Join(" ", andVers);
            set => andVers = value.Split(' ').ToList();
        }

        public string emotions { get; set; }

        /// <summary>
        /// empty constructor
        /// </summary>
        public Survey()
        {
        }

        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="sr">surname</param>
        /// <param name="vers">selected versions</param>
        /// <param name="ems">emotions</param>
        public Survey(string nm, DateTime dt, string sr, IList<string> vers, string ems)
        {
            name = nm;
            date = dt;
            surname = sr;
            andVers = vers;
            emotions = ems;
        }
    }
}