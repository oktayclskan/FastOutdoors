using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.desktopComputer);
            cmd = con.CreateCommand();
        }
        #region Admin Metots
        public Admin AdminLogin(string mail,string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Admins WHERE Mail=@mail AND Sifre=@sifre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail",mail);
                cmd.Parameters.AddWithValue("@sifre",sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi > 0)
                {
                    cmd.CommandText = "SELECT * FROM Admins WHERE Mail=@mail AND Sifre=@sifre";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Admin a = new Admin();
                    while (reader.Read())
                    {
                        a.ID = reader.GetInt32(0);
                        a.Name = reader.GetString(1);
                        a.SurName = reader.GetString(2);
                        a.UserName = reader.GetString(3);
                        a.Phone = reader.GetString(4);
                        a.Mail = reader.GetString(5);
                        a.Sifre = reader.GetString(6);
                    }
                    return a;

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion
    }
}
