namespace ArtBazaar
{
	partial class Form8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			this.Button2 = new System.Windows.Forms.Button();
			this.skulpturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet3 = new ArtBazaar.Database1DataSet3();
			this.skulpturaTableAdapter = new ArtBazaar.Database1DataSet3TableAdapters.SkulpturaTableAdapter();
			this.Button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.slskulptureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nazivskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.opis_sk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tehnikaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.skulpturaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button2.Location = new System.Drawing.Point(649, 10);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(104, 38);
			this.Button2.TabIndex = 44;
			this.Button2.Text = "Nazad";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// skulpturaBindingSource
			// 
			this.skulpturaBindingSource.DataMember = "Skulptura";
			this.skulpturaBindingSource.DataSource = this.database1DataSet3;
			// 
			// database1DataSet3
			// 
			this.database1DataSet3.DataSetName = "Database1DataSet3";
			this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// skulpturaTableAdapter
			// 
			this.skulpturaTableAdapter.ClearBeforeFill = true;
			// 
			// Button3
			// 
			this.Button3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button3.Location = new System.Drawing.Point(539, 10);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(104, 40);
			this.Button3.TabIndex = 46;
			this.Button3.Text = "Dodaj skulpturu";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeight = 50;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slskulptureDataGridViewImageColumn,
            this.nazivskDataGridViewTextBoxColumn,
            this.opis_sk,
            this.godina,
            this.cijenaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.tehnikaskDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.skulpturaBindingSource;
			this.dataGridView1.GridColor = System.Drawing.Color.OrangeRed;
			this.dataGridView1.Location = new System.Drawing.Point(-2, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.RowTemplate.Height = 150;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(745, 475);
			this.dataGridView1.StandardTab = true;
			this.dataGridView1.TabIndex = 70;
			this.dataGridView1.UseWaitCursor = true;
			this.dataGridView1.VirtualMode = true;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.BurlyWood;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(28, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 15);
			this.label1.TabIndex = 72;
			this.label1.Text = "Pretraži skulpture po tehnici ili vrsti";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Moccasin;
			this.textBox1.Location = new System.Drawing.Point(242, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 20);
			this.textBox1.TabIndex = 71;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// slskulptureDataGridViewImageColumn
			// 
			this.slskulptureDataGridViewImageColumn.DataPropertyName = "Sl_skulpture";
			this.slskulptureDataGridViewImageColumn.FillWeight = 200F;
			this.slskulptureDataGridViewImageColumn.HeaderText = "Sl_skulpture";
			this.slskulptureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.slskulptureDataGridViewImageColumn.Name = "slskulptureDataGridViewImageColumn";
			this.slskulptureDataGridViewImageColumn.Width = 176;
			// 
			// nazivskDataGridViewTextBoxColumn
			// 
			this.nazivskDataGridViewTextBoxColumn.DataPropertyName = "Naziv_sk";
			this.nazivskDataGridViewTextBoxColumn.HeaderText = "Naziv";
			this.nazivskDataGridViewTextBoxColumn.Name = "nazivskDataGridViewTextBoxColumn";
			this.nazivskDataGridViewTextBoxColumn.Width = 87;
			// 
			// opis_sk
			// 
			this.opis_sk.DataPropertyName = "opis_sk";
			this.opis_sk.HeaderText = "opis";
			this.opis_sk.Name = "opis_sk";
			// 
			// godina
			// 
			this.godina.DataPropertyName = "godina";
			this.godina.HeaderText = "godina";
			this.godina.Name = "godina";
			// 
			// cijenaDataGridViewTextBoxColumn
			// 
			this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
			this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
			this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
			this.cijenaDataGridViewTextBoxColumn.Width = 87;
			// 
			// vrstaDataGridViewTextBoxColumn
			// 
			this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
			this.vrstaDataGridViewTextBoxColumn.HeaderText = "vrsta";
			this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
			this.vrstaDataGridViewTextBoxColumn.Width = 89;
			// 
			// tehnikaskDataGridViewTextBoxColumn
			// 
			this.tehnikaskDataGridViewTextBoxColumn.DataPropertyName = "tehnika_sk";
			this.tehnikaskDataGridViewTextBoxColumn.HeaderText = "tehnika";
			this.tehnikaskDataGridViewTextBoxColumn.Name = "tehnikaskDataGridViewTextBoxColumn";
			this.tehnikaskDataGridViewTextBoxColumn.Width = 88;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(755, 514);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Button2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form8";
			this.Text = "Skulpture";
			this.Load += new System.EventHandler(this.Form8_Load);
			((System.ComponentModel.ISupportInitialize)(this.skulpturaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Button2;
		private Database1DataSet3 database1DataSet3;
		private System.Windows.Forms.BindingSource skulpturaBindingSource;
		private Database1DataSet3TableAdapters.SkulpturaTableAdapter skulpturaTableAdapter;
		private System.Windows.Forms.Button Button3;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridViewImageColumn slskulptureDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazivskDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn opis_sk;
		private System.Windows.Forms.DataGridViewTextBoxColumn godina;
		private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tehnikaskDataGridViewTextBoxColumn;
	}
}