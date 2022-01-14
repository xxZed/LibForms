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
			//Read Grids
			READ_Member();
			READ_Employee();
			READ_Genre();
			READ_Book();
			READ_Loan();
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

		
		private void MemberForm_Load(object sender, EventArgs e)
		{

		}


		private void memberFormOpen_Click(object sender, EventArgs e)
		{
			MemberForm member = new MemberForm();
			member.Show();
			READ_Member();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			EmployeeForm employee = new EmployeeForm();
			employee.Show();
			READ_Employee();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GenreForm genre = new GenreForm();
			genre.Show();
			READ_Genre();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			BookForm book = new BookForm();
			book.Show();
			READ_Book();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			LoanForm loan = new LoanForm();
			loan.Show();
			READ_Loan();
		}
	}
}
