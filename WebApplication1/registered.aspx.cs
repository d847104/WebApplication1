using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["user"] != null && Request.Form["passwd"] != null && Request.Form["name"] != null)
            {
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountsConnectionString"].ConnectionString;

                SqlConnection connection = new SqlConnection(s_data);

                //string sql = $"insert into [dbo].[accountInfo](users,passwd,name) values('" + Request.Form["user"] + "','" + Request.Form["passwd"] + "','" + Request.Form["name"] + "')";
                string sql = $"insert into [dbo].[accountInfo](users,passwd,name) values(@users,@passwd,@name)";

                connection.Open();

                SqlCommand Command = new SqlCommand(sql, connection);
                Command.Parameters.Add("@users",SqlDbType.NVarChar);
                Command.Parameters["@users"].Value = Request.Form["user"];

                Command.Parameters.Add("@passwd", SqlDbType.NVarChar);
                Command.Parameters["@passwd"].Value = Request.Form["passwd"];

                Command.Parameters.Add("@name", SqlDbType.NVarChar);
                Command.Parameters["@name"].Value = Request.Form["name"];

                Command.ExecuteNonQuery();

                connection.Close();
            }
            else
            {
                Response.Write("error");
            }

        }
    }
}