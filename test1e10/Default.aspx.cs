using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1e10
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook", "chicken");
            cookie.Secure = true;
            Response.Cookies.Add(cookie);
            // Request.Headers.Add("p3p", "CP='NOI ADM DEV PSAi COM NAV OUR OTR STP IND DEM'");
            // P3P: CP="Facebook does not have a P3P policy. Learn why here: http://fb.me/p3p"
            //Response.Headers.Add("p3p", "CP='WE does not have a P3P policy. Learn why here: http://fb.me/p3p'");
            if (((Request.UserAgent.ToLower().IndexOf("safari") >= 0 && Request.UserAgent.ToLower().IndexOf("chrome") < 0) || (Request.UserAgent.ToLower().IndexOf("windows") >= 0)) && Convert.ToString(Session["refirected"]).Length <= 0)
            {
                Session["refirected"] = true;
                string indexpath = Request.Url.ToString();
                indexpath = indexpath.ToUpper().Replace("DEFAULT.ASPX", "About.aspx");
                Response.Write(string.Format("<script type=text/javascript>top.location.href='{0}?sid={1}&fid={2}'</script>", indexpath, Session.SessionID, "chicken"));
                Response.End();
                
            }
            else
            {
                Response.Write(Session["refirected"]);
                Session["refirected"] = "";
                Response.Write(Request.UserAgent);
                Response.Write("session persisted");
                Response.End();
            }
        }
    }
}
