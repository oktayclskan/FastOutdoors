using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.AdminPanel
{
    public partial class AdminAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_surname.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_username.Text.Trim()))
                    {
                        if (!string.IsNullOrEmpty(tb_phone.Text.Trim()))
                        {
                            if (!string.IsNullOrEmpty(tb_mail.Text.Trim()))
                            {
                                if (!string.IsNullOrEmpty(tb_AdminPassword.Text.Trim()))
                                {
                                    if (dm.AdminUserNameControl(tb_username.Text.Trim()))
                                    {
                                        if (dm.AdminMailControl(tb_mail.Text.Trim()))
                                        {
                                            Admin a = new Admin();
                                            a.Name = tb_name.Text;
                                            a.SurName = tb_surname.Text;
                                            a.UserName = tb_username.Text;
                                            a.Phone = tb_phone.Text;
                                            a.Mail = tb_mail.Text;
                                            a.AdminPassword = tb_AdminPassword.Text;
                                            a.AdminStatus = true;

                                            if (dm.AdminAdd(a))
                                            {
                                                pnl_eror.Visible = false;
                                                pnl_successful.Visible = true;
                                                tb_name.Text = " ";
                                                tb_surname.Text = " ";
                                                tb_username.Text = " ";
                                                tb_phone.Text = " ";
                                                tb_mail.Text = " ";

                                            }
                                            else
                                            {
                                                pnl_successful.Visible = false;
                                                pnl_eror.Visible = true;
                                                lbl_eror.Text = "Admin Ekleme Başarısız";
                                            }
                                        }
                                        else
                                        {
                                            pnl_successful.Visible = false;
                                            pnl_eror.Visible = true;
                                            lbl_eror.Text = "Bu mail daha önce kullanılmış";
                                        }
                                        
                                    }
                                    else
                                    {
                                        pnl_successful.Visible = false;
                                        pnl_eror.Visible = true;
                                        lbl_eror.Text = "Kullanıcı adı daha önce kullanılmış";
                                    }
                                    
                                }
                                else
                                {
                                    pnl_eror.Visible = true;
                                    lbl_eror.Text = "Sifre Boş Bırakılamaz";
                                }
                            }
                            else
                            {
                                pnl_eror.Visible = true;
                                lbl_eror.Text = "e-Posta Boş Bırakılamaz";
                            }
                        }
                        else
                        {
                            pnl_eror.Visible = true;
                            lbl_eror.Text = "Telefon NO Boş Bırakılamaz";
                        }
                    }
                    else
                    {
                        pnl_eror.Visible = true;
                        lbl_eror.Text = "Kullanıcı Adı Boş Bırakılamaz";
                    }
                }
                else
                {
                    pnl_eror.Visible = true;
                    lbl_eror.Text = "Soyisim Boş Bırakılamaz";
                }

            }
            else
            {
                pnl_eror.Visible = true;
                lbl_eror.Text = "Isim Boş Bırakılamaz";
            }
        }
    }
}