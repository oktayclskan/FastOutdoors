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
                cmd.CommandText = "SELECT COUNT(*) FROM Admins WHERE Mail=@mail AND AdminPassword=@sifre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail",mail);
                cmd.Parameters.AddWithValue("@sifre",sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi > 0)
                {
                    cmd.CommandText = "SELECT * FROM Admins WHERE Mail=@mail AND AdminPassword=@sifre";
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
        public bool AdminAdd(Admin adm)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Admins(Name,SurName,UserName,Phone,Mail,AdminPassword,AdminStatus) VALUES(@name,@surName,@userName,@phone,@mail,@adminPassword,1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", adm.Name);
                cmd.Parameters.AddWithValue("@surName", adm.SurName);
                cmd.Parameters.AddWithValue("@userName", adm.UserName);
                cmd.Parameters.AddWithValue("@phone", adm.Phone);
                cmd.Parameters.AddWithValue("@mail", adm.Mail);
                cmd.Parameters.AddWithValue("@adminPassword", adm.AdminPassword);
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
        public List<Admin> AdminList(int d)
        {
            List<Admin> admins = new List<Admin>();
            try
            {
                cmd.CommandText = "SELECT * From Admins Where AdminStatus=@adminStatus";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@adminStatus", d);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Admin a = new Admin();
                    a.ID = reader.GetInt32(0);
                    a.Name = reader.GetString(1);
                    a.SurName = reader.GetString(2);
                    a.UserName = reader.GetString(3);
                    a.Phone = reader.GetString(4);
                    a.Mail = reader.GetString(5);
                    a.AdminPassword = reader.GetString(6);
                    a.AdminStatus = reader.GetBoolean(7);
                    a.AdminStatusStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:Red'>Pasif</label>";
                    admins.Add(a);
                }
                return admins;

            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void AdminStatusPassive(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Admins Set AdminStatus=0 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        public void AdminStatusActive(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Admins Set AdminStatus=1 WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
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
        #region CategoryMetot
        public List<Category> CategoryList()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT * From Categorys";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Img = reader.GetString(2);
                    categories.Add(c);
                }
                return categories;
                
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool CategoryAdd(Category c)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categorys(Name,Img) VALUES (@name,@img)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name",c.Name);
                cmd.Parameters.AddWithValue("@img",c.Img);
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
        public void CategoryDelete(int id)
        {
            try
            {
                cmd.CommandText = "Delete From Categorys Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        #endregion
        #region Comments Metots
        public List<Comment> CommentList()
        {
            
            try
            {
                List<Comment> comments = new List<Comment>();

                cmd.CommandText = "SELECT C.ID, C.Category_ID, C.Member_ID, C.Admin_ID, C.Tile, C.Content, C.CommemtDate, C.CommentViews, C.CommentStatus, C.Img From Comments AS C Join Categorys AS CG ON C.Category_ID=CG.ID Join Members AS M ON C.Member_ID=M.ID Join Admins AS A ON C.Admin_ID=A.ID ";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comment c = new Comment();
                    c.ID = reader.GetInt32(0);
                    c.Category_ID = reader.GetInt32(1);
                    c.CategoryName = reader.GetString(2);
                    c.Member_ID = reader.GetInt32(3);
                    c.MemberName = reader.GetString(4);
                    c.Admin_ID = reader.GetInt32(5);
                    c.AdminName = reader.GetString(6);
                    c.Title = reader.GetString(7);
                    c.Content = reader.GetString(8);
                    c.CommentDate = reader.GetDateTime(9);
                    c.CommentViews = reader.GetInt32(10);
                    c.CommentStatus = reader.GetBoolean(11);
                    c.Img = reader.GetString(12);
                    comments.Add(c);
                }
                return comments;
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
        #endregion

    }
}
