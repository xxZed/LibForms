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
	public partial class BookForm : Form
	{
		static string host = "localhost";
		static string db = "library";
		static string port = "3306";
		static string user = "root";
		static string pass = "";
		static string constring = "datasource = " + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";
		
		MySqlConnection con = new MySqlConnection(constring);

		CRUD_Book crud_book = new CRUD_Book();

		public void READ_Book()
		{
			dataGridView3.DataSource = null;
			crud_book.Read_data();
			dataGridView3.DataSource = crud_book.dt;
		}

		public void CREATE_Book()
		{
			int id;
			bool result = int.TryParse(GenreCombo.SelectedValue.ToString(), out id);
			int.TryParse(b_stock.ToString(), out int stockInt);
			if((b_author.Text != "") && (b_name.Text != "") && (b_date.Text != ""))
			{
				crud_book.author = b_author.Text;
				crud_book.bookname = b_name.Text;
				crud_book.publishdate = b_date.Text;
				crud_book.stock = stockInt;
				crud_book.genreID = id;
				crud_book.Create_data();
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void UPDATE_Book()
		{
			int id;
			bool result = int.TryParse(GenreCombo.SelectedValue.ToString(), out id);
			int.TryParse(b_stock.ToString(), out int stockInt);
			if ((b_author.Text != "") && (b_name.Text != "") && (b_date.Text != ""))
			{
				crud_book.author = b_author.Text;
				crud_book.bookname = b_name.Text;
				crud_book.publishdate = b_date.Text;
				crud_book.stock = stockInt;
				crud_book.genreID = id;
				crud_book.Update_data();
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public BookForm()
		{
			InitializeComponent();
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
			READ_Book();
			string genreIDQuery = "SELECT * FROM `genre`";
			MySqlCommand sqlCommand = new MySqlCommand(genreIDQuery, con);
			con.Open();

			MySqlDataAdapter sdr = new MySqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable();
			sdr.Fill(dt);

			GenreCombo.DisplayMember = "Genre";
			GenreCombo.ValueMember = "GenreID";
			GenreCombo.DataSource = dt;
		}
	}
}
