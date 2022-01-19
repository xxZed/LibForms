using LibForms.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibForms
{
	public partial class MemberForm : Form
	{
		CRUD_Member crud_mem = new CRUD_Member();
		public MemberForm()
		{
			InitializeComponent();
		}
		public void READ_Member()
		{
			dataGridView1.DataSource = null;
			crud_mem.Read_data();
			dataGridView1.DataSource = crud_mem.dt;
		}

		public void UPDATE_Member()
		{
			if ((nametxt.Text != "") && (oibtxt.Text != "") && (addresstxt.Text != "") && (contacttxt.Text != "") && (emailtxt.Text != "") && (dateTimePickerMember.Value != null))
			{
				if (oibtxt.TextLength == 13)
				{
					crud_mem.name = nametxt.Text;
					crud_mem.oib = oibtxt.Text;
					crud_mem.address = addresstxt.Text;
					crud_mem.contact = contacttxt.Text;
					crud_mem.email = emailtxt.Text;
					crud_mem.enrollment = dateTimePickerMember.Value;
					crud_mem.Update_data();
				}
				else
				{
					MessageBox.Show("OIB must be 13 digit number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		public void CREATE_Member()
		{
			if((nametxt.Text != "") && (oibtxt.Text != "") && (addresstxt.Text != "") && (contacttxt.Text != "") && (emailtxt.Text != "") && (dateTimePickerMember.Value != null))
			{
				if (oibtxt.TextLength == 13)
				{
					crud_mem.name = nametxt.Text;
					crud_mem.oib = oibtxt.Text;
					crud_mem.address = addresstxt.Text;
					crud_mem.contact = contacttxt.Text;
					crud_mem.email = emailtxt.Text;
					crud_mem.enrollment = dateTimePickerMember.Value;
					crud_mem.Create_data();
				}
				else
				{
					MessageBox.Show("OIB must be 13 digit number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		public void DELETE_Member()
		{
			crud_mem.memberID = idtxt.Text;
			crud_mem.Delete_data();
		}

		private void MemberForm_Load(object sender, EventArgs e)
		{
			READ_Member();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			CREATE_Member();
			READ_Member();
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			UPDATE_Member();
			READ_Member();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DELETE_Member();
			READ_Member();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			READ_Member();
		}
	}
}
