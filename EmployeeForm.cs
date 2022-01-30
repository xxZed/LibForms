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
	public partial class EmployeeForm : Form
	{
		Employee crud_emp = new Employee();
		EmployeeController employeeController = new EmployeeController();
		DataSet ds = new DataSet();
		public void READ_Employee()
		{
			if (e_id.Text == "")
			{
				ds.Clear();
				dataGridView2.DataSource = null;
				ds = employeeController.Get();
				dataGridView2.DataSource = ds.Tables[0];
			}
			else if(e_id.Text != "Only for update")
			{
				int.TryParse(e_id.Text, out int id);
				ds.Clear();				
				dataGridView2.DataSource = null;
				ds = employeeController.Get(id);
				dataGridView2.DataSource = ds.Tables[0];
			}
			else
			{
				ds.Clear();
				dataGridView2.DataSource = null;
				ds = employeeController.Get();
				dataGridView2.DataSource = ds.Tables[0];
			}		
		}

		public void READ_NOBUTTON()
		{
			ds.Clear();
			dataGridView2.DataSource = null;
			ds = employeeController.Get();
			dataGridView2.DataSource = ds.Tables[0];
		}
		public void CREATE_Employee()
		{
			if ((e_name.Text != "") && (e_oib.Text != "") && (e_address.Text != "") && (e_contact.Text != "") && (e_salary.Text != ""))
			{
				if(e_oib.TextLength == 13)
				{
					crud_emp.name = e_name.Text;
					crud_emp.oib = e_oib.Text;
					crud_emp.address = e_address.Text;
					crud_emp.contact = e_contact.Text;
					crud_emp.salary = e_salary.Text;
					crud_emp.note = e_note.Text;
					employeeController.Post(crud_emp);
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
		public void UPDATE_Employee()
		{		
			if ((e_name.Text != "") && (e_oib.Text != "") && (e_address.Text != "") && (e_contact.Text != "") && (e_salary.Text != ""))
			{
				if (e_id.Text != "Only for update" || e_id.Text != "")
				{
					int.TryParse(e_id.Text, out int id);
					if (e_oib.TextLength == 13)
					{
						crud_emp.name = e_name.Text;
						crud_emp.oib = e_oib.Text;
						crud_emp.address = e_address.Text;
						crud_emp.contact = e_contact.Text;
						crud_emp.salary = e_salary.Text;
						crud_emp.note = e_note.Text;
						employeeController.Put(id, crud_emp);
					}
					else
					{
						MessageBox.Show("OIB must be 13 digit number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		public void DELETE_Employee()
		{
			if (e_id.Text != "Only for update" || e_id.Text != "")
			{
				int.TryParse(e_id.Text, out int id);
				employeeController.Delete(id);
			}
			else
			{
				MessageBox.Show("Enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public EmployeeForm()
		{
			InitializeComponent();
		}

	

		private void EmployeeForm_Load(object sender, EventArgs e)
		{
			READ_NOBUTTON();
		}

		private void eSave_Click(object sender, EventArgs e)
		{
			CREATE_Employee();
			READ_NOBUTTON();
		}

		private void eUpdate_Click(object sender, EventArgs e)
		{
			UPDATE_Employee();
			READ_NOBUTTON();
		}

		private void eRead_Click(object sender, EventArgs e)
		{
			READ_Employee();
			///get id i get
		}

		private void eDelete_Click(object sender, EventArgs e)
		{
			DELETE_Employee();
			READ_NOBUTTON();
		}
	}
}
