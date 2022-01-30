using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace LibForms.Class
{
	class DB
	{
		public MySqlConnection con;
		public DB()
		{
			string host = "localhost";
			string db = "library";
			string port = "3306";
			string user = "root";
			string pass = "";
			string constring = "datasource = " +host+ "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";
			con = new MySqlConnection(constring);
		}	
	}


	class READ_DATA : DB
	{
		public DataTable dt = new DataTable();
		public DataSet ds = new DataSet();

		public DataSet Read_data()
		{
			dt.Clear();
			string query = "SELECT member.FullName, book.BookName, genre.Genre, loan.LoanDate, loan.ReturnDate, loan.Pay FROM (`member`,`loan`, `book`, `genre`)WHERE loan.BookID = book.BookID AND book.GenreID = genre.GenreID";
			MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

			MDA.Fill(ds);
			return ds;
		}
	}
	//class CRUD_Member : DB
	//{
	//	public string name { get; set; }
	//	public string oib { get; set; }
	//	public string address { get; set; }
	//	public string contact { get; set; }
	//	public string email { get; set; }
	//	public DateTime enrollment { get; set; }
	//	public string libraryID { get; set; }
	//	public string memberID { get; set; }

	//	public DataTable dt = new DataTable();
	//	public DataSet ds = new DataSet();

	//	public void Create_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "INSERT INTO `member`(`FullName`, `Oib`, `Address`, `Contact`, `Email`, `EnrollmentDate`, `LibraryID`) VALUES (@name,@oib,@address,@contact,@email,@enrollment,@libraryID)";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
	//			cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
	//			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
	//			cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
	//			cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
	//			cmd.Parameters.Add("@enrollment", MySqlDbType.Date).Value = enrollment;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Update_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "UPDATE member SET FullName = @name, Oib = @oib, Address = @address, Contact = @contact, Email = @email, EnrollmentDate = @enrollment WHERE MemberID = @memberID";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
	//			cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
	//			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
	//			cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
	//			cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
	//			cmd.Parameters.Add("@enrollment", MySqlDbType.VarChar).Value = enrollment;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

	//			cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Delete_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "DELETE FROM member WHERE MemberID = @memberID";
	//			cmd.Connection = con;
				
	//			cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}

	//	}

	//	public void Read_data()
	//	{
	//		dt.Clear();
	//		string query = "SELECT * FROM `member` ";
	//		MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

	//		MDA.Fill(ds);
	//		dt = ds.Tables[0];
	//	}

	//}

	//class CRUD_Employee:DB
	//{

	//	public string name { get; set; }
	//	public string oib { get; set; }
	//	public string address { get; set; }
	//	public string contact { get; set; }
	//	public string salary { get; set; }
	//	public string note { get; set; }
	//	public string libraryID { get; set; }
	//	public string employeeID { get; set; }

	//	public DataTable dt = new DataTable();
	//	public DataSet ds = new DataSet();

	//	public void Create_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "INSERT INTO `employee`(`FullName`, `Oib`, `Address`, `Contact`, `Salary`, `Note`, `LibraryID`) VALUES (@name,@oib,@address,@contact,@salary,@note,@libraryID)";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
	//			cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
	//			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
	//			cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
	//			cmd.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;
	//			cmd.Parameters.Add("@note", MySqlDbType.VarChar).Value = note;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Update_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "UPDATE `employee` SET `FullName`=@name,`Oib`= @oib,`Address`= @address,`Contact`= @contact,`Salary`= @salary,`Note`= @note WHERE EmployeeID = @employeeID";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
	//			cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
	//			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
	//			cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
	//			cmd.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;
	//			cmd.Parameters.Add("@note", MySqlDbType.VarChar).Value = note;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

	//			cmd.Parameters.Add("@employeeID", MySqlDbType.Int32).Value = employeeID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Delete_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "DELETE FROM employee WHERE EmployeeID = @employeeID";
	//			cmd.Connection = con;

	//			cmd.Parameters.Add("@employeeID", MySqlDbType.Int32).Value = employeeID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}

	//	}

	//	public void Read_data()
	//	{
	//		dt.Clear();
	//		string query = "SELECT * FROM `employee` ";
	//		MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

	//		MDA.Fill(ds);
	//		dt = ds.Tables[0];
	//	}

	//}

	//class CRUD_Book : DB
	//{
	//	public string author { get; set; }
	//	public string bookname { get; set; }
	//	public string publishdate { get; set; }
	//	public int stock { get; set; }
	//	public int genreID { get; set; }
	//	public string libraryID { get; set; }
	//	public int bookID { get; set; }

	//	public DataTable dt = new DataTable();
	//	public DataSet ds = new DataSet();

	//	public void Create_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "INSERT INTO `book`( `Author`, `BookName`, `PublishDate`, `Stock`, `GenreID`, `LibraryID`) VALUES (@author,@bookname,@publishdate,@stock,@genreID,@libraryID)";				
	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@author", MySqlDbType.VarChar).Value = author;
	//			cmd.Parameters.Add("@bookname", MySqlDbType.VarChar).Value = bookname;
	//			cmd.Parameters.Add("@publishdate", MySqlDbType.VarChar).Value = publishdate;
	//			cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = stock;
	//			cmd.Parameters.Add("@genreID", MySqlDbType.Int32).Value = genreID;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;
	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Update_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "UPDATE `book` SET `Author`= @author,`BookName`= @bookname,`PublishDate`= @publishdate,`Stock`= @stock,`GenreID`= @genreID  WHERE BookID = @bookID";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@author", MySqlDbType.VarChar).Value = author;
	//			cmd.Parameters.Add("@bookname", MySqlDbType.VarChar).Value = bookname;
	//			cmd.Parameters.Add("@publishdate", MySqlDbType.VarChar).Value = publishdate;
	//			cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = stock;
	//			cmd.Parameters.Add("@genreID", MySqlDbType.Int32).Value = genreID;
	//			cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

	//			cmd.Parameters.Add("@bookID", MySqlDbType.Int32).Value = bookID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Delete_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "DELETE FROM book WHERE BookID = @bookID";
	//			cmd.Connection = con;

	//			cmd.Parameters.Add("@bookID", MySqlDbType.Int32).Value = bookID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}

	//	}

	//	public void Read_data()
	//	{
	//		dt.Clear();
	//		string query = "SELECT * FROM `book` ";
	//		MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

	//		MDA.Fill(ds);
	//		dt = ds.Tables[0];
	//	}

	//}

	//class CRUD_Genre : DB
	//{

	//	public string name { get; set; }
	//	public string genreID { get; set; }

	//	public DataTable dt = new DataTable();
	//	public DataSet ds = new DataSet();

	//	public void Create_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "INSERT INTO `genre`(`Genre`) VALUES (@name)";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Update_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "UPDATE `genre` SET `Genre`= @name WHERE GenreID = @genreID";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

	//			cmd.Parameters.Add("@genreID", MySqlDbType.Int32).Value = genreID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}
	//	}

	//	public void Delete_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "DELETE FROM genre WHERE GenreID = @genreID";
	//			cmd.Connection = con;

	//			cmd.Parameters.Add("@genreID", MySqlDbType.Int32).Value = genreID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//		}

	//	}

	//	public void Read_data()
	//	{
	//		dt.Clear();
	//		string query = "SELECT * FROM `genre` ";
	//		MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
	//		MDA.Fill(ds);
	//		dt = ds.Tables[0];
	//	}

	//}

	//class CRUD_Loan : DB
	//{
	//	public int memberID { get; set; }
	//	public int bookID { get; set; }
	//	public int employeeID { get; set; }
	//	public DateTime loanDate { get; set; }
	//	public DateTime returnDate { get; set; }
	//	public string loanID { get; set; }
	//	public double pay { get; set; }

	//	public DataTable dt = new DataTable();
	//	public DataSet ds = new DataSet();

	//	public void Create_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
				
	//			cmd.CommandText = "INSERT INTO `loan`(`MemberID`, `BookID`, `EmployeeID`, `LoanDate`, `ReturnDate`) VALUES (@memberID,@bookID,@employeeID,@loanDate,@returnDate)";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;
	//			cmd.Parameters.Add("@bookID", MySqlDbType.Int32).Value = bookID;
	//			cmd.Parameters.Add("@employeeID", MySqlDbType.Int32).Value = employeeID;
	//			cmd.Parameters.Add("@loanDate", MySqlDbType.Date).Value = loanDate;
	//			cmd.Parameters.Add("@returnDate", MySqlDbType.Date).Value = returnDate;

	//			cmd.ExecuteNonQuery();

	//			string CommandText = "UPDATE `book` SET book.Stock = (book.Stock - 1) WHERE book.BookID = @bookID";
	//			MySqlCommand myCommand = new MySqlCommand(CommandText, con);
	//			myCommand.Parameters.Add("@bookID", MySqlDbType.Int32).Value = bookID;
	//			myCommand.ExecuteNonQuery();
	//			con.Close();
	//			TimeSpan ts = returnDate - loanDate;

	//			if( ts.Days > 30)
	//			{
	//				con.Open();

	//				pay = (ts.Days - returnDate.Day) * 2;
	//				cmd.CommandText = "UPDATE `loan` SET Pay = @pay";
	//				cmd.Parameters.Add("@pay", MySqlDbType.Double).Value = pay;
	//				cmd.ExecuteNonQuery();
	//				con.Close();
	//			}
				
	//		}
			
	//	}

	//	public void Update_data()
	//	{
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "UPDATE `loan` SET `MemberID`= @memberID,`BookID`= @bookID,`EmployeeID`= @employeeID,`LoanDate`= @loanDate,`ReturnDate`= @returnDate WHERE LoanID = @loanID";

	//			cmd.Connection = con;
	//			cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;
	//			cmd.Parameters.Add("@bookID", MySqlDbType.Int32).Value = bookID;
	//			cmd.Parameters.Add("@employeeID", MySqlDbType.Int32).Value = employeeID;
	//			cmd.Parameters.Add("@loanDate", MySqlDbType.Date).Value = loanDate;
	//			cmd.Parameters.Add("@returnDate", MySqlDbType.Date).Value = returnDate;

	//			cmd.Parameters.Add("@loanID", MySqlDbType.Int32).Value = loanID;

	//			cmd.ExecuteNonQuery();
	//			con.Close();
	//			TimeSpan ts = returnDate - loanDate;

	//			if (ts.Days > 30)
	//			{
	//				con.Open();

	//				pay = (ts.Days - returnDate.Day) * 2;
	//				cmd.CommandText = "UPDATE `loan` SET Pay = @pay";
	//				cmd.Parameters.Add("@pay", MySqlDbType.Double).Value = pay;
	//				cmd.ExecuteNonQuery();
	//				con.Close();
	//			}
	//		}
	//	}

	//	public void Delete_data()
	//	{
	//		con.Open();
	//		using (MySqlCommand cmd = new MySqlCommand())
	//		{
	//			cmd.CommandText = "DELETE FROM loan WHERE LoanID = @loanID";
	//			cmd.Connection = con;

	//			cmd.Parameters.Add("@loanID", MySqlDbType.Int32).Value = loanID;

	//			cmd.ExecuteNonQuery();

	//			string CommandText = "UPDATE `book` INNER JOIN loan SET book.Stock = (book.Stock + 1) WHERE book.BookID = loan.BookID";
	//			MySqlCommand myCommand = new MySqlCommand(CommandText, con);
	//			myCommand.ExecuteNonQuery();
	//			con.Close();
	//		}

	//	}

	//	public void Read_data()
	//	{
	//		dt.Clear();
	//		string query = "SELECT * FROM `loan` ";
	//		MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
	//		MDA.Fill(ds);
	//		dt = ds.Tables[0];
	//	}

	//}

}
