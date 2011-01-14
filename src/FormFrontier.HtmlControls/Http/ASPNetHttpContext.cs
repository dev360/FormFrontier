using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using System.Collections.Specialized;

namespace FormFrontier.HtmlControls.Http
{
    public class ASPNetHttpContext : IHttpContext
    {
        public HttpCookieCollection Cookies
        {
            get 
            {
                return HttpContext.Current.Request.Cookies;
            }
        }

        public NameValueCollection Form
        {
            get 
            {
                return HttpContext.Current.Request.Form;
            }
        }

        public string HtmlEncode(string html)
        {
            return HttpUtility.HtmlEncode(html);
        }

        public string HtmlDecode(string html)
        {
            return HttpUtility.HtmlDecode(html);
        }
    }
}
