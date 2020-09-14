using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayThree.Extensions.CustomHtmlHelpers
{
    public static class CustomBanner
    {

        // custom helper za banner. 
        // Za dadeni vrednosti za pateka na slika za banerot, naslov, i dimenzii (sirina x visina) , helperov vraka html string
        // koj  kreira html kod kade ke bide pretstavena slikata zaedno so naslovot so soodvetnite dimenzii
        public static IHtmlContent ImageBanner(this IHtmlHelper htmlhelper, string textBanner, string Imagesource, string altTxt, string width, string height)
        {
            var header = $"<p style =\"color:red; font-weight: bold;\" >{textBanner}</p>";
            var divStart = "<div  style = \"border: 2px solid gray; padding:10px; width: fit-content; margin - left: auto; margin - right: auto; \" >";
            var divEnd = "</div>";
            var ImageTag = new TagBuilder("img");
            //  src Specifies the path to the image
            ImageTag.MergeAttribute("src", Imagesource);
            // alt - Specifies an alternate text for the image, if the image for some reason cannot be displayed
            ImageTag.MergeAttribute("alt", altTxt);
            ImageTag.MergeAttribute("width", width);
            ImageTag.MergeAttribute("height", height);

            var content = new HtmlContentBuilder()
                  .AppendHtml(divStart)
                  .AppendHtml(header)
                  .AppendHtml(ImageTag)
                  .AppendHtml(divEnd);

            return content;
        }

    }
}
