using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tcc
{
    public partial class page4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString.Get("name");
            string age = Request.QueryString.Get("age");
            Response.Write("How are you  " + name +"\t"+ "my age"+age);
         

        }
    }
}