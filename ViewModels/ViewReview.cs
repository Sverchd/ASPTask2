using System;

namespace ViewModels
{
    public class ViewReview
    {
        public int ReviewId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }

        public ViewReview()
        {
        }

        public ViewReview(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }
    }
}