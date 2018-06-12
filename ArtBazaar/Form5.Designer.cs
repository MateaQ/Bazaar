using System.Windows.Forms;

namespace ArtBazaar
{
	partial class Form5
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pastelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.akvarelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LavenderBlush;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(57, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 25);
			this.label5.TabIndex = 35;
			this.label5.Text = "Slika:";
			this.label5.Click += new System.EventHandler(this.Label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LavenderBlush;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(47, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 25);
			this.label4.TabIndex = 34;
			this.label4.Text = "Godina:";
			this.label4.Click += new System.EventHandler(this.Label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LavenderBlush;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(72, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 25);
			this.label3.TabIndex = 33;
			this.label3.Text = "Opis:";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LavenderBlush;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(63, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 25);
			this.label1.TabIndex = 31;
			this.label1.Text = "Naziv:";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.textBox3.Location = new System.Drawing.Point(152, 284);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(193, 20);
			this.textBox3.TabIndex = 39;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.textBox2.Location = new System.Drawing.Point(152, 238);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(193, 20);
			this.textBox2.TabIndex = 38;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.textBox1.Location = new System.Drawing.Point(152, 198);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(193, 20);
			this.textBox1.TabIndex = 36;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button2.Location = new System.Drawing.Point(533, 426);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(104, 38);
			this.Button2.TabIndex = 42;
			this.Button2.Text = "Odustani";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button1.Location = new System.Drawing.Point(533, 380);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(104, 40);
			this.Button1.TabIndex = 41;
			this.Button1.Text = "Spremi";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.textBox4.Location = new System.Drawing.Point(152, 332);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(193, 20);
			this.textBox4.TabIndex = 44;
			this.textBox4.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.LavenderBlush;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(57, 325);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 25);
			this.label6.TabIndex = 43;
			this.label6.Text = "Cijena:";
			this.label6.Click += new System.EventHandler(this.Label6_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.LavenderBlush;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(55, 361);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 25);
			this.label9.TabIndex = 46;
			this.label9.Text = "Tehnika:";
			this.label9.Click += new System.EventHandler(this.Label9_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.LavenderBlush;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.Location = new System.Drawing.Point(27, 399);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(123, 25);
			this.label10.TabIndex = 45;
			this.label10.Text = "Motiv/vrsta:";
			this.label10.Click += new System.EventHandler(this.Label10_Click);
			// 
			// Button3
			// 
			this.Button3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button3.Location = new System.Drawing.Point(12, 106);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(104, 38);
			this.Button3.TabIndex = 53;
			this.Button3.Text = "Odaberi";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(142, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(196, 155);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 54;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pastelToolStripMenuItem,
            this.akvarelToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowCheckMargin = true;
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
			// 
			// pastelToolStripMenuItem
			// 
			this.pastelToolStripMenuItem.Name = "pastelToolStripMenuItem";
			this.pastelToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.pastelToolStripMenuItem.Text = "Pastel";
			// 
			// akvarelToolStripMenuItem
			// 
			this.akvarelToolStripMenuItem.Name = "akvarelToolStripMenuItem";
			this.akvarelToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.akvarelToolStripMenuItem.Text = "Akvarel";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Pastel",
            "Akvarel",
            "Gvaš",
            "Tempera",
            "Akrilne boje",
            "Uljane boje",
            "Enkaustika",
            "Kazein",
            "Batik",
            "Freska",
            "Kolaž",
            "Mozaik",
            "Vitraj ",
            "Tapiserija"});
			this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Pastel",
            "Akvarel",
            "Gvaš",
            "Tempera",
            "Akrilne boje",
            "Uljane boje",
            "Enkaustika",
            "Kazein",
            "Batik",
            "Freska",
            "Kolaž",
            "Mozaik",
            "Vitraj ",
            "Tapiserija"});
			this.comboBox1.Location = new System.Drawing.Point(156, 361);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(182, 21);
			this.comboBox1.TabIndex = 59;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Portret ",
            "Autoportret",
            "Karikatura",
            "Figura ",
            "Akt ",
            "Poluakt ",
            "Interijer",
            "Genre ",
            "Pejzaž ",
            "Panorama ",
            "Veduta ",
            "Marina ",
            "Ruina ",
            "Animalizam ",
            "Mrtva priroda "});
			this.comboBox2.Location = new System.Drawing.Point(152, 399);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(186, 21);
			this.comboBox2.TabIndex = 60;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(717, 523);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form5";
			this.Text = "Dodaj Sliku";
			this.Load += new System.EventHandler(this.Form5_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void NewMethod()
		{
		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem pastelToolStripMenuItem;
		private ToolStripMenuItem akvarelToolStripMenuItem;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
	}




}