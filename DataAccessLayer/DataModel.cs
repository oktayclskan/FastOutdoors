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
                        a.AdminPassword = reader.GetString(6);
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
        #region Member Metots
        public List<Member> MemberList()
        {
            List<Member> members = new List<Member>();
            try
            {
                cmd.CommandText = "Select * From Members";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Member m = new Member();
                    m.ID = reader.GetInt32(0);
                    m.Name = reader.GetString(1);
                    m.SurName = reader.GetString(2);
                    m.UserName = reader.GetString(3);
                    m.Phone = reader.GetString(4);
                    m.Mail = reader.GetString(5);
                    m.MemberPassword = reader.GetString(6);
                    m.Location = reader.GetString(7);
                    m.MemberStatus = reader.GetBoolean(8);
                    m.MemberStatusStr = reader.GetBoolean(8) ? "<label style='color:green'>Aktif</label>" : "<label style='color:red'>Banlanmış</label>";
                    members.Add(m);
                }
                return members;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void MemberBan(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Members Set MemberStatus=0 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        public void MemberUnBan(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Members SET MemberStatus = 1 WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        public bool MemberAdd(Member mem)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Members (Name,SurName,UserName,Phone,Mail,MemberPassword,Location,MemberStatus) VALUES(@name,@surName,@userName,@phone,@mail,@memberPassword,@location,@memberStatus)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name",mem.Name);
                cmd.Parameters.AddWithValue("@surName", mem.SurName);
                cmd.Parameters.AddWithValue("@userName,", mem.UserName);
                cmd.Parameters.AddWithValue("@phone,", mem.Phone);
                cmd.Parameters.AddWithValue("@mail,", mem.Mail);
                cmd.Parameters.AddWithValue("@memberPassword,", mem.MemberPassword);
                cmd.Parameters.AddWithValue("@location,", mem.Location);
                cmd.Parameters.AddWithValue("@memberStatus,", mem.MemberStatus);
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
        public void MemberDelete(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Members Where ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally { con.Close(); }
        }
        #endregion
        #region AdminMetots
        public bool AdminAdd(Admin adm)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Admins((Name,SurName,UserName,Phone,Mail,AdminPassword) VALUES(@name,@surName,@userName,@phone,@mail,@adminPassword)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", adm.Name);
                cmd.Parameters.AddWithValue("@surName", adm.SurName);
                cmd.Parameters.AddWithValue("@userName,", adm.UserName);
                cmd.Parameters.AddWithValue("@phone,", adm.Phone);
                cmd.Parameters.AddWithValue("@mail,", adm.Mail);
                cmd.Parameters.AddWithValue("@adminPassword,", adm.AdminPassword);
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
    }
}
