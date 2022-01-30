namespace LibForms
{
    partial class BookForm
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
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.GenreCombo = new System.Windows.Forms.ComboBox();
			this.b_read = new System.Windows.Forms.Button();
			this.b_delete = new System.Windows.Forms.Button();
			this.b_id = new System.Windows.Forms.TextBox();
			this.b_save = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.b_update = new System.Windows.Forms.Button();
			this.b_stock = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.b_date = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.b_name = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.b_author = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.GenreCombo);
			this.groupBox5.Controls.Add(this.b_read);
			this.groupBox5.Controls.Add(this.b_delete);
			this.groupBox5.Controls.Add(this.b_id);
			this.groupBox5.Controls.Add(this.b_save);
			this.groupBox5.Controls.Add(this.label13);
			this.groupBox5.Controls.Add(this.b_update);
			this.groupBox5.Controls.Add(this.b_stock);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.b_date);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.b_name);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.b_author);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Location = new System.Drawing.Point(12, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(695, 176);
			this.groupBox5.TabIndex = 36;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "CREATE/UPDATE BOOK";
			// 
			// GenreCombo
			// 
			this.GenreCombo.FormattingEnabled = true;
			this.GenreCombo.Location = new System.Drawing.Point(468, 72);
			this.GenreCombo.Name = "GenreCombo";
			this.GenreCombo.Size = new System.Drawing.Size(221, 21);
			this.GenreCombo.TabIndex = 35;
			// 
			// b_read
			// 
			this.b_read.Location = new System.Drawing.Point(363, 143);
			this.b_read.Name = "b_read";
			this.b_read.Size = new System.Drawing.Size(326, 23);
			this.b_read.TabIndex = 32;
			this.b_read.Text = "READ/VIEW";
			this.b_read.UseVisualStyleBackColor = true;
			this.b_read.Click += new System.EventHandler(this.b_read_Click);
			// 
			// b_delete
			// 
			this.b_delete.Location = new System.Drawing.Point(363, 114);
			this.b_delete.Name = "b_delete";
			this.b_delete.Size = new System.Drawing.Size(326, 23);
			this.b_delete.TabIndex = 34;
			this.b_delete.Text = "DELETE";
			this.b_delete.UseVisualStyleBackColor = true;
			this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
			// 
			// b_id
			// 
			this.b_id.Location = new System.Drawing.Point(119, 20);
			this.b_id.Name = "b_id";
			this.b_id.Size = new System.Drawing.Size(221, 20);
			this.b_id.TabIndex = 32;
			this.b_id.Text = "Only for update";
			// 
			// b_save
			// 
			this.b_save.Location = new System.Drawing.Point(14, 114);
			this.b_save.Name = "b_save";
			this.b_save.Size = new System.Drawing.Size(326, 23);
			this.b_save.TabIndex = 31;
			this.b_save.Text = "SAVE";
			this.b_save.UseVisualStyleBackColor = true;
			this.b_save.Click += new System.EventHandler(this.b_save_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 23);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(21, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "ID:";
			// 
			// b_update
			// 
			this.b_update.Location = new System.Drawing.Point(14, 143);
			this.b_update.Name = "b_update";
			this.b_update.Size = new System.Drawing.Size(326, 23);
			this.b_update.TabIndex = 33;
			this.b_update.Text = "UPDATE";
			this.b_update.UseVisualStyleBackColor = true;
			this.b_update.Click += new System.EventHandler(this.b_update_Click);
			// 
			// b_stock
			// 
			this.b_stock.Location = new System.Drawing.Point(468, 46);
			this.b_stock.Name = "b_stock";
			this.b_stock.Size = new System.Drawing.Size(221, 20);
			this.b_stock.TabIndex = 25;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(11, 49);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 13);
			this.label16.TabIndex = 14;
			this.label16.Text = "Author:";
			// 
			// b_date
			// 
			this.b_date.Location = new System.Drawing.Point(468, 20);
			this.b_date.Name = "b_date";
			this.b_date.Size = new System.Drawing.Size(221, 20);
			this.b_date.TabIndex = 24;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(11, 75);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(66, 13);
			this.label17.TabIndex = 16;
			this.label17.Text = "Book Name:";
			// 
			// b_name
			// 
			this.b_name.Location = new System.Drawing.Point(119, 72);
			this.b_name.Name = "b_name";
			this.b_name.Size = new System.Drawing.Size(221, 20);
			this.b_name.TabIndex = 23;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(360, 23);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(70, 13);
			this.label18.TabIndex = 17;
			this.label18.Text = "Publish Date:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(360, 49);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(38, 13);
			this.label19.TabIndex = 18;
			this.label19.Text = "Stock:";
			// 
			// b_author
			// 
			this.b_author.Location = new System.Drawing.Point(119, 46);
			this.b_author.Name = "b_author";
			this.b_author.Size = new System.Drawing.Size(221, 20);
			this.b_author.TabIndex = 21;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(360, 77);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(39, 13);
			this.label21.TabIndex = 20;
			this.label21.Text = "Genre:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.dataGridView3);
			this.groupBox6.Location = new System.Drawing.Point(12, 194);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(695, 204);
			this.groupBox6.TabIndex = 37;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "READ/VIEW BOOK";
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(8, 19);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(681, 179);
			this.dataGridView3.TabIndex = 0;
			// 
			// BookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 407);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Name = "BookForm";
			this.Text = "BookForm";
			this.Load += new System.EventHandler(this.BookForm_Load);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox GenreCombo;
		private System.Windows.Forms.Button b_read;
		private System.Windows.Forms.Button b_delete;
		private System.Windows.Forms.TextBox b_id;
		private System.Windows.Forms.Button b_save;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button b_update;
		private System.Windows.Forms.TextBox b_stock;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox b_date;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox b_name;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox b_author;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DataGridView dataGridView3;
	}
}