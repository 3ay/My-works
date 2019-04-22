using Pattern.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Pattern
{
    public partial class WebFormAddNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Add_note_Click(object sender, EventArgs e)
        {

            localhost.WebService webService = new localhost.WebService();
           
            string note_name = Note_name.Text;
            string desc_name = Note_description.Text;
            
          // Item.save_Item = webService.Add_note(note_name, desc_name);
          var Saver =  webService.Add_note(note_name, desc_name);
           //using (StreamWriter sw = new StreamWriter("data.txt", true, System.Text.Encoding.Default))
           // {
          //      sw.WriteLine(Saver.);
         //   }
           
           
           
            string value = "<ul>";
           foreach(var i in Saver)
            {
                value += "<li>"+i.Name_note + "<br><br>"+i.Description_note +"</li>";

            }
            Status.Text = value+"</ul>";
           
           // Response.Redirect("~/WebForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm.aspx");
        }
    }
}