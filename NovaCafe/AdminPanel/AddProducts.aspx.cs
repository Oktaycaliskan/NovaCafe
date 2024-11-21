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
    public partial class AddProducts : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_categories.DataTextField = "Name";
            ddl_categories.DataValueField = "ID";
            ddl_categories.DataSource = dm.ListActiveCategories();
            ddl_categories.DataBind();

        }

        protected void lbtn_addPromotionalMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (dm.DataControl("Products", tb_name.Text.Trim()))
                {
                    Products p = new Products();
                    p.Category_ID = Convert.ToInt32(ddl_categories.SelectedItem.Value);
                    p.Name = tb_name.Text;
                    p.Content = tb_content.Text;
                    p.Price = Convert.ToDecimal(tb_price.Text);
                    p.IsActive = cb_isactive.Checked;
                    if (fu_img.HasFile)
                    {
                        FileInfo fi = new FileInfo(fu_img.FileName);
                        if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                        {
                            string ImgExtension = fi.Extension;
                            string ImgName = Guid.NewGuid().ToString();
                            p.Photo = ImgName + ImgExtension;
                            fu_img.SaveAs(Server.MapPath("~/Images/" + p.Photo));
                            if (dm.AddProduct(p))
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
                        p.Photo = "none.png";
                        if (dm.AddProduct(p))
                        {
                            pnl_success.Visible = true;
                            pnl_unsuccess.Visible = false;
                            tb_content.Text = tb_name.Text = "";
                            cb_isactive.Checked = false;
                        }
                    }

                }
                else
                {
                    pnl_success.Visible = false;
                    pnl_unsuccess.Visible = true;
                    lbl_unsuccess.Text = "Ürün Daha Önce Eklenmiş";
                }
            }
            else
            {
                pnl_success.Visible = false;
                pnl_unsuccess.Visible = true;
                lbl_unsuccess.Text = "Ürün Adı Boş";
            }
        }
    }
}