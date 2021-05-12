using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int ct = 30;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null)
            {
                //Server.Transfer("test.aspx");
                Response.Redirect("registered");
            }
            Login.Text = "目前線上人數:" + Application["count"];
        }

        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布";
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                computerResult.Text = "電腦出剪刀";
                computerImage.ImageUrl = "~/pic/剪刀.png";
            }
            else if (computer == 2)
            {
                computerResult.Text = "電腦出石頭";
                computerImage.ImageUrl = "~/pic/石頭.png";
            }
            else if (computer == 3)
            {
                computerResult.Text = "電腦出布";
                computerImage.ImageUrl = "~/pic/布.png";
            }


            if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
                final.Text = "玩家贏了";
            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
                final.Text = "玩家輸了";
            else
                final.Text = "平手";
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Application["count"] = Convert.ToInt32(Application["count"])-1;
            //Server.Transfer("test2.aspx");
            Response.Redirect("test");
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            ct--;
            time.Text = "剩餘時間" + ct.ToString();
            if (Application["messageResult"] != null)
            {
                chatBox.Text = Application["messageResult"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = inputText.Text;
            Application["messageResult"] = Application["messageResult"] + Session["name"].ToString() + "：" + message + "<br>";
            chatBox.Text = Application["messageResult"].ToString();
        }
    }
}