﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        Admin admin=new Admin();

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
            admin.AdminName = "Kadoil";
            admin.AdminPassword = "Kado1234";
        }



        #region Category Methods

        public List<Categories> ListCategories()
        {
            List<Categories> category = new List<Categories>();
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Categorys";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categories c = new Categories();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Photo = reader.GetString(2);
                    c.Content = reader.GetString(3);
                    c.IsActive = reader.GetBoolean(4);
                    c.IsActiveStr = reader.GetBoolean(4) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    category.Add(c);
                }
                return category;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }

        }
        public List<Categories> ListActiveCategories()
        {
            List<Categories> category = new List<Categories>();
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Categorys WHERE IsActive=1";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categories c = new Categories();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Photo = reader.GetString(2);
                    c.Content = reader.GetString(3);
                    c.IsActive = reader.GetBoolean(4);
                    c.IsActiveStr = reader.GetBoolean(4) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    category.Add(c);
                }
                return category;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }

        }

        public Categories GetCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Categorys WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Categories c = new Categories();
                while (reader.Read())
                {

                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Photo = reader.GetString(2);
                    c.Content = reader.GetString(3);
                    c.IsActive = reader.GetBoolean(4);
                    c.IsActiveStr = reader.GetBoolean(4) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";

                }
                return c;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }
        public bool ChangeCategoryPasif(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.CATEGORYS SET IsActive=0 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }

        }
        public bool ChangeCategoryActive(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.CATEGORYS SET IsActive=1 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }

        }
        public bool AddCategory(Categories c)
        {
            try
            {
                cmd.CommandText = "INSERT INTO NovaCafe.Categorys(Name, Img, Content, IsActive) Values(@name, @img, @content, @isactive)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@img", c.Photo);
                cmd.Parameters.AddWithValue("@content", c.Content);
                cmd.Parameters.AddWithValue("@isactive", c.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool EditCategory(Categories c)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Categorys SET Name=@name, Img=@img, Content=@content, IsActive=@isactive WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", c.ID);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@img", c.Photo);
                cmd.Parameters.AddWithValue("@content", c.Content);
                cmd.Parameters.AddWithValue("@isactive", c.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Promotional Menu Methods

        public List<Promotional_Menus> ListPromotional_Menus()
        {
            List<Promotional_Menus> menu = new List<Promotional_Menus>();
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Promotional_Menus";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Promotional_Menus m = new Promotional_Menus();
                    m.ID = reader.GetInt32(0);
                    m.Name = reader.GetString(1);
                    m.Photo = reader.GetString(2);
                    m.Content = reader.GetString(3);
                    m.Price = reader.GetDecimal(4);
                    m.IsActive = reader.GetBoolean(5);
                    m.IsActiveStr = reader.GetBoolean(5) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    menu.Add(m);
                }
                return menu;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }

        }
        public List<Promotional_Menus> ListActivePromotional_Menus()
        {
            List<Promotional_Menus> menu = new List<Promotional_Menus>();
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Promotional_Menus WHERE IsActive=1";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Promotional_Menus m = new Promotional_Menus();
                    m.ID = reader.GetInt32(0);
                    m.Name = reader.GetString(1);
                    m.Photo = reader.GetString(2);
                    m.Content = reader.GetString(3);
                    m.Price = reader.GetDecimal(4);
                    m.IsActive = reader.GetBoolean(5);
                    m.IsActiveStr = reader.GetBoolean(5) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    menu.Add(m);
                }
                return menu;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }

        }
        public Promotional_Menus GetPromotional_Menus(int id)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM NovaCafe.Promotional_Menus WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Promotional_Menus m = new Promotional_Menus();
                while (reader.Read())
                {

                    m.ID = reader.GetInt32(0);
                    m.Name = reader.GetString(1);
                    m.Photo = reader.GetString(2);
                    m.Content = reader.GetString(3);
                    m.Price = reader.GetDecimal(4);
                    m.IsActive = reader.GetBoolean(5);
                    m.IsActiveStr = reader.GetBoolean(5) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";

                }
                return m;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }
        public bool ChangePromational_MenusPasif(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Promotional_Menus SET IsActive=0 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool ChangePromational_MenusActive(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Promotional_Menus SET IsActive=1 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }

        public bool AddPromotional_Menus(Promotional_Menus pm)
        {
            try
            {
                cmd.CommandText = "INSERT INTO NovaCafe.Promotional_Menus(Name,Img,Content,Price,IsActive) Values(@name, @img, @content, @price, @isactive)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", pm.Name);
                cmd.Parameters.AddWithValue("@img", pm.Photo);
                cmd.Parameters.AddWithValue("@content", pm.Content);
                cmd.Parameters.AddWithValue("@price", pm.Price);
                cmd.Parameters.AddWithValue("@isactive", pm.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool EditPromotional_Menu(Promotional_Menus pm)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Promotional_Menus SET Name=@name, Img=@img, Content=@content, Price=@price, IsActive=@isactive WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", pm.ID);
                cmd.Parameters.AddWithValue("@name", pm.Name);
                cmd.Parameters.AddWithValue("@img", pm.Photo);
                cmd.Parameters.AddWithValue("@content", pm.Content);
                cmd.Parameters.AddWithValue("@price", pm.Price);
                cmd.Parameters.AddWithValue("@isactive", pm.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Product Method
        public List<Products> ListProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                cmd.CommandText = "SELECT P.ID, P.Name, P.Img, P.Category_ID, C.Name, P.Content, P.Price, P.IsActive FROM NovaCafe.Products AS P JOIN NovaCafe.Categorys AS C ON P.Category_ID = C.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products p = new Products();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Photo = reader.GetString(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.Category = reader.GetString(4);
                    p.Content = reader.GetString(5);
                    p.Price = reader.GetDecimal(6);
                    p.IsActive = reader.GetBoolean(7);
                    p.IsActiveStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    products.Add(p);

                }
                return products;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }
        public List<Products> ListActiveProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                cmd.CommandText = "SELECT P.ID, P.Name, P.Img, P.Category_ID, C.Name, P.Content, P.Price, P.IsActive FROM NovaCafe.Products AS P JOIN NovaCafe.Categorys AS C ON P.Category_ID = C.ID WHERE P.IsActive = 1";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products p = new Products();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Photo = reader.GetString(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.Category = reader.GetString(4);
                    p.Content = reader.GetString(5);
                    p.Price = reader.GetDecimal(6);
                    p.IsActive = reader.GetBoolean(7);
                    p.IsActiveStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    products.Add(p);

                }
                return products;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }
        public List<Products> ListActiveProducts(int cid)
        {
            List<Products> products = new List<Products>();
            try
            {
                cmd.CommandText = "SELECT P.ID, P.Name, P.Img, P.Category_ID, C.Name, P.Content, P.Price, P.IsActive FROM NovaCafe.Products AS P JOIN NovaCafe.Categorys AS C ON P.Category_ID = C.ID WHERE P.IsActive = 1 AND P.Category_ID=@cid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cid", cid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products p = new Products();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Photo = reader.GetString(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.Category = reader.GetString(4);
                    p.Content = reader.GetString(5);
                    p.Price = reader.GetDecimal(6);
                    p.IsActive = reader.GetBoolean(7);
                    p.IsActiveStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    products.Add(p);

                }
                return products;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }
        public List<Products> GetProductCid(int cid)
        {
            List<Products> productList = new List<Products>(); //
            try
            {
                cmd.CommandText = "SELECT P.ID, P.Name, P.Img, P.Category_ID, C.Name AS CategoryName, P.Content, P.Price, P.IsActive FROM NovaCafe.Products AS P JOIN NovaCafe.Categorys AS C ON P.Category_ID = C.ID WHERE P.Category_ID = @cid;";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cid", cid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Products p = new Products(); // Yeni ürün nesnesi oluştur
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Photo = reader.GetString(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.Category = reader.GetString(4);
                    p.Content = reader.GetString(5);
                    p.Price = reader.GetDecimal(6);
                    p.IsActive = reader.GetBoolean(7);
                    p.IsActiveStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";

                    productList.Add(p);
                }
                return productList;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Products GetProduct(int id)
        {
            try
            {

                cmd.CommandText = "SELECT P.ID, P.Name, P.Img, P.Category_ID, C.Name, P.Content, P.Price, P.IsActive FROM NovaCafe.Products AS P JOIN NovaCafe.Categorys AS C ON P.Category_ID = C.ID WHERE P.ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Products p = new Products();
                while (reader.Read())
                {

                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Photo = reader.GetString(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.Category = reader.GetString(4);
                    p.Content = reader.GetString(5);
                    p.Price = reader.GetDecimal(6);
                    p.IsActive = reader.GetBoolean(7);
                    p.IsActiveStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";


                }
                return p;
            }
            catch
            {

                return null;
            }
            finally { con.Close(); }
        }

        public bool ChangeProductPasif(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Products SET IsActive=0 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool ChangeProductActive(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Products SET IsActive=1 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool AddProduct(Products p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO NovaCafe.Products(Name,Img,Category_ID, Content,Price,IsActive) VALUES(@name, @img, @cid, @content, @price, @isactive)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@img", p.Photo);
                cmd.Parameters.AddWithValue("@cid", p.Category_ID);
                cmd.Parameters.AddWithValue("@content", p.Content);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@isactive", p.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        public bool EditProduct(Products p)
        {
            try
            {
                cmd.CommandText = "UPDATE NovaCafe.Products SET Name=@name, Img=@img,Category_ID=@cid, Content=@content, Price=@price, IsActive=@isactive WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@img", p.Photo);
                cmd.Parameters.AddWithValue("@cid", p.Category_ID);
                cmd.Parameters.AddWithValue("@content", p.Content);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@isactive", p.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally { con.Close(); }
        }
        #endregion


        #region Collective Metods

        public bool nullControl(params string[] data)
        {
            bool control = true;
            for (int i = 0; i < data.Length; i++)
            {
                if (string.IsNullOrEmpty(data[i]))
                {
                    control = false;
                    break;
                }
            }
            return control;
        }

        public bool DataControl(string table, string data)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM " + table + " WHERE Name= @name";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", data);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally { con.Close(); }
        }
        public bool AdminControl(string adminName, string adminPassword)
        {
            if (adminName == admin.AdminName || adminPassword == admin.AdminPassword)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public Admin GetAdmin()
        {
            return admin;
        }
        #endregion
    }
}
