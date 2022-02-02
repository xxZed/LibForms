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
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http.Headers;

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
		public HttpClient httpClient = new HttpClient();

		public void READ_NOBUTTON()
		{
			using (HttpClient client = new HttpClient())
			{

				client.BaseAddress = new Uri("https://localhost:44334/");
				var response = client.GetAsync("api/Loan/").Result;
				
				if (response.IsSuccessStatusCode)
				{
					using (HttpContent content = response.Content)
					{
						string jsonS = content.ReadAsStringAsync().Result;

						DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonS, (typeof(DataTable)));
						dataGridView5.DataSource = dataTable;
					}
				}		
			}
		}
		

		public void READ_Loan()
		{
			if (l_id.Text == "")
			{
				READ_NOBUTTON();
			}
			else if (l_id.Text != "Only for update")
			{
				int.TryParse(l_id.Text, out int id);
				using (HttpClient client = new HttpClient())
				{

					client.BaseAddress = new Uri("https://localhost:44334/");
					var response = client.GetAsync("api/Loan/" + id.ToString()).Result;

					if (response.IsSuccessStatusCode)
					{
						using (HttpContent content = response.Content)
						{
							string jsonS = content.ReadAsStringAsync().Result;

							DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonS, (typeof(DataTable)));
							dataGridView5.DataSource = dataTable;
						}
					}
				}
			}
			else
			{
				READ_NOBUTTON();
			}
			
		}
		public void CREATE_Loan()
		{
			httpClient.BaseAddress = new Uri("https://localhost:44334/");
			Loans loans = new Loans();
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);

			if ((dateTimePickerLoan.Value != null) && (dateTimePickerReturn.Value != null))
			{
				loans.MemberID = memID;
				loans.BookID = bookID;
				loans.EmployeeID = empID;
				loans.LoanDate = dateTimePickerLoan.Value;
				loans.ReturnDate = dateTimePickerReturn.Value;

				HttpResponseMessage respones = httpClient.PostAsJsonAsync("/api/Loan", loans).Result;
				respones.EnsureSuccessStatusCode();
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//UPDATE
		public void UPDATE_Loan()
		{
			httpClient.BaseAddress = new Uri("https://localhost:44334/");
			Loans loans = new Loans();
			int memID, bookID, empID;
			bool resultMem = int.TryParse(MemberBox.SelectedValue.ToString(), out memID);
			bool resultBook = int.TryParse(BookBox.SelectedValue.ToString(), out bookID);
			bool resultEmp = int.TryParse(EmployeeBox.SelectedValue.ToString(), out empID);

			if ((dateTimePickerLoan.Value != null) && (dateTimePickerReturn.Value != null))
			{
				loans.MemberID = memID;
				loans.BookID = bookID;
				loans.EmployeeID = empID;
				loans.LoanDate = dateTimePickerLoan.Value;
				loans.ReturnDate = dateTimePickerReturn.Value;

				HttpResponseMessage respones = httpClient.PutAsJsonAsync("/api/Loan", loans).Result;
				respones.EnsureSuccessStatusCode();
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void DELETE_Loan()
		{
			httpClient.BaseAddress = new Uri("https://localhost:44334/");
			if (l_id.Text != "" || l_id.Text != "Only for update")
			{
				int.TryParse(l_id.Text, out int id);
				HttpResponseMessage respones = httpClient.DeleteAsync("/api/Loan/" + id.ToString()).Result;
				respones.EnsureSuccessStatusCode();
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
			using (HttpClient client = new HttpClient())
			{

				client.BaseAddress = new Uri("https://localhost:44334/");
				var response = client.GetAsync("api/Loan/MemberCombo").Result;

				if (response.IsSuccessStatusCode)
				{
					using (HttpContent content = response.Content)
					{
						string jsonS = content.ReadAsStringAsync().Result;

						DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonS, (typeof(DataTable)));
						MemberBox.DisplayMember = "FullName";
						MemberBox.ValueMember = "MemberID";
						MemberBox.DataSource = dataTable;
					}
				}
			}

			//BookBox
			using (HttpClient client = new HttpClient())
			{

				client.BaseAddress = new Uri("https://localhost:44334/");
				var response = client.GetAsync("api/Loan/BookCombo").Result;

				if (response.IsSuccessStatusCode)
				{
					using (HttpContent content = response.Content)
					{
						string jsonS = content.ReadAsStringAsync().Result;

						DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonS, (typeof(DataTable)));
						BookBox.DisplayMember = "BookName";
						BookBox.ValueMember = "BookID";
						BookBox.DataSource = dataTable;
					}
				}
			}

			


			//EmployeeBox
			using (HttpClient client = new HttpClient())
			{

				client.BaseAddress = new Uri("https://localhost:44334/");
				var response = client.GetAsync("api/Loan/EmployeeCombo").Result;

				if (response.IsSuccessStatusCode)
				{
					using (HttpContent content = response.Content)
					{
						string jsonS = content.ReadAsStringAsync().Result;

						DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonS, (typeof(DataTable)));
						EmployeeBox.DisplayMember = "FullName";
						EmployeeBox.ValueMember = "EmployeeID";
						EmployeeBox.DataSource = dataTable;
					}
				}
			}
		}
	}
}
