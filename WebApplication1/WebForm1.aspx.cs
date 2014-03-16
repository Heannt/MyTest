using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from testtable";
        MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=1;database=test"); 
        MySqlCommand myCommand=new MySqlCommand(query,myConnection);
        myConnection.Open();
        myCommand.ExecuteNonQuery();
        MySqlDataReader myDataReader = myCommand.ExecuteReader();
        string bookres="";
        while (myDataReader.Read()==true)
        {
            bookres+=myDataReader["id"];
            bookres+=myDataReader["user"];
            bookres += myDataReader["pass"];
        }
        myDataReader.Close();
        myConnection.Close();
        lb1.Text = bookres;
        }
    }
}