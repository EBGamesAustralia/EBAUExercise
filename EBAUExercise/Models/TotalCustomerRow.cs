using System;

namespace EBAUExercise.Models
{
	public class TotalCustomerRow
	{

		public int customerID {get; set;}
		public int orderCount {get; set;}
		public decimal totalAmount {get; set;}
	}
}