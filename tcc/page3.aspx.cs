using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tcc
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnviewstate_Click(object sender, EventArgs e)
        {
            ViewState["name"] = nametextbox.Text;
            ViewState["age"] = agetextbox.Text;
            nametextbox.Text = agetextbox.Text = "";
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            nametextbox.Text = ViewState["name"].ToString();
            agetextbox.Text = ViewState["age"].ToString();
        }

        protected void btnquerystring_Click(object sender, EventArgs e)
        {
            Response.Redirect("page4.aspx?name=" + nametextbox.Text+"&age="+agetextbox.Text);
        }

        protected void btnsession_Click(object sender, EventArgs e)
        {
            Session["name"] = nametextbox.Text;
            Response.Redirect("~/page5.aspx");
            
        }

        protected void BtnCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("the age", agetextbox.Text);
            cookie.Expires = DateTime.Now.AddHours(2);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/page6.aspx");
        }

        protected void btnApplication_Click(object sender, EventArgs e)
        {
            Application["number"] = (int)Application["number"] + 1;
            Label3.Text = Application["number"].ToString();    
        }
    }
}