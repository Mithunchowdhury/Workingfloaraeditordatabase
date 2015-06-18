using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorkingWithFloarEditor.BAL;
using WorkingWithFloarEditor.Model;

namespace WorkingWithFloarEditor
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Manager manager=new Manager();
        protected void saveButton_Click(object sender, EventArgs e)
        { 
          Article article=new Article();
            article.Descripation = Request.Form["edit"];
            manager.Save(article);
        }
    }
}