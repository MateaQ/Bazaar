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

	public partial class Form6 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");



		public Form6()
		{
			InitializeComponent();
			disp_data();



		}


		private void Button3_Click(object sender, EventArgs e)
		{
			Form5 f5 = new Form5();
			f5.Show();
			this.Hide();

		}



		private void Form6_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database1DataSet1.Slika' table. You can move, or remove it, as needed.
			this.slikaTableAdapter1.Fill(this.database1DataSet1.Slika);
			// TODO: This line of code loads data into the 'database1DataSet.Slika' table. You can move, or remove it, as needed.
			this.slikaTableAdapter.Fill(this.database1DataSet.Slika);





			disp_data();

			




		}
			private void Button1_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
			this.Hide();
		}

#pragma warning disable IDE1006 // Naming Styles
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles

		{




		}
#pragma warning disable IDE1006 // Naming Styles
		public void disp_data()
#pragma warning restore IDE1006 // Naming Styles
		{
			

			con.Open();

		
#pragma warning disable IDE0017 // Simplify object initialization
DataGridViewImageColumn Slika = new DataGridViewImageColumn();
#pragma warning restore IDE0017 // Simplify object initialization
			Slika.HeaderText = "Slika";
			Slika.Name = "Slika";
			dataGridView1.Columns.Add(Slika);
			
			dataGridView1.Columns[1].Name = "naziv";
			dataGridView1.Columns[2].Name = "Godina";
			dataGridView1.Columns[3].Name = "Opis";
			dataGridView1.Columns[4].Name = "cijena";
			dataGridView1.Columns[5].Name = "Tehnika";
			dataGridView1.Columns[6].Name = "Motiv";


				




			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select *from Slika ";
			cmd.ExecuteNonQuery();
		DataTable dt = new DataTable();
		SqlDataAdapter da = new SqlDataAdapter(cmd);
		da.Fill(dt);
		dataGridView1.DataSource = dt;

			



			con.Close();

		}

		private void BindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}

		

		

		public void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Image Slika = (Image)dataGridView1.SelectedRows[0].Cells["Slika"].Value;
			string naziv = dataGridView1.SelectedRows[0].Cells["naziv"].Value.ToString();

			string godina = dataGridView1.SelectedRows[0].Cells["godina"].Value.ToString();
			string opis = dataGridView1.SelectedRows[0].Cells["opis"].Value.ToString();
			string cijena = dataGridView1.SelectedRows[0].Cells["Cijena"].Value.ToString();
			string tehnika = dataGridView1.SelectedRows[0].Cells["tehnika"].Value.ToString();
			string motiv = dataGridView1.SelectedRows[0].Cells["motiv"].Value.ToString();

			Form9 f9 = new Form9(Slika,naziv, godina, opis, cijena, tehnika, motiv);
			f9.Show();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			SearchData(textBox1.Text);
		}

		private void TextChanged_Load(object sender, EventArgs e)
		{
			SearchData("");

		}




		public void SearchData(string valueToFind)
		{
			string SearchQuery = "SELECT *from Slika WHERE CONCAT(motiv,tehnika) LIKE '%"+valueToFind+"%'";
			SqlDataAdapter adapter = new SqlDataAdapter(SearchQuery,con);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dataGridView1.DataSource = table;



		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}
	}
}






