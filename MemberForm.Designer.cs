
using System;
using System.Windows.Forms;

namespace LibForms
{
	partial class MemberForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.enrollmenttxt = new System.Windows.Forms.TextBox();
			this.emailtxt = new System.Windows.Forms.TextBox();
			this.contacttxt = new System.Windows.Forms.TextBox();
			this.addresstxt = new System.Windows.Forms.TextBox();
			this.oibtxt = new System.Windows.Forms.TextBox();
			this.nametxt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.idtxt = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.u_enrollment = new System.Windows.Forms.TextBox();
			this.u_contact = new System.Windows.Forms.TextBox();
			this.u_email = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.u_address = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.u_oib = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.u_name = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_save);
			this.groupBox1.Controls.Add(this.enrollmenttxt);
			this.groupBox1.Controls.Add(this.emailtxt);
			this.groupBox1.Controls.Add(this.contacttxt);
			this.groupBox1.Controls.Add(this.addresstxt);
			this.groupBox1.Controls.Add(this.oibtxt);
			this.groupBox1.Controls.Add(this.nametxt);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 268);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CREATE";
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(10, 230);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(232, 23);
			this.btn_save.TabIndex = 14;
			this.btn_save.Text = "SAVE";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// enrollmenttxt
			// 
			this.enrollmenttxt.Location = new System.Drawing.Point(115, 176);
			this.enrollmenttxt.Name = "enrollmenttxt";
			this.enrollmenttxt.Size = new System.Drawing.Size(127, 20);
			this.enrollmenttxt.TabIndex = 13;
			// 
			// emailtxt
			// 
			this.emailtxt.Location = new System.Drawing.Point(115, 150);
			this.emailtxt.Name = "emailtxt";
			this.emailtxt.Size = new System.Drawing.Size(127, 20);
			this.emailtxt.TabIndex = 12;
			// 
			// contacttxt
			// 
			this.contacttxt.Location = new System.Drawing.Point(115, 124);
			this.contacttxt.Name = "contacttxt";
			this.contacttxt.Size = new System.Drawing.Size(127, 20);
			this.contacttxt.TabIndex = 11;
			// 
			// addresstxt
			// 
			this.addresstxt.Location = new System.Drawing.Point(115, 98);
			this.addresstxt.Name = "addresstxt";
			this.addresstxt.Size = new System.Drawing.Size(127, 20);
			this.addresstxt.TabIndex = 10;
			// 
			// oibtxt
			// 
			this.oibtxt.Location = new System.Drawing.Point(115, 72);
			this.oibtxt.Name = "oibtxt";
			this.oibtxt.Size = new System.Drawing.Size(127, 20);
			this.oibtxt.TabIndex = 9;
			// 
			// nametxt
			// 
			this.nametxt.Location = new System.Drawing.Point(115, 46);
			this.nametxt.Name = "nametxt";
			this.nametxt.Size = new System.Drawing.Size(127, 20);
			this.nametxt.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 153);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Email:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Enrollment Date:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contact:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "OIB:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fullname:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(12, 296);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(852, 204);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "READ/VIEW";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(10, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(834, 179);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_delete);
			this.groupBox3.Controls.Add(this.btn_update);
			this.groupBox3.Controls.Add(this.idtxt);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.u_enrollment);
			this.groupBox3.Controls.Add(this.u_contact);
			this.groupBox3.Controls.Add(this.u_email);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.u_address);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.u_oib);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.u_name);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(286, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(351, 268);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "UPDATE";
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(192, 230);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(153, 23);
			this.btn_delete.TabIndex = 30;
			this.btn_delete.Text = "DELETE";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(14, 230);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(153, 23);
			this.btn_update.TabIndex = 15;
			this.btn_update.Text = "UPDATE";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// idtxt
			// 
			this.idtxt.Location = new System.Drawing.Point(119, 19);
			this.idtxt.Name = "idtxt";
			this.idtxt.Size = new System.Drawing.Size(66, 20);
			this.idtxt.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(11, 22);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(21, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "ID:";
			this.label15.Click += new System.EventHandler(this.label15_Click_1);
			// 
			// u_enrollment
			// 
			this.u_enrollment.Location = new System.Drawing.Point(119, 176);
			this.u_enrollment.Name = "u_enrollment";
			this.u_enrollment.Size = new System.Drawing.Size(127, 20);
			this.u_enrollment.TabIndex = 27;
			// 
			// u_contact
			// 
			this.u_contact.Location = new System.Drawing.Point(119, 124);
			this.u_contact.Name = "u_contact";
			this.u_contact.Size = new System.Drawing.Size(127, 20);
			this.u_contact.TabIndex = 25;
			// 
			// u_email
			// 
			this.u_email.Location = new System.Drawing.Point(119, 150);
			this.u_email.Name = "u_email";
			this.u_email.Size = new System.Drawing.Size(127, 20);
			this.u_email.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 49);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Fullname:";
			this.label14.Click += new System.EventHandler(this.label14_Click);
			// 
			// u_address
			// 
			this.u_address.Location = new System.Drawing.Point(119, 98);
			this.u_address.Name = "u_address";
			this.u_address.Size = new System.Drawing.Size(127, 20);
			this.u_address.TabIndex = 24;
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
			// u_oib
			// 
			this.u_oib.Location = new System.Drawing.Point(119, 72);
			this.u_oib.Name = "u_oib";
			this.u_oib.Size = new System.Drawing.Size(127, 20);
			this.u_oib.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 13);
			this.label11.TabIndex = 17;
			this.label11.Text = "Address:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Contact:";
			// 
			// u_name
			// 
			this.u_name.Location = new System.Drawing.Point(119, 46);
			this.u_name.Name = "u_name";
			this.u_name.Size = new System.Drawing.Size(127, 20);
			this.u_name.TabIndex = 21;
			this.u_name.TextChanged += new System.EventHandler(this.u_name_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Enrollment Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Email:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(669, 242);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "RESET READ/VIEW";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MemberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 518);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MemberForm";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox enrollmenttxt;
		private System.Windows.Forms.TextBox emailtxt;
		private System.Windows.Forms.TextBox contacttxt;
		private System.Windows.Forms.TextBox addresstxt;
		private System.Windows.Forms.TextBox oibtxt;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox u_enrollment;
		private System.Windows.Forms.TextBox u_contact;
		private System.Windows.Forms.TextBox u_email;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox u_address;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox u_oib;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox u_name;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox idtxt;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Button button1;
	}
}