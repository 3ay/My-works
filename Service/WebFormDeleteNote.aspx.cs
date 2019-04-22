using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pattern
{
    public partial class WebFormDeleteNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebService web = new localhost.WebService();
            web.Delete_note(TextBox1.Text);
           
        }
    }
}