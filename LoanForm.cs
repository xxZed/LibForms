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
using System.Windows.Forms;

namespace LibForms
{
	public partial class LoanForm : Form
	{
		static string host = "localhost";
		static string db = "library";
		static string port = "3306";
		static string user = "root";
		static string pass = "";
		static string constring = "datasource = " + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";

		MySqlConnection con = new MySqlConnection(constring);

		CRUD_Loan crud_loan = new CRUD_Loan();

		public void READ_Loan()
		{
			dataGridView5.DataSource = null;
			crud_loan.Read_data();
			dataGridView5.DataSource = crud_loan.dt;
		}
		public void CREATE_Loan()
		{
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);

			if ( (l_Ldate.Text != "") && (l_Rdate.Text != ""))
			{
				crud_loan.memberID = memID;
				crud_loan.bookID = bookID;
				crud_loan.employeeID = empID;
				crud_loan.loanDate = l_Ldate.Text;
				crud_loan.returnDate = l_Rdate.Text;
				crud_loan.Create_data();
				
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//UPDATE
		public void UPDATE_Loan()
		{
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);

			if ((l_Ldate.Text != "") && (l_Rdate.Text != ""))
			{
				crud_loan.memberID = memID;
				crud_loan.bookID = bookID;
				crud_loan.employeeID = empID;
				crud_loan.loanDate = l_Ldate.Text;
				crud_loan.returnDate = l_Rdate.Text;
				crud_loan.Update_data();
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void DELETE_Loan()
		{
			crud_loan.loanID = l_id.Text;
			crud_loan.Delete_data();
			
		}

		public LoanForm()
		{
			InitializeComponent();
		}

		private void l_save_Click(object sender, EventArgs e)
		{
			CREATE_Loan();
			READ_Loan();
		}

		private void l_update_Click(object sender, EventArgs e)
		{
			UPDATE_Loan();
			READ_Loan();
		}

		private void l_delete_Click(object sender, EventArgs e)
		{
			DELETE_Loan();
			READ_Loan();
		}

		private void l_read_Click(object sender, EventArgs e)
		{
			READ_Loan();
		}

		private void LoanForm_Load(object sender, EventArgs e)
		{
			READ_Loan();
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
