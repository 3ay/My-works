using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pattern
{
    public partial class WebFormFindNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebService web = new localhost.WebService();
            TextBox2.Text =  web.Find_note(TextBox1.Text).Name_note +"\n"+ web.Find_note(TextBox1.Text).Description_note;
        }
    }
}