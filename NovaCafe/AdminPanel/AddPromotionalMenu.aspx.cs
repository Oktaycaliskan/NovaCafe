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
    public partial class AddPromotionalMenu : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_addPromotionalMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (dm.DataControl("Promotional_Menus", tb_name.Text.Trim()))
                {
                    Promotional_Menus pm = new Promotional_Menus();
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
                            if (dm.AddPromotional_Menus(pm))
                            {
                                pnl_success.Visible = true;
                                pnl_unsuccess.Visible = false;
                                tb_content.Text = tb_name.Text = tb_price.Text = "";
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
                    else
                    {
                        pm.Photo = "none.png";
                        if (dm.AddPromotional_Menus(pm))
                        {
                            pnl_success.Visible = true;
                            pnl_unsuccess.Visible = false;
                            tb_content.Text = tb_name.Text = "";
                            cb_isactive.Checked = false;
                        }
                        else
                        {
                            pnl_success.Visible = false;
                            pnl_unsuccess.Visible = true;
                            lbl_unsuccess.Text = "Kampanya Eklenemedi";
                        }
                    }
                }
                else
                {
                    pnl_success.Visible = false;
                    pnl_unsuccess.Visible = true;
                    lbl_unsuccess.Text = "Kampanya Daha Önce Eklenmiş";
                }
            }
            else
            {
                pnl_success.Visible = false;
                pnl_unsuccess.Visible = true;
                lbl_unsuccess.Text = "Kampanya Adı Boş";
            }
        }
    }






}