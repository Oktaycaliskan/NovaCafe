using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.AdminPanel
{
    public partial class ListCategory : System.Web.UI.Page
    {

        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
                DataLoad();
        }



        protected void lv_categories_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "changeStatus")
            {
                Categories c = dm.GetCategory(id);
                if (c.IsActive)
                {
                    dm.ChangeCategoryPasif(id);
                }
                else
                {
                    dm.ChangeCategoryActive(id);
                }

            }
            DataLoad();
        }


        public void DataLoad()
        {
            lv_categories.DataSource = dm.ListCategories();
            lv_categories.DataBind();
        }
    }
}