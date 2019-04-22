using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pattern
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click (object sender, EventArgs e)
        {
            localhost.WebService webService = new localhost.WebService();
            Response.Redirect("~/WebFormEditNote.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebService webService = new localhost.WebService();
            ///Label.Text = "testing";
           Response.Redirect("~/WebFormAddNote.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormOutputAll.aspx");
        }

        protected void Delete_note_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormDeleteNote.aspx");
        }

        protected void Finf_note_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormFindNote.aspx");
        }
    }
}