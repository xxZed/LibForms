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
using LibWepApi.Controllers;
using LibWepApi.Models;

namespace LibForms
{
	public partial class MemberForm : Form
	{
		Member crud_mem = new Member();
		public DataSet ds = new DataSet();

		MemberController memberController = new MemberController();
		public MemberForm()
		{
			InitializeComponent();
		}
		public void READ_NOBUTTON()
		{
			ds.Clear();
			dataGridView1.DataSource = null;
			ds = memberController.Get();
			dataGridView1.DataSource = ds.Tables[0];
		}
		public void READ_Member()
		{
			if (idtxt.Text == "")
			{
				ds.Clear();
				dataGridView1.DataSource = null;
				ds = memberController.Get();
				dataGridView1.DataSource = ds.Tables[0];
			}
			else if (idtxt.Text != "Only for update")
			{
				int.TryParse(idtxt.Text, out int id);
				ds.Clear();
				dataGridView1.DataSource = null;
				ds = memberController.Get(id);
				dataGridView1.DataSource = ds.Tables[0];
			}
			else
			{
				ds.Clear();
				dataGridView1.DataSource = null;
				ds = memberController.Get();
				dataGridView1.DataSource = ds.Tables[0];
			}
		}

		public void UPDATE_Member()
		{
			if ((nametxt.Text != "") && (oibtxt.Text != "") && (addresstxt.Text != "") && (contacttxt.Text != "") && (emailtxt.Text != "") && (dateTimePickerMember.Value != null))
			{
				if (idtxt.Text != "Only for update" || idtxt.Text != "")
				{
					int.TryParse(idtxt.Text, out int id);
					if (oibtxt.TextLength == 13)
					{						
						crud_mem.name = nametxt.Text;
						crud_mem.oib = oibtxt.Text;
						crud_mem.address = addresstxt.Text;
						crud_mem.contact = contacttxt.Text;
						crud_mem.email = emailtxt.Text;
						crud_mem.enrollment = dateTimePickerMember.Value;
						memberController.Put(id, crud_mem);
					}
					else
					{
						MessageBox.Show("OIB must be 13 digit number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Please enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					memberController.Post(crud_mem);
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
			if (idtxt.Text != "" || idtxt.Text != "Only for update")
			{
				int.TryParse(idtxt.Text, out int id);
				memberController.Delete(id);
			}
			else
			{
				MessageBox.Show("Please enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}

		private void MemberForm_Load(object sender, EventArgs e)
		{
			READ_NOBUTTON();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			CREATE_Member();
			READ_NOBUTTON();
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			UPDATE_Member();
			READ_NOBUTTON();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DELETE_Member();
			READ_NOBUTTON();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			READ_Member();
		}
	}
}
