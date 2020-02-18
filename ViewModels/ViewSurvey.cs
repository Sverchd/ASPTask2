using System;
using System.Collections.Generic;

namespace ViewModels
{
    public class ViewSurvey
    {
        public int SurveyId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string surname { get; set; }
        public IList<string> andVers = new List<string>();
        public string emotions { get; set; }

        public ViewSurvey()
        {
        }

        public ViewSurvey(string nm, DateTime dt, string sr, IList<string> vers, string ems)
        {
            name = nm;
            date = dt;
            surname = sr;
            andVers = vers;
            emotions = ems;
        }
    }
}