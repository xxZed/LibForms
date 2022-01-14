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
	public partial class EmployeeForm : Form
	{
		CRUD_Employee crud_emp = new CRUD_Employee();

		public void READ_Employee()
		{

			dataGridView2.DataSource = null;
			crud_emp.Read_data();
			dataGridView2.DataSource = crud_emp.dt;
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
					crud_emp.Create_data();
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
				if (e_oib.TextLength == 13)
				{
					crud_emp.name = e_name.Text;
					crud_emp.oib = e_oib.Text;
					crud_emp.address = e_address.Text;
					crud_emp.contact = e_contact.Text;
					crud_emp.salary = e_salary.Text;
					crud_emp.note = e_note.Text;
					crud_emp.Update_data();
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

		public void DELETE_Employee()
		{
			crud_emp.employeeID = e_id.Text;
			crud_emp.Delete_data();
		}
		public EmployeeForm()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void EmployeeForm_Load(object sender, EventArgs e)
		{
			READ_Employee();
		}
	}
}
