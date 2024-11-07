using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Category Methods

        public List<Categories> ListCategories()
        {
            List<Categories> category= new List<Categories>();
            try
            {
                cmd.CommandText = "SELECT * FROM Categorys";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader= cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categories c= new Categories();
                    c.Id = reader.GetInt32(0);
                    c.Name= reader.GetString(1);
                    c.Photo=reader.GetString(2);
                    c.Content= reader.GetString(3);
                    c.IsActive=reader.GetBoolean(4);
                    c.IsActiveStr= reader.GetBoolean(4) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
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

        #endregion
    }
}
