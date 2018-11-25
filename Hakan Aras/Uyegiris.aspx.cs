using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
public partial class Uyegiris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
          //UYE  GİRİSİ YAPTIGIMIZ ALAN

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-09TUVN5\\SQLEXPRESS;Initial Catalog=emre;Integrated Security=True");
        baglanti.Open();
        SqlCommand sorgu = new SqlCommand("SELECT kul_adi, sifre FROM uye_kayit WHERE kul_adi = '" + TextBox1.Text + "' and sifre ='" + TextBox2.Text + "'", baglanti);
        SqlDataReader dr = sorgu.ExecuteReader();

        if (TextBox1.Text == "admin")
        {
            Response.Redirect("Admin.aspx");
        }
        else if (dr.Read())
        {

            Response.Redirect("Anasayfa.aspx");
        }


        else
        { Label1.Text = "hatalı giriş yaptınız"; }
    }
}