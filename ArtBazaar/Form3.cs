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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");
			SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Korisnik where Email='" + TextBox3.Text + "' and Lozinka='" + TextBox4.Text + "'", con);
			DataTable dt = new DataTable();
			NewMethod(sda, dt);

			if (dt.Rows[0][0].ToString() == "1")
			{
				this.Hide();
				Form4 f4 = new Form4();
				f4.Show();
			}
			else
			{
				MessageBox.Show("Krivi unos Emaila ili lozinke!!");

			}
		}

		private static void NewMethod(SqlDataAdapter sda, DataTable dt)
		{
			sda.Fill(dt);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
