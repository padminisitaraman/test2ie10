using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1e10
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request["sid"] != null && Convert.ToString(Request["sid"]) != Session.SessionID)
            {
                Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", Convert.ToString(Request["sid"])));
            }
           // Request.Headers.Add("p3p", "CP='NOI ADM DEV PSAi COM NAV OUR OTR STP IND DEM'");
            if (Request["fid"] != null && Convert.ToString(Request["fid"]).Length > 0)
            {
                HttpCookie fidcookie = new HttpCookie("fid", Convert.ToString(Request["fid"]));
                fidcookie.Secure = true;
                Response.Cookies.Add(fidcookie);
            }
            if (Request.Cookies["cook"] == null)
            {

                HttpCookie cookie = new HttpCookie("cook", "nochicken");
                cookie.Secure = true;
                Response.Cookies.Add(cookie);
                
            }
            else
            {
                HttpCookie cookie = new HttpCookie("cook", "chicken");
                cookie.Secure = true;
                Response.Cookies.Add(cookie);
                Response.Redirect("~/default.aspx");
                
            }
           
        }
    }
}
