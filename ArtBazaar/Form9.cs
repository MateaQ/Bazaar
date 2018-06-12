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

	
	public partial class Form9 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");
		internal object textBox1_TextChanged;
		public string TextBox4_TextChanged { get; internal set; }


		public Form9(Image Slika,string naziv,string godina,string opis, string cijena, string tehnika, string motiv)
		{
			InitializeComponent();

			textBox1.Text = naziv;
			textBox2.Text = godina;
			textBox3.Text = opis;
			textBox4.Text = cijena;
			textBox5.Text = tehnika;
			textBox6.Text = motiv;


		}

		private void Form9_Load(object sender, EventArgs e)
		{
			
		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}

		private void Button2_Click(object sender, EventArgs e)
		{

		}

		public void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		public void TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		public void PictureBox1_Click(object sender, EventArgs e)
		{

		}

		public void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		public void TextBox7_TextChanged(object sender, EventArgs e)
		{

		}

		

		public void TextBox6_TextChanged(object sender, EventArgs e)
		{

		}

		public void TextBox5_TextChanged(object sender, EventArgs e)
		{

		}

	

		private void TextBox10_TextChanged(object sender, EventArgs e)
		{

		}

		public void PictureBox1_DockChanged(object sender, EventArgs e)
		{

		}

		private void Button2_Click_1(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
			this.Hide();
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			Form7 f7 = new Form7();
			f7.Show();
			this.Hide();
		}
	}
}
