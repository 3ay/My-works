using Pattern.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Pattern
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
         public static List<Item> Items = new List<Item>();
      //  public static Item[] Items = new Item[100];
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public List<Item> Add_note(string name, string description)
        {
            Items.Add(new Item { Name_note = name, Description_note = description });
            return Items;
        }
        [WebMethod]
        public List<Item> Items_get() 
        {
            return Items;
        }
        [WebMethod]
        public Item  Find_note(string name)
        {
            foreach (var i in Items)
            {
                if (i.Name_note == name)
                {
                    return i;
                }
                
                   
            }
            return new Item();

        }
        [WebMethod]
        public Item Edit_note (Item item, string name, string description)
        {
            Item temp = Find_note(item.Name_note);
            temp.Name_note = name;
            temp.Description_note = description;
            return temp;
        }
        [WebMethod]
        public void Delete_note (string name)
        {
            Item temp = Find_note(name);
            Items.Remove(temp);

        }
        
    }
}
