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
    public partial class AddCategory : System.Web.UI.Page
    {
        DataModel dm=new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_addCategory_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (dm.DataControl("Categorys",tb_name.Text.Trim()))
                {
                    Categories c= new Categories();
                    c.Name= tb_name.Text.Trim();
                    c.Content=tb_content.Text.Trim();
                    c.IsActive= cb_isactive.Checked;
                    if (fu_img.HasFile)
                    {
                        FileInfo fi = new FileInfo(fu_img.FileName);
                        if (fi.Extension == ".jpg" || fi.Extension == ".png")
                        {
                            string ImgExtension=fi.Extension;
                            string ImgName=Guid.NewGuid().ToString();
                            c.Photo=ImgName+ImgExtension;
                            fu_img.SaveAs(Server.MapPath("~/Images/" + c.Photo));
                            if (dm.AddCategory(c))
                            {
                                pnl_success.Visible = true;
                                pnl_unsuccess.Visible = false;
                                tb_content.Text = tb_name.Text = "";
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
                        c.Photo = "none.png";
                        if (dm.AddCategory(c))
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
                            lbl_unsuccess.Text = "Kategori Eklenemedi";
                        }
                    }
                }
                else
                {
                    pnl_success.Visible = false;
                    pnl_unsuccess.Visible = true;
                    lbl_unsuccess.Text = "Kategori Daha Önce Eklenmiş";
                }
            }
            else
            {
                pnl_success.Visible = false;
                pnl_unsuccess.Visible = true;
                lbl_unsuccess.Text = "Kategori Adı Boş";
            }
        }
    }
}