using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : System.Web.UI.Page,IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.Form["name"].ToString() == "123")
            {
                context.Response.Redirect("About");
            }
            else
            {
                context.Response.Redirect("http://google.com.tw");
            }
            //context.Response.Write("Hello World");
            //context.Response.Write("");
            //context.Response.Write(context.Session["name"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}