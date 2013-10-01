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