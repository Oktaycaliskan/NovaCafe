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
    public partial class EditPromotionalMenus : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {


                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pmid"]);
                    Promotional_Menus pm = dm.GetPromotional_Menus(id);
                    tb_name.Text = pm.Name;
                    tb_content.Text = pm.Content;
                    img_photo.ImageUrl = "../Images/" + pm.Photo;
                    cb_isactive.Checked = pm.IsActive;
                    tb_price.Text = Convert.ToString(pm.Price);
                }

            }
            else
            {
                Response.Redirect("ListPromotionalMenus.aspx");
            }
        }

        protected void lbtn_editPromotionalMenu_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["pmid"]);
            Promotional_Menus pm = dm.GetPromotional_Menus(id);
            pm.Name = tb_name.Text.Trim();
            pm.Content = tb_content.Text.Trim();
            pm.IsActive = cb_isactive.Checked;
            pm.Price = Convert.ToDecimal(tb_price.Text.Trim());
            if (fu_img.HasFile)
            {
                FileInfo fi = new FileInfo(fu_img.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                {
                    string ImgExtension = fi.Extension;
                    string ImgName = Guid.NewGuid().ToString();
                    pm.Photo = ImgName + ImgExtension;
                    fu_img.SaveAs(Server.MapPath("~/Images/" + pm.Photo));
                    if (dm.EditPromotional_Menu(pm))
                    {
                        pnl_success.Visible = true;
                        pnl_unsuccess.Visible = false;
                        tb_content.Text = tb_name.Text = tb_price.Text = img_photo.ImageUrl = "";
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
            if (dm.EditPromotional_Menu(pm))
            {
                pnl_success.Visible = true;
                pnl_unsuccess.Visible = false;
                tb_content.Text = tb_name.Text = tb_price.Text = img_photo.ImageUrl = "";
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