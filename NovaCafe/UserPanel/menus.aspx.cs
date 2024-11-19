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
            if (!IsPostBack)
            {
                string midValue = Request.QueryString["mid"];
                if (!string.IsNullOrEmpty(midValue) && int.TryParse(midValue, out int id))
                {
                    List<Products> productsList = dm.GetProductCid(id);

                    if (productsList != null && productsList.Count > 0)
                    {
                        rptProducts.DataSource = productsList;
                        rptProducts.DataBind();
                    }
                    else
                    {
                        rptProducts.Visible = false;
                    }
            }
        }






        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        if (Request.QueryString.Count != 0)
        //        {
        //            int id = Convert.ToInt32(Request.QueryString["mid"]);
        //            List<Products> productsList = dm.GetProductCid(id);

        //            if (productsList != null && productsList.Count > 0)
        //            {
        //                rptProducts.DataSource = productsList; 
        //                rptProducts.DataBind();                 
        //            }
        //            else
        //            {
        //                rptProducts.Visible = false; 
        //            }
        //        }
        //    }
        //}



    }
}