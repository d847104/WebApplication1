using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _132 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                HttpPostedFile myfile = FileUpload1.PostedFile;
                Session["mtFile"] = myfile;
                Image1.ImageUrl = "Handler.ashx";
            }
            string fileName;
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType.IndexOf("Image") == -1)
                {
                    Massage.Text = "檔案型態錯誤!";
                    return;
                }
                string Extension = FileUpload1.FileName.Split('.')[FileUpload1.FileName.Split('.').Length - 1];
                fileName = String.Format("{0:yyyyMMddhhmmss}.{1}", DateTime.Now, Extension);
                FileUpload1.SaveAs(Server.MapPath(string.Format("~/image/{0}", fileName)));
            }
            else
            {
                Massage.Text = "沒有上傳檔案";
                return;
            }
        }
    }
}