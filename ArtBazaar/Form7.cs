using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArtBazaar
{
	public partial class Form7 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");


		public Form7()
		{
			InitializeComponent();
		}


		private void Button3_Click(object sender, EventArgs e)
		{

			string str = "insert into Korisnički_podaci (Broj_kartice,Ime,Prezime,Adresa,Grad) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
			con.Open();
			SqlCommand cmd = new SqlCommand(str, con);
			cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show("Kupnja slike je uspješno obavljena");
		}
		private string NewMethod1()
		{
			return $"Insert into Slika (Slika,Naziv,Godina,Opis,Cijena,Tehnika,Motiv)Values(@images,'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','" + comboBox1.Text + "','" + comboBox1.Text + "')";
		}



		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
