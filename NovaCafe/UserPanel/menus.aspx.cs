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
    public partial class menus : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["mid"]);
                Products p = dm.GetProduct(id);
                ltrl_ID.Text = p.ID.ToString();
                ltrl_KahvaltiName.Text = p.Name;
                ltrl_price.Text=p.Price.ToString();
                ltrl_img.Text = "<img src='../Images/" + p.Photo + "'/>";


            }
        }


        
    }
}