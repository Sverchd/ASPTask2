using System.Collections.Generic;
using System.Web.Mvc;

namespace ASPTask1.Helpers
{
    public static class ulHelpers
    {
        /// <summary>
        /// helper for creating unordered lists
        /// </summary>
        /// <param name="html">html context</param>
        /// <param name="items">list of items</param>
        /// <param name="name">name of the list</param>
        /// <returns></returns>
        public static MvcHtmlString CreateUl(this HtmlHelper html, List<string> items, string name)
        {
            var ul = new TagBuilder("ul");
            ul.MergeAttribute("name", name);
            foreach (var item in items)
            {
                var option = new TagBuilder("li");
                option.MergeAttribute("value", item);
                option.SetInnerText(item);
                ul.InnerHtml += option.ToString();
            }

            return new MvcHtmlString(ul.ToString());
        }
        /// <summary>
        /// helper for creating ordered lists
        /// </summary>
        /// <param name="html">html context</param>
        /// <param name="items">list of items</param>
        /// <param name="name">name of the list</param>
        /// <returns></returns>
        public static MvcHtmlString CreateOl(this HtmlHelper html, List<string> items, string name)
        {
            var ol = new TagBuilder("ol");
            ol.MergeAttribute("name", name);
            foreach (var item in items)
            {
                var option = new TagBuilder("li");
                option.MergeAttribute("value", item);
                option.SetInnerText(item);
                ol.InnerHtml += option.ToString();
            }

            return new MvcHtmlString(ol.ToString());
        }
    }
}