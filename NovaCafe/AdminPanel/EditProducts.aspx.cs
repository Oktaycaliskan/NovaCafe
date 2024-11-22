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
    public partial class EditProducts : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pid"]);
                    ddl_categories.DataTextField = "Name";
                    ddl_categories.DataValueField = "ID";
                    ddl_categories.DataSource = dm.ListActiveCategories();
                    ddl_categories.DataBind();
                    Products p = dm.GetProduct(id);
                    ddl_categories.SelectedValue = p.Category_ID.ToString();
                    tb_name.Text = p.Name;
                    tb_content.Text = p.Content;
                    tb_price.Text = p.Price.ToString();
                    img_photo.ImageUrl = "../Images/" + p.Photo;
                    cb_isactive.Checked = p.IsActive;
                }
            }
            else
            {
                Response.Redirect("ListProducts.aspx");
            }
        }

        protected void lbtn_editPromotionalMenu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["pid"]);
            Products p = dm.GetProduct(id);
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
                    if (dm.EditProduct(p))
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
            if (dm.EditProduct(p))
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