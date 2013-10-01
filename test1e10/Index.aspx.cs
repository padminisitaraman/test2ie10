using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1e10
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Cookies");
            Response.Write(Request.Cookies.Count);
            if (Request.Cookies.Count > 0)
                Response.Write(Request.Cookies[0].Value);
            if (Request.Cookies.Count > 1)
                Response.Write(Request.Cookies[1].Value);
            //foreach (HttpCookie cook in Request.Cookies)
            //{
            //    Response.Write("cookName" + cook.Name);
            //    Response.Write("cookName" + cook.Value);
            //}
            //foreach (HttpCookie cook in Response.Cookies)
            //{
            //    Response.Write("cookName" + cook.Name);
            //    Response.Write("cookName" + cook.Value);
            //}
            Response.End();
        }
    }
}