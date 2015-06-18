using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WorkingWithFloarEditor.Model;

namespace WorkingWithFloarEditor.DAL
{
    public class Gateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["countryDB"].ConnectionString;

        public void Save(Article article)
        {
            string query = "INSERT INTO tbl_article VALUES('"+article.Descripation+"')";
          
            SqlConnection connection=new SqlConnection(connectionString);
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        } 
    }
}