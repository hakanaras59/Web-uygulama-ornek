using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //PERSONEL TABLOSUNA KAYIT YAPIYOR
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-09TUVN5\\SQLEXPRESS;Initial Catalog=emre;Integrated Security=True");
        SqlCommand con = new SqlCommand("INSERT INTO personel (Uye_No,Ad_Soyad,Katilim_Yili,Yardimlari,Meslek) VALUES (@Uye_No,@Ad_Soyad,@Katilim_Yili,@Yardimlari,@Meslek)", bag);
        bag.Open();
        con.Parameters.AddWithValue("@Uye_No", TextBox1.Text);
        con.Parameters.AddWithValue("@Ad_Soyad", TextBox2.Text);
        con.Parameters.AddWithValue("@Katilim_Yili", TextBox3.Text);
        con.Parameters.AddWithValue("@Yardimlari", TextBox4.Text);
        con.Parameters.AddWithValue("@Meslek", TextBox5.Text);


        if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == "") || (TextBox5.Text == ""))
        {
            Label1.Text = "Eksik bilgi girdiniz";


        }
        else
        {
            con.ExecuteNonQuery();
            Label1.Text = "Kayıt Yapıldı";
            Response.Redirect("Admin.aspx");

        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //PERSONEL TABLOSUNDAN KAYİT SİLER
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-09TUVN5\\SQLEXPRESS;Initial Catalog=emre;Integrated Security=True");
        bag.Open();
        SqlCommand com = new SqlCommand("DELETE FROM personel WHERE Uye_No='" + TextBox1.Text + "'", bag);
        com.ExecuteNonQuery();
        Label1.Text = "Kayıt silindi";
        Response.Redirect("Admin.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //PERSONEL TABLOSUNDAN KAYİT GÜNCELLER
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-09TUVN5\\SQLEXPRESS;Initial Catalog=emre;Integrated Security=True");
        bag.Open();
        SqlCommand con = new SqlCommand("UPDATE personel SET Uye_No=@Uye_No,Ad_Soyad=@Ad_Soyad,Katilim_Yili=@Katilim_Yili,Yardimlari=@Yardimlari,Meslek=@Meslek  WHERE Uye_No='" + TextBox1.Text + "'", bag);
        con.Parameters.AddWithValue("@Uye_No", TextBox1.Text);
        con.Parameters.AddWithValue("@Ad_Soyad", TextBox2.Text);
        con.Parameters.AddWithValue("@Katilim_Yili", TextBox3.Text);
        con.Parameters.AddWithValue("@Yardimlari", TextBox4.Text);
        con.Parameters.AddWithValue("@Meslek", TextBox5.Text);

        if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == "") || (TextBox5.Text == ""))
        {
            Label1.Text = "Tüm alanları doldurun";


        }
        else
        {
            con.ExecuteNonQuery();
            Label1.Text = "Kayıt Yapıldı";
            Response.Redirect("Admin.aspx");

        }
    }
}