using System;

namespace EBAUExercise.Models
{
	public class TotalDateRow
	{
		
		private string stringifyDate(DateTime dtObject)
		{
			string res = dtObject.ToString("dd/MM/yyyy");
			return res;
		}
		
		public string orderDate {get; set;}
		public int ordersMade {get; set;}
		public decimal totalAmount {get; set;}
	}
}