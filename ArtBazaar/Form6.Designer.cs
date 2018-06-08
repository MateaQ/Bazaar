namespace ArtBazaar
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			this.Button1 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.slikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet = new ArtBazaar.Database1DataSet();
			this.dataSet11 = new ArtBazaar.DataSet1();
			this.slikaTableAdapter = new ArtBazaar.Database1DataSetTableAdapters.SlikaTableAdapter();
			this.slikaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet1 = new ArtBazaar.Database1DataSet1();
			this.slikaTableAdapter1 = new ArtBazaar.Database1DataSet1TableAdapters.SlikaTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tehnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.slikaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slikaBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button1.Location = new System.Drawing.Point(595, 24);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(104, 40);
			this.Button1.TabIndex = 25;
			this.Button1.Text = "Nazad";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Button3
			// 
			this.Button3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button3.Location = new System.Drawing.Point(485, 24);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(104, 40);
			this.Button3.TabIndex = 27;
			this.Button3.Text = "Dodaj sliku";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// slikaBindingSource
			// 
			this.slikaBindingSource.DataMember = "Slika";
			this.slikaBindingSource.DataSource = this.database1DataSet;
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// slikaTableAdapter
			// 
			this.slikaTableAdapter.ClearBeforeFill = true;
			// 
			// slikaBindingSource1
			// 
			this.slikaBindingSource1.DataMember = "Slika";
			this.slikaBindingSource1.DataSource = this.database1DataSet1;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet1";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// slikaTableAdapter1
			// 
			this.slikaTableAdapter1.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
			this.dataGridView1.ColumnHeadersHeight = 25;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slikaDataGridViewImageColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.Godina,
            this.Opis,
            this.cijenaDataGridViewTextBoxColumn,
            this.Motiv,
            this.tehnikaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.slikaBindingSource1;
			this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
			this.dataGridView1.Location = new System.Drawing.Point(1, 79);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 150;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(731, 485);
			this.dataGridView1.TabIndex = 28;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			this.dataGridView1.Click += new System.EventHandler(this.BindingSource1_CurrentChanged);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
			// 
			// slikaDataGridViewImageColumn
			// 
			this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
			this.slikaDataGridViewImageColumn.FillWeight = 110F;
			this.slikaDataGridViewImageColumn.HeaderText = "Slika";
			this.slikaDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
			// 
			// nazivDataGridViewTextBoxColumn
			// 
			this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
			this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
			this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
			// 
			// Godina
			// 
			this.Godina.DataPropertyName = "Godina";
			this.Godina.HeaderText = "Godina";
			this.Godina.Name = "Godina";
			// 
			// Opis
			// 
			this.Opis.DataPropertyName = "Opis";
			this.Opis.HeaderText = "Opis";
			this.Opis.Name = "Opis";
			// 
			// cijenaDataGridViewTextBoxColumn
			// 
			this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
			this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
			this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
			// 
			// Motiv
			// 
			this.Motiv.DataPropertyName = "Motiv";
			this.Motiv.HeaderText = "Motiv";
			this.Motiv.Name = "Motiv";
			// 
			// tehnikaDataGridViewTextBoxColumn
			// 
			this.tehnikaDataGridViewTextBoxColumn.DataPropertyName = "Tehnika";
			this.tehnikaDataGridViewTextBoxColumn.HeaderText = "Tehnika";
			this.tehnikaDataGridViewTextBoxColumn.Name = "tehnikaDataGridViewTextBoxColumn";
			// 
			// dataSet11BindingSource
			// 
			this.dataSet11BindingSource.DataSource = this.dataSet11;
			this.dataSet11BindingSource.Position = 0;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Moccasin;
			this.textBox1.Location = new System.Drawing.Point(212, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 20);
			this.textBox1.TabIndex = 29;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.BurlyWood;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 15);
			this.label1.TabIndex = 30;
			this.label1.Text = "Pretraži slike po tehnici ili motivu";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(732, 496);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form6";
			this.Text = "Slike";
			this.Load += new System.EventHandler(this.Form6_Load);
			((System.ComponentModel.ISupportInitialize)(this.slikaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slikaBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button3;
		private DataSet1 dataSet11;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource slikaBindingSource;
		private Database1DataSetTableAdapters.SlikaTableAdapter slikaTableAdapter;
		private Database1DataSet1 database1DataSet1;
		private System.Windows.Forms.BindingSource slikaBindingSource1;
		private Database1DataSet1TableAdapters.SlikaTableAdapter slikaTableAdapter1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource dataSet11BindingSource;
		private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
		private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
		private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motiv;
		private System.Windows.Forms.DataGridViewTextBoxColumn tehnikaDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}