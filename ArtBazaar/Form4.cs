using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtBazaar
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			Form6 f6 = new Form6();
			f6.Show();
			this.Hide();

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			
		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}

		private void Button6_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			Form8 f8 = new Form8();
			f8.Show();
			this.Hide();
		}
	}
}
