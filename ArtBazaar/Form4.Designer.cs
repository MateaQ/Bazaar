namespace ArtBazaar
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.Button2 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.DarkSalmon;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button2.Location = new System.Drawing.Point(574, 14);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(104, 38);
			this.Button2.TabIndex = 27;
			this.Button2.Text = "Odjava";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button4
			// 
			this.Button4.BackColor = System.Drawing.SystemColors.Control;
			this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button4.Location = new System.Drawing.Point(26, 97);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(289, 286);
			this.Button4.TabIndex = 29;
			this.Button4.UseVisualStyleBackColor = false;
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::ArtBazaar.Properties.Resources.Picture3;
			this.button1.Location = new System.Drawing.Point(321, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(281, 288);
			this.button1.TabIndex = 30;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(682, 548);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form4";
			this.Text = "ArtBazaar";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button button1;
	}
}