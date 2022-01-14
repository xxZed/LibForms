
namespace LibForms
{
	partial class GenreForm
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
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.g_read = new System.Windows.Forms.Button();
			this.g_delete = new System.Windows.Forms.Button();
			this.g_id = new System.Windows.Forms.TextBox();
			this.g_save = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.g_update = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.g_name = new System.Windows.Forms.TextBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.g_read);
			this.groupBox7.Controls.Add(this.g_delete);
			this.groupBox7.Controls.Add(this.g_id);
			this.groupBox7.Controls.Add(this.g_save);
			this.groupBox7.Controls.Add(this.label20);
			this.groupBox7.Controls.Add(this.g_update);
			this.groupBox7.Controls.Add(this.label22);
			this.groupBox7.Controls.Add(this.g_name);
			this.groupBox7.Location = new System.Drawing.Point(12, 12);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(295, 194);
			this.groupBox7.TabIndex = 38;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "CREATE/UPDATE GENRE";
			// 
			// g_read
			// 
			this.g_read.Location = new System.Drawing.Point(6, 162);
			this.g_read.Name = "g_read";
			this.g_read.Size = new System.Drawing.Size(283, 23);
			this.g_read.TabIndex = 32;
			this.g_read.Text = "READ/VIEW";
			this.g_read.UseVisualStyleBackColor = true;
			this.g_read.Click += new System.EventHandler(this.g_read_Click);
			// 
			// g_delete
			// 
			this.g_delete.Location = new System.Drawing.Point(6, 133);
			this.g_delete.Name = "g_delete";
			this.g_delete.Size = new System.Drawing.Size(283, 23);
			this.g_delete.TabIndex = 34;
			this.g_delete.Text = "DELETE";
			this.g_delete.UseVisualStyleBackColor = true;
			this.g_delete.Click += new System.EventHandler(this.g_delete_Click);
			// 
			// g_id
			// 
			this.g_id.Location = new System.Drawing.Point(119, 20);
			this.g_id.Name = "g_id";
			this.g_id.Size = new System.Drawing.Size(170, 20);
			this.g_id.TabIndex = 32;
			this.g_id.Text = "Only for update";
			// 
			// g_save
			// 
			this.g_save.Location = new System.Drawing.Point(6, 75);
			this.g_save.Name = "g_save";
			this.g_save.Size = new System.Drawing.Size(283, 23);
			this.g_save.TabIndex = 31;
			this.g_save.Text = "SAVE";
			this.g_save.UseVisualStyleBackColor = true;
			this.g_save.Click += new System.EventHandler(this.g_save_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(11, 23);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(21, 13);
			this.label20.TabIndex = 31;
			this.label20.Text = "ID:";
			// 
			// g_update
			// 
			this.g_update.Location = new System.Drawing.Point(6, 104);
			this.g_update.Name = "g_update";
			this.g_update.Size = new System.Drawing.Size(283, 23);
			this.g_update.TabIndex = 33;
			this.g_update.Text = "UPDATE";
			this.g_update.UseVisualStyleBackColor = true;
			this.g_update.Click += new System.EventHandler(this.g_update_Click);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(11, 49);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(39, 13);
			this.label22.TabIndex = 14;
			this.label22.Text = "Genre:";
			// 
			// g_name
			// 
			this.g_name.Location = new System.Drawing.Point(119, 46);
			this.g_name.Name = "g_name";
			this.g_name.Size = new System.Drawing.Size(170, 20);
			this.g_name.TabIndex = 21;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.dataGridView4);
			this.groupBox8.Location = new System.Drawing.Point(12, 212);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(295, 243);
			this.groupBox8.TabIndex = 39;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "READ/VIEW GEBRE";
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Location = new System.Drawing.Point(8, 19);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(281, 218);
			this.dataGridView4.TabIndex = 0;
			// 
			// GenreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 467);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox7);
			this.Name = "GenreForm";
			this.Text = "GenreForm";
			this.Load += new System.EventHandler(this.GenreForm_Load);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button g_read;
		private System.Windows.Forms.Button g_delete;
		private System.Windows.Forms.TextBox g_id;
		private System.Windows.Forms.Button g_save;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button g_update;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox g_name;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.DataGridView dataGridView4;
	}
}