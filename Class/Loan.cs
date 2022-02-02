using System;
using System.Collections.Generic;

namespace LibForms
{
		public class Loans
		{
			public int LoanID { get; set; }
			public int MemberID { get; set; }
			public int BookID { get; set; }
			public int EmployeeID { get; set; }
			public DateTime LoanDate { get; set; }
			public DateTime ReturnDate { get; set; }
			public double Pay { get; set; }
		}		
}
