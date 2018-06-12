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
	public partial class Form10 : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");

		public Form10()
		{
			InitializeComponent();
		}


		string imgLocation = "";
		SqlCommand cmd;

		public string File { get; private set; }

		private void Form10_Load(object sender, EventArgs e)
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


		private void Button1_Click(object sender, EventArgs e)
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

			MessageBox.Show("Unos uspješno spremljen");



			Form8 f8 = new Form8();
			f8.Show();
			this.Hide();
		}
		private string NewMethod1()
		{
			return $"Insert into Skulptura (Sl_skulpture,Naziv_sk,opis_sk,godina,cijena,tehnika_sk,vrsta)Values(@images,'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','" + comboBox1.Text + "','" + comboBox2.Text + "')";
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form8 f8 = new Form8();
			f8.Show();
			this.Hide();
		}
	}
}
