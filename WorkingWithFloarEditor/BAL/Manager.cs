using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkingWithFloarEditor.DAL;
using WorkingWithFloarEditor.Model;

namespace WorkingWithFloarEditor.BAL
{
    public class Manager
    {
        Gateway gateway=new Gateway();

        public void Save(Article article)
        {
            gateway.Save(article);
        }
    }
}