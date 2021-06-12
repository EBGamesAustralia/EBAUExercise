using System;

namespace EBAUExercise.Models
{
	public class TotalDateRow
	{
		private DateTime pOrderDate;
		private int pOrdersMade = -1;
		private decimal pTotalAmount = -1;
		
		public TotalDateRow(DateTime ordDate, decimal baseAmount)
		{
			pOrderDate = ordDate;
			pOrdersMade = 1;
			pTotalAmount = baseAmount;
		}
		
		public TotalDateRow(DateTime inpDate, int inpCount, decimal inpTotal)
		{
			pOrderDate = inpDate;
			pOrdersMade = inpCount;
			pTotalAmount = inpTotal;
		}
		
		public void AddOrder(decimal inpCost)
		{
			pOrdersMade += 1;
			pTotalAmount += inpCost;
		}
		
		public DateTime orderDate
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