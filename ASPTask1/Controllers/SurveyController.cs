using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BLL;
using ViewModels;

namespace ASPTask1.Controllers
{
    public class SurveyController : Controller
    {
        /// <summary>
        /// instance of survey Service
        /// </summary>
        private readonly SurveyService surveyService = new SurveyService();
        /// <summary>
        /// Action that handles both get and post requests to survey page
        /// </summary>
        /// <param name="form">collection of form properties</param>
        /// <param name="versions">list of values of selected checkboxes (version of android os)</param>
        /// <param name="emotions">selected emotion about the rom</param>
        /// <returns>view of survey page</returns>
        public ActionResult Survey(FormCollection form, List<string> versions, string emotions)
        {
            if (HttpContext.Request.HttpMethod == "GET")
            {
                ViewBag.Message = "Your contact page.";
                return View(new List<IList<string>>
                {
                    new List<string> {"2.3", "4.0", "4.2", "5.0", "6.0", "8.1", "10"},
                    new List<string> {"love", "don`t like", "hate"}
                });
            }

            if (HttpContext.Request.HttpMethod == "POST")
            {
                var surv = new ViewSurvey(form["Name"], DateTime.Now, form["SurName"], versions, emotions);
                surveyService.AddSurvey(surv);
                return View("Result", surv);
            }

            return View();
        }
    }
}