using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LibForms.Class;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace LibForms
{
	public partial class LibForm : Form
	{
		CRUD_Member crud_mem = new CRUD_Member();
		CRUD_Employee crud_emp = new CRUD_Employee();
		CRUD_Book crud_book = new CRUD_Book();
		CRUD_Genre crud_genre = new CRUD_Genre();
		CRUD_Loan crud_loan = new CRUD_Loan();
		READ_DATA read = new READ_DATA();

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
			READ_DATA();
			dataGridView6.DataSource = read.dt;
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
		public void READ_DATA()
		{
			dataGridView6.DataSource = null;
			read.Read_data();
			dataGridView6.DataSource = read.dt;
		}
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

		private void button5_Click(object sender, EventArgs e)
		{
			READ_Book();
			READ_Employee();
			READ_Genre();
			READ_Loan();
			READ_Member();
			READ_DATA();
		}
		
		private void button6_Click(object sender, EventArgs e)
		{
			if(dataGridView6.Rows.Count > 0)
			{
				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "PDF (*.pdf) | *.pdf";
				save.FileName = "Result";
				bool ErrorMessage = false;
				if (save.ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(save.FileName))
					{
						try
						{
							File.Delete(save.FileName);
						}
						catch (Exception ex)
						{
							ErrorMessage = true;
							MessageBox.Show("Unable to create pdf" + ex.Message);
						}
						
					}
					if (!ErrorMessage)
					{
						try
						{
							PdfPTable pTable = new PdfPTable(dataGridView6.Columns.Count);
							pTable.DefaultCell.Padding = 2;
							pTable.WidthPercentage = 100;
							pTable.HorizontalAlignment = Element.ALIGN_LEFT;
							foreach (DataGridViewColumn col in dataGridView6.Columns)
							{
								PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
								pTable.AddCell(pCell);
							}
							foreach (DataGridViewRow viewRow in dataGridView6.Rows)
							{
								foreach (DataGridViewCell dcell in viewRow.Cells)
								{
									if (dcell.Value != null)
									{
										pTable.AddCell(dcell.Value.ToString());
									}
								}
							}
							using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
							{
								Document doc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
								doc.Open();
								doc.Add(pTable);
								doc.Close();
								fs.Close();
							}
							MessageBox.Show("Exported!", "info");
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error while exporting Data" + ex.Message);

						}
					}
					else
					{
						MessageBox.Show("No Record Found!");
					}
				}
			}
		}

		private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView6.DataSource = read.dt;
		}
	}
}
