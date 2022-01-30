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
using LibWepApi.Controllers;
using LibWepApi.Models;

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
		DataSet ds = new DataSet();
		Book crud_book = new Book();
		BookController BookController = new BookController();
		public void READ_NOBUTTON()
		{
			ds.Clear();
			dataGridView3.DataSource = null;
			ds = BookController.Get();
			dataGridView3.DataSource = ds.Tables[0];
		}
		public void READ_Book()
		{
			if (b_id.Text == "")
			{
				ds.Clear();
				dataGridView3.DataSource = null;
				ds = BookController.Get();
				dataGridView3.DataSource = ds.Tables[0];
			}			
			else if (b_id.Text != "Only for update")
			{
				int.TryParse(b_id.Text, out int id);
				ds.Clear();
				dataGridView3.DataSource = null;
				ds = BookController.Get(id);
				dataGridView3.DataSource = ds.Tables[0];
			}
			else
			{
				ds.Clear();
				dataGridView3.DataSource = null;
				ds = BookController.Get();
				dataGridView3.DataSource = ds.Tables[0];
			}
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
				BookController.Post(crud_book);
			}
			else
			{
				MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void UPDATE_Book()
		{
			bool result = int.TryParse(GenreCombo.SelectedValue.ToString(), out int idGenre);
			int.TryParse(b_stock.ToString(), out int stockInt);
			int.TryParse(b_id.Text, out int id);
			if (b_id.Text != "Only for update" || b_id.Text != "")
			{
				if ((b_author.Text != "") && (b_name.Text != "") && (b_date.Text != ""))
				{
					crud_book.author = b_author.Text;
					crud_book.bookname = b_name.Text;
					crud_book.publishdate = b_date.Text;
					crud_book.stock = stockInt;
					crud_book.genreID = idGenre;
					BookController.Put(id, crud_book);
				}
				else
				{
					MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void DELETE_Book()
		{
			if (b_id.Text != "Only for update" || b_id.Text != "")
			{
				int.TryParse(b_id.Text, out int id);
				BookController.Delete(id);
			}
			else
			{
				MessageBox.Show("Please enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public BookForm()
		{
			InitializeComponent();
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
			READ_NOBUTTON();
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

		private void b_delete_Click(object sender, EventArgs e)
		{
			DELETE_Book();
			READ_NOBUTTON();
		}

		private void b_save_Click(object sender, EventArgs e)
		{
			CREATE_Book();
			READ_NOBUTTON();
		}

		private void b_update_Click(object sender, EventArgs e)
		{
			UPDATE_Book();
			READ_NOBUTTON();
		}

		private void b_read_Click(object sender, EventArgs e)
		{
			READ_Book();
		}
	}
}
