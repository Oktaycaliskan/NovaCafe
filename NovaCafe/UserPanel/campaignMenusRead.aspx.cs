using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.UserPanel
{
    public partial class campaignMenusRead : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["pmid"]);
                Promotional_Menus pm = dm.GetPromotional_Menus(id);
                ltrl_ProductName.Text = pm.Name;
                ltrl_price.Text = pm.Price.ToString();
                ltrl_content.Text = pm.Content;
                ltrl_imgpm.Text = "<img class=\"text-center w-100\"  src='../Images/" + pm.Photo + "'/>";

            }



        }
    }
}