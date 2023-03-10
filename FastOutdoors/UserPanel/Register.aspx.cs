using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace FastOutdoors.UserPanel
{
    public partial class Register : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_surName.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_userName.Text.Trim()))
                    {
                        if (!string.IsNullOrEmpty(tb_phone.Text.Trim()))
                        {
                            if (!string.IsNullOrEmpty(tb_mail.Text.Trim()))
                            {
                                if (!string.IsNullOrEmpty(tb_Password.Text.Trim()))
                                {
                                    if (!string.IsNullOrEmpty(tb_location.Text.Trim()))
                                    {
                                        if (dm.MemberRegisterUserNameControl(tb_userName.Text.Trim()))
                                        {
                                            if (dm.MemberRegisterMailControl(tb_mail.Text.Trim()))
                                            {
                                                Member m = new Member();
                                                m.Name = tb_name.Text;
                                                m.SurName = tb_surName.Text;
                                                m.UserName = tb_userName.Text;
                                                m.Phone = tb_phone.Text;
                                                m.Mail = tb_mail.Text;
                                                m.MemberPassword = tb_Password.Text;
                                                m.Location = tb_location.Text;
                                                m.MemberStatus = true;
                                                if (dm.MemberAdd(m))
                                                {
                                                    pnl_eror.Visible = false;
                                                    pnl_succesful.Visible = true;
                                                    tb_name.Text = " ";
                                                    tb_surName.Text = " ";
                                                    tb_userName.Text = " ";
                                                    tb_phone.Text = " ";
                                                    tb_mail.Text = " ";
                                                    tb_Password.Text = " ";
                                                    tb_location.Text = " ";
                                                }
                                                else
                                                {
                                                    pnl_eror.Visible = true;
                                                    lbl_eror.Text = "Kayıt İşlemi Başarısız";
                                                }
                                            }
                                            else
                                            {
                                                pnl_eror.Visible = true;
                                                lbl_eror.Text = "Bu mail daha önce alınmış";
                                            }
                                        }
                                        else
                                        {
                                            pnl_eror.Visible = true;
                                            lbl_eror.Text = "Bu kullanıcı adı daha ön ce alınmış";
                                        }

                                    }
                                    else
                                    {
                                        pnl_eror.Visible = true;
                                        lbl_eror.Text = "Şehir Boş Bırakılmaz";
                                    }
                                }
                                else
                                {
                                    pnl_eror.Visible = true;
                                    lbl_eror.Text = "Şifre Boş Bırakılmaz";
                                }
                            }
                            else
                            {
                                pnl_eror.Visible = true;
                                lbl_eror.Text = "e-Posta Boş Bırakılmaz";
                            }
                        }
                        else
                        {
                            pnl_eror.Visible = true;
                            lbl_eror.Text = "Telefon Boş Bırakılmaz";
                        }
                    }
                    else
                    {
                        pnl_eror.Visible = true;
                        lbl_eror.Text = "Kullanıcı Adı Boş Bırakılmaz";
                    }
                }
                else
                {
                    pnl_eror.Visible = true;
                    lbl_eror.Text = "Soyisim Boş Bırakılmaz";
                }
            }
            else
            {
                pnl_eror.Visible = true;
                lbl_eror.Text = "İsim Boş Bırakılmaz";
            }
        }
    }
}