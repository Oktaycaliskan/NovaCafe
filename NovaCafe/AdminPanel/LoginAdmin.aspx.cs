using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.AdminPanel
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_userName.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                if (dm.AdminControl(tb_userName.Text, tb_password.Text))
                {
                    Admin a = dm.GetAdmin();
                    Session["Admin"] = a;
                    Response.Redirect("DefaultPage.aspx");
                }
                else
                {
                    pnl_mistake.Visible = true;
                    lbl_mistake.Text = "Hatalı Kullanıcı Adı Veya Şifre Girdiniz";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tb_userName.Text))
                {
                    pnl_mistake.Visible = true;
                    lbl_mistake.Text = "Kullanıcı Adı Boş Bırakılamaz";
                }
                else if (string.IsNullOrEmpty(tb_password.Text))
                {
                    pnl_mistake.Visible = true;
                    lbl_mistake.Text = "Şifre Boş Bırakılamaz";
                }

            }
        }
    }
}