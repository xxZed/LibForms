using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LibForms
{
	public partial class BookForm : Form
	{
		public BookForm()
		{ 
			InitializeComponent();
		}

		private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bookBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.libraryDataSet);

		}

		private void GetAllBooks()
		{		}

		private void Form1_Load(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'libraryDataSet.Genre' table. You can move, or remove it, as needed.
			this.genreTableAdapter.Fill(this.libraryDataSet.Genre);
			// TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
			this.bookTableAdapter.Fill(this.libraryDataSet.Book);

		}

		private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void genreLabel_Click(object sender, EventArgs e)
		{

		}

		private void bookDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void book_idLabel_Click(object sender, EventArgs e)
		{

		}

		private void genreBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void genre_idTextBox_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void bookDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void stockTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
