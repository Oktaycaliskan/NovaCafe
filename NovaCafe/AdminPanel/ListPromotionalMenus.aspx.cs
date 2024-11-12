using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.AdminPanel
{
    public partial class ListPromotionalMenus : System.Web.UI.Page
    {
        DataModel dm=new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        protected void lv_promotionalMenu_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "changeStatus")
            {
                Promotional_Menus p = dm.GetPromotional_Menus(id);
                if (p.IsActive)
                {
                    dm.ChangePromational_MenusPasif(id);
                }
                else
                {
                    dm.ChangePromational_MenusActive(id);
                }

            }
            DataLoad();
        }

        public void DataLoad()
        {
            lv_promotionalMenu.DataSource = dm.ListPromotional_Menus();
            lv_promotionalMenu.DataBind();
        }
    }
}