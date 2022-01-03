
namespace LibForms
{
	partial class BookForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
			System.Windows.Forms.Label authorLabel;
			System.Windows.Forms.Label publish_dateLabel;
			System.Windows.Forms.Label stockLabel;
			System.Windows.Forms.Label genre_idLabel;
			System.Windows.Forms.Label bookNameLabel;
			this.libraryDataSet = new LibForms.LibraryDataSet();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookTableAdapter = new LibForms.LibraryDataSetTableAdapters.BookTableAdapter();
			this.tableAdapterManager = new LibForms.LibraryDataSetTableAdapters.TableAdapterManager();
			this.genreTableAdapter = new LibForms.LibraryDataSetTableAdapters.GenreTableAdapter();
			this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.publish_dateTextBox = new System.Windows.Forms.TextBox();
			this.stockTextBox = new System.Windows.Forms.TextBox();
			this.genre_idTextBox = new System.Windows.Forms.TextBox();
			this.bookNameTextBox = new System.Windows.Forms.TextBox();
			this.bookDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.GenreListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			authorLabel = new System.Windows.Forms.Label();
			publish_dateLabel = new System.Windows.Forms.Label();
			stockLabel = new System.Windows.Forms.Label();
			genre_idLabel = new System.Windows.Forms.Label();
			bookNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
			this.bookBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// libraryDataSet
			// 
			this.libraryDataSet.DataSetName = "LibraryDataSet";
			this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bookBindingSource
			// 
			this.bookBindingSource.DataMember = "Book";
			this.bookBindingSource.DataSource = this.libraryDataSet;
			// 
			// bookTableAdapter
			// 
			this.bookTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.GenreTableAdapter = this.genreTableAdapter;
			this.tableAdapterManager.LibraryTableAdapter = null;
			this.tableAdapterManager.LoanTableAdapter = null;
			this.tableAdapterManager.MemberTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = LibForms.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// genreTableAdapter
			// 
			this.genreTableAdapter.ClearBeforeFill = true;
			// 
			// bookBindingNavigator
			// 
			this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bookBindingNavigator.BindingSource = this.bookBindingSource;
			this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookBindingNavigatorSaveItem});
			this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bookBindingNavigator.Name = "bookBindingNavigator";
			this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.bookBindingNavigator.Size = new System.Drawing.Size(576, 25);
			this.bookBindingNavigator.TabIndex = 0;
			this.bookBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bookBindingNavigatorSaveItem
			// 
			this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
			this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
			this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.bookBindingNavigatorSaveItem.Text = "Save Data";
			this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click);
			// 
			// genreBindingSource
			// 
			this.genreBindingSource.DataMember = "Genre";
			this.genreBindingSource.DataSource = this.libraryDataSet;
			this.genreBindingSource.CurrentChanged += new System.EventHandler(this.genreBindingSource_CurrentChanged);
			// 
			// authorLabel
			// 
			authorLabel.AutoSize = true;
			authorLabel.Location = new System.Drawing.Point(12, 64);
			authorLabel.Name = "authorLabel";
			authorLabel.Size = new System.Drawing.Size(41, 13);
			authorLabel.TabIndex = 3;
			authorLabel.Text = "Author:";
			// 
			// authorTextBox
			// 
			this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
			this.authorTextBox.Location = new System.Drawing.Point(86, 61);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(269, 20);
			this.authorTextBox.TabIndex = 4;
			// 
			// publish_dateLabel
			// 
			publish_dateLabel.AutoSize = true;
			publish_dateLabel.Location = new System.Drawing.Point(12, 90);
			publish_dateLabel.Name = "publish_dateLabel";
			publish_dateLabel.Size = new System.Drawing.Size(68, 13);
			publish_dateLabel.TabIndex = 5;
			publish_dateLabel.Text = "Publish date:";
			// 
			// publish_dateTextBox
			// 
			this.publish_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publish date", true));
			this.publish_dateTextBox.Location = new System.Drawing.Point(86, 87);
			this.publish_dateTextBox.Name = "publish_dateTextBox";
			this.publish_dateTextBox.Size = new System.Drawing.Size(165, 20);
			this.publish_dateTextBox.TabIndex = 6;
			// 
			// stockLabel
			// 
			stockLabel.AutoSize = true;
			stockLabel.Location = new System.Drawing.Point(12, 116);
			stockLabel.Name = "stockLabel";
			stockLabel.Size = new System.Drawing.Size(38, 13);
			stockLabel.TabIndex = 7;
			stockLabel.Text = "Stock:";
			// 
			// stockTextBox
			// 
			this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Stock", true));
			this.stockTextBox.Location = new System.Drawing.Point(86, 113);
			this.stockTextBox.Name = "stockTextBox";
			this.stockTextBox.Size = new System.Drawing.Size(165, 20);
			this.stockTextBox.TabIndex = 8;
			this.stockTextBox.TextChanged += new System.EventHandler(this.stockTextBox_TextChanged);
			// 
			// genre_idLabel
			// 
			genre_idLabel.AutoSize = true;
			genre_idLabel.Location = new System.Drawing.Point(12, 142);
			genre_idLabel.Name = "genre_idLabel";
			genre_idLabel.Size = new System.Drawing.Size(50, 13);
			genre_idLabel.TabIndex = 9;
			genre_idLabel.Text = "Genre id:";
			// 
			// genre_idTextBox
			// 
			this.genre_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Genre id", true));
			this.genre_idTextBox.Location = new System.Drawing.Point(86, 139);
			this.genre_idTextBox.Name = "genre_idTextBox";
			this.genre_idTextBox.Size = new System.Drawing.Size(75, 20);
			this.genre_idTextBox.TabIndex = 10;
			this.genre_idTextBox.TextChanged += new System.EventHandler(this.genre_idTextBox_TextChanged);
			// 
			// bookNameLabel
			// 
			bookNameLabel.AutoSize = true;
			bookNameLabel.Location = new System.Drawing.Point(12, 40);
			bookNameLabel.Name = "bookNameLabel";
			bookNameLabel.Size = new System.Drawing.Size(64, 13);
			bookNameLabel.TabIndex = 13;
			bookNameLabel.Text = "Book name:";
			// 
			// bookNameTextBox
			// 
			this.bookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bookName", true));
			this.bookNameTextBox.Location = new System.Drawing.Point(86, 37);
			this.bookNameTextBox.Name = "bookNameTextBox";
			this.bookNameTextBox.Size = new System.Drawing.Size(269, 20);
			this.bookNameTextBox.TabIndex = 14;
			// 
			// bookDataGridView
			// 
			this.bookDataGridView.AutoGenerateColumns = false;
			this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.bookDataGridView.DataSource = this.bookBindingSource;
			this.bookDataGridView.Location = new System.Drawing.Point(15, 281);
			this.bookDataGridView.Name = "bookDataGridView";
			this.bookDataGridView.Size = new System.Drawing.Size(537, 220);
			this.bookDataGridView.TabIndex = 14;
			this.bookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellContentClick_2);
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "bookName";
			this.dataGridViewTextBoxColumn7.HeaderText = "bookName";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Author";
			this.dataGridViewTextBoxColumn2.HeaderText = "Author";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Publish date";
			this.dataGridViewTextBoxColumn3.HeaderText = "Publish date";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Stock";
			this.dataGridViewTextBoxColumn4.HeaderText = "Stock";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Genre id";
			this.dataGridViewTextBoxColumn5.HeaderText = "Genre id";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(86, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "CREATE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GenreListBox
			// 
			this.GenreListBox.FormattingEnabled = true;
			this.GenreListBox.Location = new System.Drawing.Point(86, 165);
			this.GenreListBox.Name = "GenreListBox";
			this.GenreListBox.Size = new System.Drawing.Size(269, 43);
			this.GenreListBox.TabIndex = 16;
			this.GenreListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Genre list:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(186, 227);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "UPDATE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(280, 227);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "DELETE";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// BookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 567);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GenreListBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bookDataGridView);
			this.Controls.Add(authorLabel);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(publish_dateLabel);
			this.Controls.Add(this.publish_dateTextBox);
			this.Controls.Add(stockLabel);
			this.Controls.Add(this.stockTextBox);
			this.Controls.Add(genre_idLabel);
			this.Controls.Add(this.genre_idTextBox);
			this.Controls.Add(bookNameLabel);
			this.Controls.Add(this.bookNameTextBox);
			this.Controls.Add(this.bookBindingNavigator);
			this.Name = "BookForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
			this.bookBindingNavigator.ResumeLayout(false);
			this.bookBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LibraryDataSet libraryDataSet;
		private System.Windows.Forms.BindingSource bookBindingSource;
		private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
		private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator bookBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
		private LibraryDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
		private System.Windows.Forms.BindingSource genreBindingSource;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.TextBox publish_dateTextBox;
		private System.Windows.Forms.TextBox stockTextBox;
		private System.Windows.Forms.TextBox genre_idTextBox;
		private System.Windows.Forms.TextBox bookNameTextBox;
		private System.Windows.Forms.DataGridView bookDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox GenreListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

