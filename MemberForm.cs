using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibForms.Class;
using MySql.Data.MySqlClient;

namespace LibForms
{
	public partial class MemberForm : Form
	{
		CRUD crud = new CRUD();
		public MemberForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void label15_Click_1(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void u_name_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			Create();
			Read();
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			UPDATE();
			Read();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			Delete();
			Read();
		}

		public void Read()
		{
			dataGridView1.DataSource = null;
			crud.Read_data();
			dataGridView1.DataSource = crud.dt;
		}

		public void Create()
		{
			crud.name = nametxt.Text;
			crud.oib = oibtxt.Text;
			crud.address = addresstxt.Text;
			crud.contact = contacttxt.Text;
			crud.email = emailtxt.Text;
			crud.enrollment = enrollmenttxt.Text;
			crud.Create_data();
		}

		public void UPDATE()
		{
			crud.memberID = idtxt.Text;
			crud.name = u_name.Text;
			crud.oib = u_oib.Text;
			crud.address = u_address.Text;
			crud.contact = u_contact.Text;
			crud.email = u_email.Text;
			crud.enrollment = u_enrollment.Text;
			crud.Update_data();
		}

		public void Delete()
		{
			crud.memberID = idtxt.Text;
			crud.Delete_data();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					u_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					u_oib.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					u_address.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					u_contact.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					u_email.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					u_enrollment.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Read();
		}
	}
}
