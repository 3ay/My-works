using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pattern
{
    public partial class WebFormEditNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Find_Note_Click(object sender, EventArgs e)
        {
            localhost.WebService webService = new localhost.WebService();
            var Saver =  webService.Find_note(Find_note_field.Text);
            Name_note_field.Text = Saver.Name_note;
            Description_note_field.Text = Saver.Description_note;

        }

        

        protected void Edit_note_button_Click(object sender, EventArgs e)
        {
            localhost.WebService webService = new localhost.WebService();
            webService.Edit_note (webService.Find_note(Find_note_field.Text),Name_note_field.Text,Description_note_field.Text);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm.aspx");
        }
    }
}