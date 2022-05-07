using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solicitor.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString Image(this HtmlHelper helper, string src, string alt, string className)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tag.Attributes.Add("alt", alt);
            tag.Attributes.Add("class", className);
            return new MvcHtmlString(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}