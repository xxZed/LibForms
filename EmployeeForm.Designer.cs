
namespace LibForms
{
	partial class EmployeeForm
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.eRead = new System.Windows.Forms.Button();
			this.eDelete = new System.Windows.Forms.Button();
			this.e_id = new System.Windows.Forms.TextBox();
			this.eSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.eUpdate = new System.Windows.Forms.Button();
			this.e_note = new System.Windows.Forms.TextBox();
			this.e_contact = new System.Windows.Forms.TextBox();
			this.e_salary = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.e_address = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.e_oib = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.e_name = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.eRead);
			this.groupBox3.Controls.Add(this.eDelete);
			this.groupBox3.Controls.Add(this.e_id);
			this.groupBox3.Controls.Add(this.eSave);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.eUpdate);
			this.groupBox3.Controls.Add(this.e_note);
			this.groupBox3.Controls.Add(this.e_contact);
			this.groupBox3.Controls.Add(this.e_salary);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.e_address);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.e_oib);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.e_name);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(776, 139);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "CREATE/UPDATE EMPLOYEE";
			// 
			// eRead
			// 
			this.eRead.Location = new System.Drawing.Point(574, 72);
			this.eRead.Name = "eRead";
			this.eRead.Size = new System.Drawing.Size(196, 23);
			this.eRead.TabIndex = 32;
			this.eRead.Text = "READ/VIEW";
			this.eRead.UseVisualStyleBackColor = true;
			this.eRead.Click += new System.EventHandler(this.eRead_Click);
			// 
			// eDelete
			// 
			this.eDelete.Location = new System.Drawing.Point(574, 101);
			this.eDelete.Name = "eDelete";
			this.eDelete.Size = new System.Drawing.Size(196, 23);
			this.eDelete.TabIndex = 34;
			this.eDelete.Text = "DELETE";
			this.eDelete.UseVisualStyleBackColor = true;
			this.eDelete.Click += new System.EventHandler(this.eDelete_Click);
			// 
			// e_id
			// 
			this.e_id.Location = new System.Drawing.Point(119, 20);
			this.e_id.Name = "e_id";
			this.e_id.Size = new System.Drawing.Size(127, 20);
			this.e_id.TabIndex = 32;
			this.e_id.Text = "Only for update";
			// 
			// eSave
			// 
			this.eSave.Location = new System.Drawing.Point(574, 13);
			this.eSave.Name = "eSave";
			this.eSave.Size = new System.Drawing.Size(196, 23);
			this.eSave.TabIndex = 31;
			this.eSave.Text = "SAVE";
			this.eSave.UseVisualStyleBackColor = true;
			this.eSave.Click += new System.EventHandler(this.eSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "ID:";
			// 
			// eUpdate
			// 
			this.eUpdate.Location = new System.Drawing.Point(574, 43);
			this.eUpdate.Name = "eUpdate";
			this.eUpdate.Size = new System.Drawing.Size(196, 23);
			this.eUpdate.TabIndex = 33;
			this.eUpdate.Text = "UPDATE";
			this.eUpdate.UseVisualStyleBackColor = true;
			this.eUpdate.Click += new System.EventHandler(this.eUpdate_Click);
			// 
			// e_note
			// 
			this.e_note.Location = new System.Drawing.Point(119, 104);
			this.e_note.Name = "e_note";
			this.e_note.Size = new System.Drawing.Size(389, 20);
			this.e_note.TabIndex = 27;
			// 
			// e_contact
			// 
			this.e_contact.Location = new System.Drawing.Point(381, 46);
			this.e_contact.Name = "e_contact";
			this.e_contact.Size = new System.Drawing.Size(127, 20);
			this.e_contact.TabIndex = 25;
			// 
			// e_salary
			// 
			this.e_salary.Location = new System.Drawing.Point(381, 72);
			this.e_salary.Name = "e_salary";
			this.e_salary.Size = new System.Drawing.Size(127, 20);
			this.e_salary.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 49);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Fullname:";
			// 
			// e_address
			// 
			this.e_address.Location = new System.Drawing.Point(381, 20);
			this.e_address.Name = "e_address";
			this.e_address.Size = new System.Drawing.Size(127, 20);
			this.e_address.TabIndex = 24;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(11, 75);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(28, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "OIB:";
			// 
			// e_oib
			// 
			this.e_oib.Location = new System.Drawing.Point(119, 72);
			this.e_oib.Name = "e_oib";
			this.e_oib.Size = new System.Drawing.Size(127, 20);
			this.e_oib.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(273, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 13);
			this.label11.TabIndex = 17;
			this.label11.Text = "Address:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(273, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Contact:";
			// 
			// e_name
			// 
			this.e_name.Location = new System.Drawing.Point(119, 46);
			this.e_name.Name = "e_name";
			this.e_name.Size = new System.Drawing.Size(127, 20);
			this.e_name.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 107);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Note: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(273, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Salary:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView2);
			this.groupBox4.Location = new System.Drawing.Point(12, 157);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(776, 204);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "READ/VIEW EMPLOYEE";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(8, 19);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(762, 179);
			this.dataGridView2.TabIndex = 0;
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 369);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Name = "EmployeeForm";
			this.Text = "EmployeeForm";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button eRead;
		private System.Windows.Forms.Button eDelete;
		private System.Windows.Forms.TextBox e_id;
		private System.Windows.Forms.Button eSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button eUpdate;
		private System.Windows.Forms.TextBox e_note;
		private System.Windows.Forms.TextBox e_contact;
		private System.Windows.Forms.TextBox e_salary;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox e_address;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox e_oib;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox e_name;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridView2;
	}
}