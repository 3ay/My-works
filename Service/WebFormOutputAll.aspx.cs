using Pattern.localhost;
using Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pattern
{
    public partial class WebFormOutputAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebService web = new localhost.WebService();
         var Saver =   web.Items_get();
            int index = 0;
            foreach (var i in Saver)
            {
                Output.Text += ++index+". "+i.Name_note +": "+ i.Description_note+"\r\n";
                
            }
            
        }
    }
}