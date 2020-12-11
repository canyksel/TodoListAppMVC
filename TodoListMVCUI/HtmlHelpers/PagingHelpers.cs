using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using TodoListMVCUI.Models;

namespace TodoListMVCUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pagingInfo)
        {
            int totalPage = (int)Math.Ceiling((decimal)pagingInfo.TotalItems / pagingInfo.ItemsPerPage);

            var stringBuilder = new StringBuilder();
            for (int i = 1; i <= totalPage; i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("/TaskList/Index/?page={0}", i));
                tagBuilder.InnerHtml = i.ToString();
                if (pagingInfo.CurrentPage == i)
                {
                    tagBuilder.AddCssClass("selected");
                }
                stringBuilder.Append(tagBuilder);
            }

            return MvcHtmlString.Create(stringBuilder.ToString());
   
        }

        public static MvcHtmlString YesNo(this HtmlHelper htmlHelper, bool yesNo)
        {
            var text = yesNo ? "YAPILDI" : "YAPILMADI";
            return new MvcHtmlString(text);
        }


    }
}