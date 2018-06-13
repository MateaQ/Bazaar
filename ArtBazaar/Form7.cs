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
	public partial class Form7 : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");
		public object DataGridView1;
		public int datagridview1;


		public Slika Slika1  { get; set; }
		public static object Global { get; private set; }

		public Form7()
		{
			InitializeComponent();

			
		}


		public  void Button3_Click(object sender, EventArgs e)
		{
		

			string str = "insert into Korisnički_podaci (Broj_kartice,Ime,Prezime,Adresa,Grad) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
			con.Open();
			SqlCommand cmd = new SqlCommand(str, con);
			cmd.ExecuteNonQuery();

			if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
			{

				MessageBox.Show("Morate ispuniti sve vrijednosti!");
			}

		
			else
			{
				MessageBox.Show("Hvala na kupnji");
			}


			con.Close(); 


		}
		private string NewMethod1()
		{
			return $"Insert into Slika (Slika,Naziv,Godina,Opis,Cijena,Tehnika,Motiv)Values(@images,'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','" + comboBox1.Text + "','" + comboBox1.Text + "')";
		}



		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form7_Load(object sender, EventArgs e)
		{

		}
		public static void DeleteRow(string Slika, string columnName, string IDNumber)
		{
		
		}
	}




}

