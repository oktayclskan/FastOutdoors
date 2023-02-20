﻿using System;
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
        public Admin AdminLogin(string mail, string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Admins WHERE Mail=@mail AND AdminPassword=@sifre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
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
                cmd.Parameters.AddWithValue("@id", id);
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
                cmd.Parameters.AddWithValue("@id", id);
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
                cmd.Parameters.AddWithValue("@name", mem.Name);
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
                cmd.Parameters.AddWithValue("@id", id);
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
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@img", c.Img);
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
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        #endregion
        #region Comments Metots

        public List<Comment> CommentList()
        {
            List<Comment> comments = new List<Comment>();
            try
            {
                cmd.CommandText = "SELECT C.ID, cg.Name,m.Name, C.Title, C.Content, C.CommentDate, C.CommentViews, C.CommentStatus, C.Img From Comments AS C Join Categorys AS CG ON C.Category_ID=CG.ID Join Members AS M ON C.Member_ID = M.ID ";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comment c = new Comment();
                    c.ID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.MemberName = reader.GetString(2);
                    c.Title = reader.GetString(3);
                    c.Content = reader.GetString(4);
                    c.CommentDate = reader.GetDateTime(5);
                    c.CommentViews = reader.GetInt32(6);
                    c.CommentStatus = reader.GetBoolean(7);
                    c.CommentStatusStr = reader.GetBoolean(7) ? "<label style='color:green'>Yayında</label>" : "<label style='color:red'>Kaldırılmış</label>";
                    c.Img = !reader.IsDBNull(8) ? reader.GetString(8) : "none.png";
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
        public void CommentDelete(int id)
        {
            try
            {
                cmd.CommandText = "DELETE From Comments Where ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        #endregion
        #region Answer Metots
        public List<Answers> AnswerList()
        {
            List<Answers> answers = new List<Answers>();
            try
            {
                cmd.CommandText = "Select A.ID, C.ID, M.Name,A.Contents,A.AnwersTime From Answers AS A join Comments AS C ON A.Comment_ID=c.ID join Members AS m ON A.Member_ID = M.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Answers a = new Answers();
                    a.ID = reader.GetInt32(0);
                    a.Comment_ID = reader.GetInt32(1);
                    a.MemberName = reader.GetString(2);
                    a.Content = reader.GetString(3);
                    a.AnswersTime = reader.GetDateTime(4);
                    answers.Add(a);
                }
                return answers;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void DeleteAnswer(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Answers WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        #endregion
        #region Paragrahs Metots
        public List<Paragraphs> ParagraphsList()
        {
            List<Paragraphs> paragraphs = new List<Paragraphs>();
            try
            {
                cmd.CommandText = "SELECT P.ID, C.Name, A.Name, P.Title, P.Contents, P.ParagraphsViews,P.ParagraphsDateTime,P.Img FROM Paragraphs AS P Join Categorys AS C ON P.Category_ID=C.ID Join Admins AS A ON P.Admin_ID=A.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Paragraphs p = new Paragraphs();
                    p.ID = reader.GetInt32(0);
                    p.CategoryName = reader.GetString(1);
                    p.AdminName = reader.GetString(2);
                    p.Title = reader.GetString(3);
                    p.Contents = reader.GetString(4);
                    p.ParagraphViews = reader.GetInt32(5);
                    p.ParagraphDateTime = reader.GetDateTime(6);
                    p.Img = !reader.IsDBNull(7) ? reader.GetString(7) : "none.png";
                    paragraphs.Add(p);
                }
                return paragraphs;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void DeleteParagraph(int id)
        {
            try
            {
                cmd.CommandText = "DELETE From Paragraphs WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        public bool ParagraphAdd(Paragraphs p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Paragraphs(Category_ID,Admin_ID,Title,Contents,ParagraphsViews,ParagraphsDateTime,Img) VALUES(@categoryID,@adminID,@title,@contents,@paragraphsViews,@paragraphsDateTime,@img)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@categoryID", p.Category_ID);
                cmd.Parameters.AddWithValue("@adminID", p.Admin_ID);
                cmd.Parameters.AddWithValue("@title", p.Title);
                cmd.Parameters.AddWithValue("@contents", p.Contents);
                cmd.Parameters.AddWithValue("@paragraphsViews", p.ParagraphViews);
                cmd.Parameters.AddWithValue("@paragraphsDateTime", p.ParagraphDateTime);
                cmd.Parameters.AddWithValue("@img", p.Img);
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
        public Paragraphs ParagraphgetGet(int id)
        {
            try
            {
                cmd.CommandText = "SELECT P.ID, C.Name, A.Name, P.Title, P.Contents, P.ParagraphsViews,P.ParagraphsDateTime,P.Img FROM Paragraphs AS P Join Categorys AS C ON P.Category_ID=C.ID Join Admins AS A ON P.Admin_ID=A.ID Where P.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Paragraphs p = new Paragraphs();
                while (reader.Read())
                {
                    p.ID = reader.GetInt32(0);
                    p.CategoryName = reader.GetString(1);
                    p.AdminName = reader.GetString(2);
                    p.Title = reader.GetString(3);
                    p.Contents = reader.GetString(4);
                    p.ParagraphViews = reader.GetInt32(5);
                    p.ParagraphDateTime = reader.GetDateTime(6);
                    p.Img = !reader.IsDBNull(7) ? reader.GetString(7) : "none.png";
                }
                return p;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool ParagraphUpdate(Paragraphs p)
        {
            try
            {
                cmd.CommandText = "UPDATE Paragraphs SET Category_ID = @categoryID ,Title = @title, Contents = @contents, Img = @img, WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",p.ID);
                cmd.Parameters.AddWithValue("@category_ID", p.Category_ID);
                cmd.Parameters.AddWithValue("@title",p.Title);
                cmd.Parameters.AddWithValue("@contents", p.Contents);
                cmd.Parameters.AddWithValue("@img", p.Img);
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
