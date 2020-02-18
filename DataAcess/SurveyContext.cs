using System.Collections.Generic;
using System.Linq;
using Models;

namespace DataAcess
{
    public class SurveyContext
    {
        /// <summary>
        /// Method to get all surveys from db context
        /// </summary>
        /// <returns>list of surveys</returns>
        public List<Survey> GetAllSurveys()
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                var datalist = lineageContext.Surveys.ToList();
                return datalist;
            }
        }
        /// <summary>
        /// Method to ad a survey to db context
        /// </summary>
        /// <param name="survey">survey</param>
        public void AddSurvey(Survey survey)
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                lineageContext.Surveys.Add(survey);
                lineageContext.SaveChanges();
            }
        }
    }
}