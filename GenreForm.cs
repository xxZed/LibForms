using LibForms.Class;
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
	public partial class GenreForm : Form
	{
		CRUD_Genre crud_genre = new CRUD_Genre();

		public void READ_Genre()
		{
			dataGridView4.DataSource = null;
			crud_genre.Read_data();
			dataGridView4.DataSource = crud_genre.dt;
		}
		public void CREATE_Genre()
		{
			if (g_name.Text != "")
			{
				crud_genre.name = g_name.Text;
				crud_genre.Create_data();
			}
			else
			{
				MessageBox.Show("Genre name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public void UPDATE_Genre()
		{
			if (g_name.Text != "")
			{
				crud_genre.name = g_name.Text;
				crud_genre.Create_data();
			}
			else
			{
				MessageBox.Show("Genre name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}
		public void DELETE_Genre()
		{
			crud_genre.genreID = g_id.Text;
			crud_genre.Delete_data();
		}
		public GenreForm()
		{
			InitializeComponent();
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

		private void GenreForm_Load(object sender, EventArgs e)
		{
			READ_Genre();
		}
	}
}
