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
	public partial class Form2 : Form
	{
		

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		private void Button1_Click(object sender, EventArgs e)
		{

			if (textBox4.Text == textBox5.Text)
			{
				SqlConnection con = Getcon();

				string str = "insert into Korisnik (Ime,Prezime,Email,Lozinka,PonoviLozinku) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
				con.Open();
				SqlCommand cmd = new SqlCommand(str, con);
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Registracija uspješno obavljena !");

				Form4 f4 = new Form4();
				f4.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Krivi unos ! Lozinke se ne podudaraju !");
			}
			

			

		}

		private static SqlConnection Getcon()
		{
			return new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");
		}


		private void Button2_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();

		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
