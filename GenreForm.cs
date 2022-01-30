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
using LibWepApi.Controllers;
using LibWepApi.Models;

namespace LibForms
{
	public partial class GenreForm : Form
	{
		Genre crud_genre = new Genre();
		GenreController GenreController = new GenreController();
		DataSet ds = new DataSet();
		public void READ_NOBUTTON()
		{
			ds.Clear();
			dataGridView4.DataSource = null;
			ds = GenreController.Get();
			dataGridView4.DataSource = ds.Tables[0];
		}
		public void READ_Genre()
		{
			if(g_id.Text == "")
			{
				ds.Clear();
				dataGridView4.DataSource = null;
				ds = GenreController.Get();
				dataGridView4.DataSource = ds.Tables[0];
			}
			else if(g_id.Text != "Only for update")
			{				
				int.TryParse(g_id.Text, out int id);
				ds.Clear();
				dataGridView4.DataSource = null;
				ds = GenreController.Get(id);
				dataGridView4.DataSource = ds.Tables[0];
			}
			else
			{
				ds.Clear();
				dataGridView4.DataSource = null;
				ds = GenreController.Get();
				dataGridView4.DataSource = ds.Tables[0];
			}
			
		}
		public void CREATE_Genre()
		{
			if (g_name.Text != "")
			{
				crud_genre.name = g_name.Text;
				GenreController.Post(crud_genre);
			}
			else
			{
				MessageBox.Show("Genre name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public void UPDATE_Genre()
		{
			
			if (g_id.Text != "Only for update" || g_id.Text != "")
			{
				int.TryParse(g_id.Text, out int id);
				if (g_name.Text != "")
				{
					crud_genre.name = g_name.Text;
					GenreController.Put(id, crud_genre);
				}

				else
				{
					MessageBox.Show("Genre name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void DELETE_Genre()
		{
			if (g_id.Text != "Only for update" || g_id.Text != "")
			{
				int.TryParse(g_id.Text, out int id);
				GenreController.Delete(id);
			}
			else
			{
				MessageBox.Show("Please enter id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
		public GenreForm()
		{
			InitializeComponent();
		}

		private void g_save_Click(object sender, EventArgs e)
		{
			CREATE_Genre();
			READ_NOBUTTON();
		}

		private void g_update_Click(object sender, EventArgs e)
		{
			UPDATE_Genre();
			READ_NOBUTTON();
		}

		private void g_delete_Click(object sender, EventArgs e)
		{
			DELETE_Genre();
			READ_NOBUTTON();
		}

		private void g_read_Click(object sender, EventArgs e)
		{
			READ_Genre();
		}

		private void GenreForm_Load(object sender, EventArgs e)
		{
			READ_NOBUTTON();
		}
	}
}
