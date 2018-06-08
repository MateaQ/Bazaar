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
using System.IO;

namespace ArtBazaar
{
	public partial class Form5 : Form
	{
		

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");

		public Form5()
		{
			InitializeComponent();

		}

		string imgLocation = "";
		SqlCommand cmd;

		public string File { get; private set; }

		private void Form5_Load(object sender, EventArgs e)
		{

		}

		private void Label9_Click(object sender, EventArgs e)
		{

		}

		private void Label7_Click(object sender, EventArgs e)
		{

		}

		private void TextBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label8_Click(object sender, EventArgs e)
		{

		}

		private void TextBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label10_Click(object sender, EventArgs e)
		{

		}


		private  void Button1_Click(object sender, EventArgs e)
		{
			byte[] images = null;
			FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
			BinaryReader brs = new BinaryReader(stream);
			images = brs.ReadBytes((int)stream.Length);


			con.Open();

			string sqlQuery = NewMethod1();

			cmd = new SqlCommand(sqlQuery, con);
			cmd.Parameters.Add(new SqlParameter("@images", images));

			int N = cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show( "Unos uspješno spremljen");


			Form6 f6 = new Form6();
			f6.Show();
			this.Hide();
		}

		private string NewMethod1()
		{
			return $"Insert into Slika (Slika,Naziv,Godina,Opis,Cijena,Tehnika,Motiv)Values(@images,'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','" + comboBox1.Text + "','"  + comboBox2.Text + "')";
		}

		private void TextBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label6_Click(object sender, EventArgs e)
		{

		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form6 f6 = new Form6();
			f6.Show();
			this.Hide();
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void Label4_Click(object sender, EventArgs e)
		{

		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Button3_Click(object sender, EventArgs e)
		{

#pragma warning disable IDE0017 // Simplify object initialization
			OpenFileDialog dialog = new OpenFileDialog();
#pragma warning restore IDE0017 // Simplify object initialization
			dialog.Filter = "jpg files(*. jpg)|*.jpg| png files (*.png)|¸*.png|All files˙(*.*)|*.*";

			if (dialog.ShowDialog() == DialogResult.OK)
			{

				imgLocation = dialog.FileName.ToString();
				pictureBox1.ImageLocation = imgLocation;

			}
		}

		internal class Method
		{
			public string Filter { get; set; }
		}

		private void TextBox5_Click(object sender, EventArgs e)
		{

		}

		private void TextBox5_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}

	


	



