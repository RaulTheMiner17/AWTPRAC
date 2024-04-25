using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbDemo
{
    public partial class EmpRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into Employee(name,department,city,salary) values (@name,@department,@city,@salary)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", tbname.Text);
                cmd.Parameters.AddWithValue("@department", tbdep.Text);
                cmd.Parameters.AddWithValue("@city", tbcity.Text);
                cmd.Parameters.AddWithValue("@salary", tbsal.Text);
                cmd.ExecuteNonQuery();

                Response.Write("User registeration done Successfully!!!thank you");

                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}