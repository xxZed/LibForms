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

	class CRUD : DB
	{
		public string name { get; set; }
		public string oib { get; set; }
		public string address { get; set; }
		public string contact { get; set; }
		public string email { get; set; }
		public string enrollment { get; set; }
		public string libraryID { get; set; }
		public string memberID { get; set; }

		public DataTable dt = new DataTable();
		public DataSet ds = new DataSet();

		public void Create_data()
		{
			con.Open();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.CommandText = "INSERT INTO `member`(`FullName`, `Oib`, `Address`, `Contact`, `Email`, `EnrollmentDate`, `LibraryID`) VALUES (@name,@oib,@address,@contact,@email,@enrollment,@libraryID)";

				cmd.Connection = con;
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
				cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
				cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
				cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
				cmd.Parameters.Add("@enrollment", MySqlDbType.VarChar).Value = enrollment;
				cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

				cmd.ExecuteNonQuery();
				con.Close();
			}
		}

		public void Update_data()
		{
			con.Open();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.CommandText = "UPDATE member SET FullName = @name, Oib = @oib, Address = @address, Contact = @contact, Email = @email, EnrollmentDate = @enrollment WHERE MemberID = @memberID";

				cmd.Connection = con;
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@oib", MySqlDbType.Double).Value = oib;
				cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
				cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
				cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
				cmd.Parameters.Add("@enrollment", MySqlDbType.VarChar).Value = enrollment;
				cmd.Parameters.Add("@libraryID", MySqlDbType.Int32).Value = 1;

				cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;

				cmd.ExecuteNonQuery();
				con.Close();
			}
		}

		public void Delete_data()
		{
			con.Open();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.CommandText = "DELETE FROM member WHERE MemberID = @memberID";
				cmd.Connection = con;
				
				cmd.Parameters.Add("@memberID", MySqlDbType.Int32).Value = memberID;

				cmd.ExecuteNonQuery();
				con.Close();
			}

		}

		public void Read_data()
		{
			dt.Clear();
			string query = "SELECT * FROM `member` ";
			MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

			MDA.Fill(ds);
			dt = ds.Tables[0];
		}
	}
}
