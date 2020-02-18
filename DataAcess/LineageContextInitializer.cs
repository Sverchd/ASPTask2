using System;
using System.Collections.Generic;
using System.Data.Entity;
using Models;

namespace DataAcess
{
    public class LineageContextInitializer : DropCreateDatabaseAlways<LineageContext>
    {
        /// <summary>
        /// seed for adding initial db entries
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(LineageContext context)
        {
            var articles = new List<Article>
            {
                new Article("Individuality", DateTime.Now,
                    "Customization is paramount to productivity. That’s why LineageOS promises to push for user personalization and preference. Everyone is unique and your device should be too."),
                new Article("Security", DateTime.Now,
                    "Your data, your rules. With powerful tools such as Privacy Guard, you are in control of what your apps can do whenever you want."),
                new Article("Longevity", DateTime.Now,
                    "LineageOS extends the functionality and lifespan of mobile devices from more than 20 different manufacturers thanks to our open-source community of contributors from all around the world."),
                new Article("Power to you", DateTime.Now,
                    "Our open-source apps are here to help you get through the day. Want to do more with your device? Power users will enjoy Unix command-line utilities. " +
                    "Android developers will turn any device into the perfect device for apps development thanks to enhanced tools and exclusive APIs."),
                new Article("Ready? Get LineageOS now!", DateTime.Now,
                    "LineageOS, an open-source Android distribution, is available for several devices, with more being continuously added thanks to the biggest, yet ever growing, Android open-source community. " +
                    "Join us and breathe new life in your device, be it old or new.")
            };

            var reviews = new List<Review>
            {
                new Review("Anton", DateTime.Now, "This rom is so good"),
                new Review("Starfury", DateTime.Now, "It has a lot of bugs!!!"),
                new Review("Sterben", DateTime.Now, "I liked this rom. thanks"),
                new Review("Misha", DateTime.Now, "I don`t like it, stop developing!!"),
                new Review("Mary", DateTime.Now, "This was the first time I`ve used it but I liked it")
            };

            var surveys = new List<Survey>
            {
                new Survey("Anton", DateTime.Now, "Totin", new List<string> {"2.3", "4.0", "4.2", "5.0"}, "hate")
            };

            articles.ForEach(art => context.Articles.Add(art));
            reviews.ForEach(rev => context.Reviews.Add(rev));
            surveys.ForEach(sur => context.Surveys.Add(sur));
            context.SaveChanges();
        }
    }
}