namespace ArtBazaar
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button2.Location = new System.Drawing.Point(35, 411);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(104, 38);
			this.Button2.TabIndex = 25;
			this.Button2.Text = "Odustani";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button1.Location = new System.Drawing.Point(35, 365);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(104, 40);
			this.Button1.TabIndex = 24;
			this.Button1.Text = "Prihvati";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TextBox4
			// 
			this.TextBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.TextBox4.Location = new System.Drawing.Point(214, 180);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(193, 20);
			this.TextBox4.TabIndex = 23;
			this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LavenderBlush;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(99, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 25);
			this.label5.TabIndex = 22;
			this.label5.Text = "Lozinka:";
			// 
			// TextBox3
			// 
			this.TextBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.TextBox3.Location = new System.Drawing.Point(214, 129);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(193, 20);
			this.TextBox3.TabIndex = 21;
			this.TextBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LavenderBlush;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(30, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 25);
			this.label3.TabIndex = 20;
			this.label3.Text = "Korisničko ime:";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(682, 515);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.label3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Prijava";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox TextBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.Label label3;
	}
}