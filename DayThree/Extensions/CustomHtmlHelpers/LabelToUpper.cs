using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayThree.Extensions.CustomHtmlHelpers
{
    public static class HtmlHelpers
    {
        public static IHtmlContent LabelToUpper(this IHtmlHelper htmlHelper, string text)
        {
            var content = new HtmlContentBuilder()
                 .AppendHtml($"<label>{text.ToUpper()}</label>");

            return content;
        }


    }
}
