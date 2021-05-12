using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["name"]!= null)
            {
                //創一個變數存放從config內的資訊，其實也可不用創立這變數，直接放進SqlConnection內即可。
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountsConnectionString"].ConnectionString;

                //new一個SqlConnection物件，是與資料庫連結的通道(其名為Connection)，以s_data內的連接字串連接所對應的資料庫。
                SqlConnection connection = new SqlConnection(s_data);

                string sqlTest = "select * from accountInfo where users=" +"'"+ Request.Form["user"]+"'";

                //new一個SqlCommand告訴這個物件準備要執行什麼SQL指令
                SqlCommand Command = new SqlCommand(sqlTest, connection);

                //與資料庫連接的通道開啟
                connection.Open();

                //new一個DataReader接取Execute所回傳的資料。
                SqlDataReader Reader = Command.ExecuteReader();

                //檢查是否有資料列
                if (Reader.HasRows)
                {
                    //使用Read方法把資料讀進Reader，讓Reader一筆一筆順向指向資料列，並回傳是否成功。
                    if (Reader.Read())
                    {
                        string zxc = Reader["passwd"].ToString();
                        string asd = Request.Form["passwd"];
                        if (Reader["passwd"].ToString() == Request.Form["passwd"])
                        {
                            Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                            Session["logined"] = "1";
                            Session["name"] = Request.Form["name"];
                            Server.Transfer("test2.aspx");
                        }
                        else
                        {
                            Label1.Text = "密碼錯誤";
                        }
                        
                        //DataReader讀出欄位內資料的方式，通常也可寫Reader[0]、[1]...[N]代表第一個欄位到N個欄位。
                    }
                }
                else
                {
                    Label1.Text = "無此帳號";
                }
            }
            /*
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                //Response.Redirect("test2");
                Server.Transfer("test2.aspx");
            }
            else
            {
                if (Request.Form["TextBox1"] != null && Request.Form["passwd2"] != null)
                {
                    if (Request.Form["TextBox1"] == "d847104" && Request.Form["passwd2"] == "19960927")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["logined"] = "1";
                        Session["name"] = Request.Form["name"];
                        //Response.Redirect("test2");
                        Server.Transfer("test2.aspx");
                    }
                }
                else
                {
                    Response.Write("error");
                }
            }
            */
        }
    }
}