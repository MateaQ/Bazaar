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

		private void Form5_Load(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			byte[] images = null;
			FileStream stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
			BinaryReader brs = new BinaryReader(stream);
			images = brs.ReadBytes((int)stream.Length);

			con.Open();

			string sqlQuery = "Insert into Slika (Slika,Naziv,Godina,Opis,Cijena,Tehnika,Motiv,Šifra_artikla,Datum_objave)Values(@images,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text+"','" + textBox7.Text+"','" + textBox8.Text+"')";
				cmd = new SqlCommand(sqlQuery,con);
			cmd.Parameters.Add(new SqlParameter("@images",images));

			int N = cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show(N.ToString() + "Unos uspješno spremljen");

			Form6 f6 = new Form6();
			f6.Show();
			this.Hide();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "jpg files(*. jpg)|*.jpg| png files (*.png)|¸*.png|All files˙(*.*)|*.*";

			if (dialog.ShowDialog()==DialogResult.OK) {

				imgLocation = dialog.FileName.ToString();
				pictureBox1.ImageLocation = imgLocation;
			}
		}
	}
}
