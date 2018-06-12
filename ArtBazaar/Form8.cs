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
	public partial class Form8 : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Matea\Source\Repos\Bazaar2\ArtBazaar\Database1.mdf;Integrated Security = True");


		public Form8()
		{
			InitializeComponent();

			

		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}

		private void Button3_Click(object sender, EventArgs e)
		{

		}

		private void Form8_Load(object sender, EventArgs e)
		{
			Disp_data();
			// TODO: This line of code loads data into the 'database1DataSet3.Skulptura' table. You can move, or remove it, as needed.
			this.skulpturaTableAdapter.Fill(this.database1DataSet3.Skulptura);

		}
		public void Disp_data()
#pragma warning restore IDE1006 // Naming Styles
		{


			con.Open();


#pragma warning disable IDE0017 // Simplify object initialization
			DataGridViewImageColumn Slika = new DataGridViewImageColumn();
#pragma warning restore IDE0017 // Simplify object initialization
			Slika.HeaderText = "Sl_skulpture";
			Slika.Name = "Sl_skulpture";
			dataGridView1.Columns.Add(Slika);

			dataGridView1.Columns[1].Name = "Naziv_sk";
			dataGridView1.Columns[2].Name = "opis_sk";
			dataGridView1.Columns[3].Name = "godina";
			dataGridView1.Columns[4].Name = "cijena";
			dataGridView1.Columns[5].Name = "tehnika_sk";
			dataGridView1.Columns[6].Name = "vrsta";







			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select *from Skulptura ";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView1.DataSource = dt;





			con.Close();

		}




		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			DataGridViewRow selected_row = dataGridView1.Rows[index];



			Image Slika = (Image)dataGridView1.SelectedRows[0].Cells["Sl_skulpture"].Value;
			string naziv = dataGridView1.SelectedRows[0].Cells["Naziv_sk"].Value.ToString();

			string godina = dataGridView1.SelectedRows[0].Cells["godina"].Value.ToString();
			string opis = dataGridView1.SelectedRows[0].Cells["opis_sk"].Value.ToString();
			string cijena = dataGridView1.SelectedRows[0].Cells["cijena"].Value.ToString();
			string tehnika = dataGridView1.SelectedRows[0].Cells["tehnika_sk"].Value.ToString();
			string motiv = dataGridView1.SelectedRows[0].Cells["vrsta"].Value.ToString();

			Form9 f9 = new Form9(Slika, naziv, godina, opis, cijena, tehnika, motiv);
			f9.Show();
		}

		private void Button3_Click_1(object sender, EventArgs e)
		{
			Form10 f10 = new Form10();
			f10.Show();
			this.Hide();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
			this.Hide();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			SearchData(textBox1.Text);
		}
		public void SearchData(string valueToFind)
		{
			string SearchQuery = "SELECT *from Skulptura WHERE CONCAT(tehnika_sk,vrsta) LIKE '%" + valueToFind + "%'";
			SqlDataAdapter adapter = new SqlDataAdapter(SearchQuery, con);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dataGridView1.DataSource = table;


		}



	}
}
