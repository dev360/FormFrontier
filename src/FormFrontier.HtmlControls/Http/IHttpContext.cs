using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace FormFrontier.HtmlControls.Http
{
    public interface IHttpContext
    {
        HttpCookieCollection Cookies { get; }
        NameValueCollection Form { get; }

        string HtmlEncode(string html);
        string HtmlDecode(string html);


    }
}
