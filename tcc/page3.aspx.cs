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
    }
}