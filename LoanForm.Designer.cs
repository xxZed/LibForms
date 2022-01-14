
namespace LibForms
{
	partial class LoanForm
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
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.EmployeeBox = new System.Windows.Forms.ComboBox();
			this.BookBox = new System.Windows.Forms.ComboBox();
			this.MemberBox = new System.Windows.Forms.ComboBox();
			this.l_Rdate = new System.Windows.Forms.TextBox();
			this.l_read = new System.Windows.Forms.Button();
			this.l_delete = new System.Windows.Forms.Button();
			this.l_id = new System.Windows.Forms.TextBox();
			this.l_save = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.l_update = new System.Windows.Forms.Button();
			this.l_Ldate = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.dataGridView5 = new System.Windows.Forms.DataGridView();
			this.groupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.EmployeeBox);
			this.groupBox9.Controls.Add(this.BookBox);
			this.groupBox9.Controls.Add(this.MemberBox);
			this.groupBox9.Controls.Add(this.l_Rdate);
			this.groupBox9.Controls.Add(this.l_read);
			this.groupBox9.Controls.Add(this.l_delete);
			this.groupBox9.Controls.Add(this.l_id);
			this.groupBox9.Controls.Add(this.l_save);
			this.groupBox9.Controls.Add(this.label23);
			this.groupBox9.Controls.Add(this.l_update);
			this.groupBox9.Controls.Add(this.l_Ldate);
			this.groupBox9.Controls.Add(this.label24);
			this.groupBox9.Controls.Add(this.label25);
			this.groupBox9.Controls.Add(this.label26);
			this.groupBox9.Controls.Add(this.label27);
			this.groupBox9.Controls.Add(this.label28);
			this.groupBox9.Location = new System.Drawing.Point(12, 12);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(574, 172);
			this.groupBox9.TabIndex = 37;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "CREATE/UPDATE LOAN";
			// 
			// EmployeeBox
			// 
			this.EmployeeBox.FormattingEnabled = true;
			this.EmployeeBox.Location = new System.Drawing.Point(407, 74);
			this.EmployeeBox.Name = "EmployeeBox";
			this.EmployeeBox.Size = new System.Drawing.Size(157, 21);
			this.EmployeeBox.TabIndex = 38;
			// 
			// BookBox
			// 
			this.BookBox.FormattingEnabled = true;
			this.BookBox.Location = new System.Drawing.Point(407, 47);
			this.BookBox.Name = "BookBox";
			this.BookBox.Size = new System.Drawing.Size(157, 21);
			this.BookBox.TabIndex = 37;
			// 
			// MemberBox
			// 
			this.MemberBox.FormattingEnabled = true;
			this.MemberBox.Location = new System.Drawing.Point(407, 20);
			this.MemberBox.Name = "MemberBox";
			this.MemberBox.Size = new System.Drawing.Size(157, 21);
			this.MemberBox.TabIndex = 36;
			// 
			// l_Rdate
			// 
			this.l_Rdate.Location = new System.Drawing.Point(119, 72);
			this.l_Rdate.Name = "l_Rdate";
			this.l_Rdate.Size = new System.Drawing.Size(157, 20);
			this.l_Rdate.TabIndex = 35;
			// 
			// l_read
			// 
			this.l_read.Location = new System.Drawing.Point(302, 136);
			this.l_read.Name = "l_read";
			this.l_read.Size = new System.Drawing.Size(262, 23);
			this.l_read.TabIndex = 32;
			this.l_read.Text = "READ/VIEW";
			this.l_read.UseVisualStyleBackColor = true;
			this.l_read.Click += new System.EventHandler(this.l_read_Click);
			// 
			// l_delete
			// 
			this.l_delete.Location = new System.Drawing.Point(302, 107);
			this.l_delete.Name = "l_delete";
			this.l_delete.Size = new System.Drawing.Size(262, 23);
			this.l_delete.TabIndex = 34;
			this.l_delete.Text = "DELETE";
			this.l_delete.UseVisualStyleBackColor = true;
			this.l_delete.Click += new System.EventHandler(this.l_delete_Click);
			// 
			// l_id
			// 
			this.l_id.Location = new System.Drawing.Point(119, 20);
			this.l_id.Name = "l_id";
			this.l_id.Size = new System.Drawing.Size(157, 20);
			this.l_id.TabIndex = 32;
			this.l_id.Text = "Only for update";
			// 
			// l_save
			// 
			this.l_save.Location = new System.Drawing.Point(14, 107);
			this.l_save.Name = "l_save";
			this.l_save.Size = new System.Drawing.Size(262, 23);
			this.l_save.TabIndex = 31;
			this.l_save.Text = "SAVE";
			this.l_save.UseVisualStyleBackColor = true;
			this.l_save.Click += new System.EventHandler(this.l_save_Click);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(11, 23);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(21, 13);
			this.label23.TabIndex = 31;
			this.label23.Text = "ID:";
			// 
			// l_update
			// 
			this.l_update.Location = new System.Drawing.Point(14, 136);
			this.l_update.Name = "l_update";
			this.l_update.Size = new System.Drawing.Size(262, 23);
			this.l_update.TabIndex = 33;
			this.l_update.Text = "UPDATE";
			this.l_update.UseVisualStyleBackColor = true;
			this.l_update.Click += new System.EventHandler(this.l_update_Click);
			// 
			// l_Ldate
			// 
			this.l_Ldate.Location = new System.Drawing.Point(119, 46);
			this.l_Ldate.Name = "l_Ldate";
			this.l_Ldate.Size = new System.Drawing.Size(157, 20);
			this.l_Ldate.TabIndex = 25;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(299, 23);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(48, 13);
			this.label24.TabIndex = 14;
			this.label24.Text = "Member:";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(299, 49);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(35, 13);
			this.label25.TabIndex = 16;
			this.label25.Text = "Book:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(299, 75);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 13);
			this.label26.TabIndex = 17;
			this.label26.Text = "Employee:";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(11, 49);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(60, 13);
			this.label27.TabIndex = 18;
			this.label27.Text = "Loan Date:";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(11, 75);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(68, 13);
			this.label28.TabIndex = 20;
			this.label28.Text = "Return Date:";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.dataGridView5);
			this.groupBox10.Location = new System.Drawing.Point(12, 190);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(574, 293);
			this.groupBox10.TabIndex = 38;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "READ/VIEW LOAN";
			// 
			// dataGridView5
			// 
			this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView5.Location = new System.Drawing.Point(8, 19);
			this.dataGridView5.Name = "dataGridView5";
			this.dataGridView5.Size = new System.Drawing.Size(556, 266);
			this.dataGridView5.TabIndex = 0;
			// 
			// LoanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 487);
			this.Controls.Add(this.groupBox10);
			this.Controls.Add(this.groupBox9);
			this.Name = "LoanForm";
			this.Text = "LoanForm";
			this.Load += new System.EventHandler(this.LoanForm_Load);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.ComboBox EmployeeBox;
		private System.Windows.Forms.ComboBox BookBox;
		private System.Windows.Forms.ComboBox MemberBox;
		private System.Windows.Forms.TextBox l_Rdate;
		private System.Windows.Forms.Button l_read;
		private System.Windows.Forms.Button l_delete;
		private System.Windows.Forms.TextBox l_id;
		private System.Windows.Forms.Button l_save;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Button l_update;
		private System.Windows.Forms.TextBox l_Ldate;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.DataGridView dataGridView5;
	}
}