using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.AdminPanel
{
    public partial class EditCategory : System.Web.UI.Page
    {

        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count!=0)
            {
                

                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["cid"]);
                    Categories c = dm.GetCategory(id);
                    tb_name.Text = c.Name;
                    tb_content.Text = c.Content;
                    img_photo.ImageUrl = "../Images/" + c.Photo;
                    cb_isactive.Checked = c.IsActive;
                }

            }
            else
            {
                Response.Redirect("ListCategory.aspx");
            }
        }

        protected void lbtn_editCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["cid"]);
            Categories c = dm.GetCategory(id);
            c.Name= tb_name.Text;
            c.Content= tb_content.Text;
            c.IsActive= cb_isactive.Checked;
            if (fu_img.HasFile)
            {
                FileInfo fi = new FileInfo(fu_img.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                {
                    string ImgExtension = fi.Extension;
                    string ImgName = Guid.NewGuid().ToString();
                    c.Photo = ImgName + ImgExtension;
                    fu_img.SaveAs(Server.MapPath("~/Images/" + c.Photo));
                    if (dm.EditCategory(c))
                    {
                        pnl_success.Visible = true;
                        pnl_unsuccess.Visible = false;
                        tb_content.Text = tb_name.Text = img_photo.ImageUrl = "";
                        cb_isactive.Checked = false;
                    }
                }
                else
                {
                    pnl_success.Visible = false;
                    pnl_unsuccess.Visible = true;
                    lbl_unsuccess.Text = "Resim Uzantısı .jpg Ya Da .png Olmalıdır";
                }
            }
            if (dm.EditCategory(c))
            {
                pnl_success.Visible = true;
                pnl_unsuccess.Visible = false;
                tb_content.Text = tb_name.Text = img_photo.ImageUrl = "";
                cb_isactive.Checked = false;
            }
            else
            {
                pnl_success.Visible = false;
                pnl_unsuccess.Visible = true;
                lbl_unsuccess.Text = "Düzenleme Başarısız";
            }
        }
    }
}