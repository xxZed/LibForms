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
using LibWepApi.Controllers;
using LibWepApi.Models;

namespace LibForms
{
	public partial class LibForm : Form
	{
		

		static string host = "localhost";
		static string db = "library";
		static string port = "3306";
		static string user = "root";
		static string pass = "";
		static string constring = "datasource = " + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";

		MySqlConnection con = new MySqlConnection(constring);
		BookController bookController = new BookController();
		EmployeeController employeeController = new EmployeeController();
		GenreController genreController = new GenreController();
		LoanController loanController = new LoanController();
		MemberController memberController = new MemberController();

		READ_DATA read = new READ_DATA();

		DataSet ds = new DataSet();
		DataSet ds_m = new DataSet();
		DataSet ds_e = new DataSet();
		DataSet ds_g = new DataSet();
		DataSet ds_b = new DataSet();
		DataSet ds_l = new DataSet();

		public LibForm()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			ds.Clear();
			//Read Grids
			READ_Member();
			READ_Employee();
			READ_Genre();
			READ_Book();
			READ_Loan();
			READ_DATA();
			ds = read.Read_data();
			dataGridView6.DataSource = ds.Tables[0];
		}	
		//READ
		public void READ_DATA()
		{
			ds.Clear();
			dataGridView6.DataSource = null;
			ds = read.Read_data();
			dataGridView6.DataSource = ds.Tables[0];
		}
		public void READ_Member()
		{
			ds_m.Clear();
			dataGridView1.DataSource = null;
			ds_m = memberController.Get();
			dataGridView1.DataSource = ds_m.Tables[0];
		}
		public void READ_Employee()
		{
			ds_e.Clear();
			dataGridView2.DataSource = null;
			ds_e = employeeController.Get();
			dataGridView2.DataSource = ds_e.Tables[0];
		}
		public void READ_Book()
		{
			ds_b.Clear();
			dataGridView3.DataSource = null;
			ds_b = bookController.Get();
			dataGridView3.DataSource = ds_b.Tables[0];
		}
		public void READ_Genre()
		{
			ds_g.Clear();
			dataGridView4.DataSource = null;
			ds_g = genreController.Get();
			dataGridView4.DataSource = ds_g.Tables[0];
		}
		public void READ_Loan()
		{
			ds_l.Clear();
			dataGridView5.DataSource = null;
			ds_l = loanController.Get();
			dataGridView5.DataSource = ds_l.Tables[0];
		}

		private void MemberForm_Load(object sender, EventArgs e)
		{
		}
		private void memberFormOpen_Click(object sender, EventArgs e)
		{
			MemberForm member = new MemberForm();
			member.Show();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			EmployeeForm employee = new EmployeeForm();
			employee.Show();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			GenreForm genre = new GenreForm();
			genre.Show();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			BookForm book = new BookForm();
			book.Show();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			LoanForm loan = new LoanForm();
			loan.Show();
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
									pTable.AddCell(dcell.Value?.ToString());
								}
								pTable.CompleteRow();
							}
							Document doc = new Document(PageSize.A3, 8f, 10f, 10f, 4f);
							using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
							{
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
