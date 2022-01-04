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
	public partial class LibForm : Form
	{
		CRUD_Member crud_mem = new CRUD_Member();
		CRUD_Employee crud_emp = new CRUD_Employee();
		CRUD_Book crud_book = new CRUD_Book();
		CRUD_Genre crud_genre = new CRUD_Genre();
		CRUD_Loan crud_loan = new CRUD_Loan();

		
		static string host = "localhost";
		static string db = "library";
		static string port = "3306";
		static string user = "root";
		static string pass = "";
		static string constring = "datasource = " + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";

		MySqlConnection con = new MySqlConnection(constring);

		public LibForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//GenreBox
			string genreIDQuery = "SELECT * FROM `genre`";
			MySqlCommand sqlCommand = new MySqlCommand(genreIDQuery, con);
			con.Open();

			MySqlDataAdapter sdr = new MySqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable();
			sdr.Fill(dt);

			GenreCombo.DisplayMember = "Genre";
			GenreCombo.ValueMember = "GenreID";
			GenreCombo.DataSource = dt;



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


		//READ

		public void READ_Member()
		{
			dataGridView1.DataSource = null;
			crud_mem.Read_data();
			dataGridView1.DataSource = crud_mem.dt;
		}
		public void READ_Employee()
		{
			dataGridView2.DataSource = null;
			crud_emp.Read_data();
			dataGridView2.DataSource = crud_emp.dt;
		}
		public void READ_Book()
		{
			dataGridView3.DataSource = null;
			crud_book.Read_data();
			dataGridView3.DataSource = crud_book.dt;
		}
		public void READ_Genre()
		{
			dataGridView4.DataSource = null;
			crud_genre.Read_data();
			dataGridView4.DataSource = crud_genre.dt;
		}
		public void READ_Loan()
		{
			dataGridView5.DataSource = null;
			crud_loan.Read_data();
			dataGridView5.DataSource = crud_loan.dt;
		}

		//CREATE

		public void CREATE_Member()
		{
			crud_mem.name = nametxt.Text;
			crud_mem.oib = oibtxt.Text;
			crud_mem.address = addresstxt.Text;
			crud_mem.contact = contacttxt.Text;
			crud_mem.email = emailtxt.Text;
			crud_mem.enrollment = enrollmenttxt.Text;
			crud_mem.Create_data();
		}
		public void CREATE_Employee()
		{
			crud_emp.name = e_name.Text;
			crud_emp.oib = e_oib.Text;
			crud_emp.address = e_address.Text;
			crud_emp.contact = e_contact.Text;
			crud_emp.salary = e_salary.Text;
			crud_emp.note = e_note.Text;
			crud_emp.Create_data();
		}
		public void CREATE_Book()
		{
			int id;
			bool result = int.TryParse(GenreCombo.SelectedValue.ToString(), out id);
			crud_book.author = b_author.Text;
			crud_book.bookname = b_name.Text;
			crud_book.publishdate = b_date.Text;
			crud_book.stock = b_stock.Text;
			crud_book.genreID = id.ToString();
			crud_book.Create_data();
		}
		public void CREATE_Genre()
		{
			crud_genre.name = g_name.Text;
			crud_genre.Create_data();
		}
		public void CREATE_Loan()
		{
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);
			crud_loan.memberID = memID.ToString();
			crud_loan.bookID = bookID.ToString();
			crud_loan.employeeID = empID.ToString();
			crud_loan.loanDate = l_Ldate.Text;
			crud_loan.returnDate = l_Rdate.Text;
			crud_loan.Create_data();
		}

		//UPDATE

		public void UPDATE_Member()
		{
			crud_mem.memberID = idtxt.Text;
			crud_mem.name = nametxt.Text;
			crud_mem.oib = oibtxt.Text;
			crud_mem.address = addresstxt.Text;
			crud_mem.contact = contacttxt.Text;
			crud_mem.email = emailtxt.Text;
			crud_mem.enrollment = enrollmenttxt.Text;
			crud_mem.Update_data();
		}

		public void UPDATE_Employee()
		{
			crud_emp.employeeID = e_id.Text;
			crud_emp.name = e_name.Text;
			crud_emp.oib = e_oib.Text;
			crud_emp.address = e_address.Text;
			crud_emp.contact = e_contact.Text;
			crud_emp.salary = e_salary.Text;
			crud_emp.note = e_note.Text;
			crud_emp.Update_data();
		}

		public void UPDATE_Book()
		{
			int id;
			bool result = int.TryParse(GenreCombo.SelectedValue.ToString(), out id);
			crud_book.bookID = b_id.Text;
			crud_book.author = b_author.Text;
			crud_book.bookname = b_name.Text;
			crud_book.publishdate = b_date.Text;
			crud_book.stock = b_stock.Text;
			crud_book.genreID = id.ToString();
			crud_book.Update_data();
		}

		public void UPDATE_Genre()
		{
			crud_genre.name = g_name.Text;
			crud_genre.genreID = g_id.Text;
			crud_genre.Update_data();
		}
		public void UPDATE_Loan()
		{
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);
			crud_loan.memberID = memID.ToString();
			crud_loan.bookID = bookID.ToString();
			crud_loan.employeeID = empID.ToString();
			crud_loan.loanDate = l_Ldate.Text;
			crud_loan.returnDate = l_Rdate.Text;
			crud_loan.loanID = l_id.Text;
			crud_loan.Update_data();
		}


		//DELETE

		public void DELETE_Member()
		{
			crud_mem.memberID = idtxt.Text;
			crud_mem.Delete_data();
		}

		public void DELETE_Employee()
		{
			crud_emp.employeeID = e_id.Text;
			crud_emp.Delete_data();
		}

		public void DELETE_Book()
		{
			crud_book.bookID = b_id.Text;
			crud_book.Delete_data();
		}
		public void DELETE_Genre()
		{
			crud_genre.genreID = g_id.Text;
			crud_genre.Delete_data();
		}
		public void DELETE_Loan()
		{
			crud_loan.loanID = l_id.Text;
			crud_loan.Delete_data();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					e_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_oib.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_address.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_contact.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_salary.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_note.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			READ_Member();
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					e_name.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_oib.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_address.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_contact.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_salary.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_note.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			CREATE_Employee();
			READ_Employee();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			UPDATE_Employee();
			READ_Employee();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DELETE_Employee();
			READ_Employee();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			READ_Employee();
		}


		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					e_name.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_oib.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_address.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_contact.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_salary.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_note.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}
		}

		private void b_save_Click(object sender, EventArgs e)
		{
			CREATE_Book();
			READ_Book();
		}

		private void b_update_Click(object sender, EventArgs e)
		{
			UPDATE_Book();
			READ_Book();
		}

		private void b_delete_Click(object sender, EventArgs e)
		{
			DELETE_Book();
			READ_Book();
		}

		private void b_read_Click(object sender, EventArgs e)
		{
			READ_Book();
		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					e_name.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_oib.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_address.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_contact.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_salary.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_note.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}
		}

		private void g_save_Click(object sender, EventArgs e)
		{
			CREATE_Genre();
			READ_Genre();
		}

		private void g_update_Click(object sender, EventArgs e)
		{
			UPDATE_Genre();
			READ_Genre();
		}

		private void g_delete_Click(object sender, EventArgs e)
		{
			DELETE_Genre();
			READ_Genre();
		}

		private void g_read_Click(object sender, EventArgs e)
		{
			READ_Genre();
		}

		private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;
			try
			{
				if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					e_name.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_oib.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_address.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_contact.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_salary.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
					e_note.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Don't Click The Header!");
			}
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
	}
}
