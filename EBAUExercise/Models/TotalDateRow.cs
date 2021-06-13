using System;

namespace EBAUExercise.Models
{
	public class TotalDateRow
	{
		private string pOrderDate;
		private int pOrdersMade = -1;
		private decimal pTotalAmount = -1;
		
		public TotalDateRow(DateTime ordDate, decimal baseAmount)
		{
			pOrderDate = stringifyDate(ordDate);
			pOrdersMade = 1;
			pTotalAmount = baseAmount;
		}
		
		public TotalDateRow(DateTime inpDate, int inpCount, decimal inpTotal)
		{
			pOrderDate = stringifyDate(inpDate);
			pOrdersMade = inpCount;
			pTotalAmount = inpTotal;
		}
		
		public void AddOrder(decimal inpCost)
		{
			pOrdersMade += 1;
			pTotalAmount += inpCost;
		}


		private string stringifyDate(DateTime dtObject)
		{
			string res = dtObject.ToString("dd/MM/yyyy");
			return res;
		}
		
		public string orderDate
		{
			get {return pOrderDate;}
		}
		public int ordersMade
		{
			get {return pOrdersMade;}
		}
		public decimal totalAmount
		{
			get {return pTotalAmount;}
		}
	}
}