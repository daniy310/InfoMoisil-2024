﻿namespace InfoMoisil_2024
{
	partial class HelperMan
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
			this.labelCharTemplate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxValidare = new System.Windows.Forms.TextBox();
			this.buttonVerify = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelCharTemplate
			// 
			this.labelCharTemplate.AutoSize = true;
			this.labelCharTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.labelCharTemplate.Location = new System.Drawing.Point(9, 9);
			this.labelCharTemplate.Margin = new System.Windows.Forms.Padding(0);
			this.labelCharTemplate.Name = "labelCharTemplate";
			this.labelCharTemplate.Size = new System.Drawing.Size(119, 37);
			this.labelCharTemplate.TabIndex = 0;
			this.labelCharTemplate.Text = "ඞ ⚫⚪";
			this.labelCharTemplate.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.label1.Location = new System.Drawing.Point(9, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "ඞ ⚫⚪";
			this.label1.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(139, 46);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 317);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// textBoxValidare
			// 
			this.textBoxValidare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxValidare.Location = new System.Drawing.Point(619, 407);
			this.textBoxValidare.Name = "textBoxValidare";
			this.textBoxValidare.Size = new System.Drawing.Size(169, 31);
			this.textBoxValidare.TabIndex = 4;
			this.textBoxValidare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// buttonVerify
			// 
			this.buttonVerify.AutoSize = true;
			this.buttonVerify.Location = new System.Drawing.Point(535, 407);
			this.buttonVerify.Name = "buttonVerify";
			this.buttonVerify.Size = new System.Drawing.Size(78, 31);
			this.buttonVerify.TabIndex = 5;
			this.buttonVerify.Text = "Verify";
			this.buttonVerify.UseVisualStyleBackColor = true;
			this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
			// 
			// HelperMan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(155)))), ((int)(((byte)(161)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonVerify);
			this.Controls.Add(this.textBoxValidare);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelCharTemplate);
			this.Name = "HelperMan";
			this.Text = "HelperMan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCharTemplate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxValidare;
		private System.Windows.Forms.Button buttonVerify;
	}
}