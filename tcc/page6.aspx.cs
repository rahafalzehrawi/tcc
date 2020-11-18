using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tcc
{
    public partial class page6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookieCollection cookies = Request.Cookies;
            LabelCookie.Text = "the age : " + cookies["the age"].Value;
        }
    }
}