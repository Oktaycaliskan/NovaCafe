using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.AdminPanel
{
    public partial class ListProducts : System.Web.UI.Page
    {
        DataModel dm=new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        protected void lv_products_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id=Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "changeStatus")
            {
                Products p = dm.GetProduct(id);
                if (p.IsActive)
                {
                    dm.ChangeProductPasif(id);
                }
                else
                {
                    dm.ChangeProductActive(id);
                }
            }
            DataLoad();
        }

        public void DataLoad()
        {
            lv_products.DataSource = dm.ListProducts();
            lv_products.DataBind();
        }
    }
}