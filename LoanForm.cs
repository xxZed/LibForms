using LibForms.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibWepApi.Controllers;
using LibWepApi.Models;
using System.Windows.Forms;

namespace LibForms
{
	//LOAN done --- API works! 
	//PROJECT LibWebApi mora biti upaljen u novom studiu
	public partial class LoanForm : Form
	{
		static string host = "localhost";
		static string db = "library";
		static string port = "3306";
		static string user = "root";
		static string pass = "";
		static string constring = "datasource = " + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";

		MySqlConnection con = new MySqlConnection(constring);

		public DataSet ds = new DataSet();

		Loan crud_loan = new Loan();
		LoanController loanController = new LoanController();
		public void READ_NOBUTTON()
		{
			ds.Clear();
			dataGridView5.DataSource = null;
			ds = loanController.Get();
			dataGridView5.DataSource = ds.Tables[0];
		}
		public void READ_Loan()
		{
			if (l_id.Text == "")
			{
				ds.Clear();
				dataGridView5.DataSource = null;
				ds = loanController.Get();
				dataGridView5.DataSource = ds.Tables[0];
			}
			else if (l_id.Text != "Only for update")
			{
				int.TryParse(l_id.Text, out int id);
				ds.Clear();
				dataGridView5.DataSource = null;
				ds = loanController.Get(id);
				dataGridView5.DataSource = ds.Tables[0];
			}
			else
			{
				ds.Clear();
				dataGridView5.DataSource = null;
				ds = loanController.Get();
				dataGridView5.DataSource = ds.Tables[0];
			}
			
		}
		public void CREATE_Loan()
		{
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);

			if ((dateTimePickerLoan.Value != null) && (dateTimePickerReturn.Value != null))
			{
				crud_loan.memberID = memID;
				crud_loan.bookID = bookID;
				crud_loan.employeeID = empID;
				crud_loan.loanDate = dateTimePickerLoan.Value;
				crud_loan.returnDate = dateTimePickerReturn.Value;
				loanController.Post(crud_loan);
				
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//UPDATE
		public void UPDATE_Loan()
		{
			int memID, bookID, empID, loanID;	
			if ((dateTimePickerLoan.Value != null) && (dateTimePickerReturn.Value != null))
			{
				int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
				int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
				int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);
				int.TryParse(l_id.Text, out loanID);

				if (l_id.Text != "Only for update" || l_id.Text != "")
				{
					crud_loan.memberID = memID;
					crud_loan.bookID = bookID;
					crud_loan.employeeID = empID;
					crud_loan.loanDate = dateTimePickerLoan.Value;
					crud_loan.returnDate = dateTimePickerReturn.Value;
					loanController.Put(loanID, crud_loan);
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
		public void DELETE_Loan()
		{
			if(l_id.Text != "" || l_id.Text != "Only for update")
			{
				int.TryParse(l_id.Text, out int id);
				loanController.Delete(id);
			}
			else
			{
				MessageBox.Show("Please enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public LoanForm()
		{
			InitializeComponent();
		}

		private void l_save_Click(object sender, EventArgs e)
		{
			CREATE_Loan();
			READ_NOBUTTON();
		}

		private void l_update_Click(object sender, EventArgs e)
		{
			UPDATE_Loan();
			READ_NOBUTTON();
		}

		private void l_delete_Click(object sender, EventArgs e)
		{
			DELETE_Loan();
			READ_NOBUTTON();
		}

		private void l_read_Click(object sender, EventArgs e)
		{
			READ_Loan();
		}

		private void LoanForm_Load(object sender, EventArgs e)
		{
			READ_NOBUTTON();
			//MemberBox
			string memIDQuery = "SELECT * FROM `member`";
			MySqlCommand sqlMem = new MySqlCommand(memIDQuery, con);

			MySqlDataAdapter MemSDR = new MySqlDataAdapter(sqlMem);
			DataTable MemDT = new DataTable();
			MemSDR.Fill(MemDT);

			MemberBox.DisplayMember = "FullName";
			MemberBox.ValueMember = "MemberID";
			MemberBox.DataSource = MemDT;


			//BookBox
			string bookIDQuery = "SELECT * FROM `book`";
			MySqlCommand sqlBook = new MySqlCommand(bookIDQuery, con);

			MySqlDataAdapter BookSDR = new MySqlDataAdapter(sqlBook);
			DataTable BookDT = new DataTable();
			BookSDR.Fill(BookDT);

			BookBox.DisplayMember = "BookName";
			BookBox.ValueMember = "BookID";
			BookBox.DataSource = BookDT;


			//EmployeeBox
			string employeeIDQuery = "SELECT * FROM `employee`";
			MySqlCommand sqlEmployee = new MySqlCommand(employeeIDQuery, con);

			MySqlDataAdapter EmployeeSDR = new MySqlDataAdapter(sqlEmployee);
			DataTable EmployeeDT = new DataTable();
			EmployeeSDR.Fill(EmployeeDT);

			EmployeeBox.DisplayMember = "FullName";
			EmployeeBox.ValueMember = "EmployeeID";
			EmployeeBox.DataSource = EmployeeDT;
		}
	}
}
