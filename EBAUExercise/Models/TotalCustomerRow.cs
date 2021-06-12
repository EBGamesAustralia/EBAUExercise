using System;

namespace EBAUExercise.Models
{
	public class TotalCustomerRow
	{
		private int pCustomerID = -1;
		private int pOrderCount = -1;
		private decimal pTotalAmount = -1;
		
		public TotalCustomerRow(int custID, decimal baseAmount)
		{
			pCustomerID = custID;
			pOrderCount = 1;
			pTotalAmount = baseAmount;
		}
		
		
		public TotalCustomerRow(int inpCustomer, int inpCount, decimal inpTotal)
		{
			pCustomerID = inpCustomer;
			pOrderCount = inpCount;
			pTotalAmount = inpTotal;
		}
		
		public void AddOrder(decimal inpCost)
		{
			pOrderCount += 1;
			pTotalAmount += inpCost;
		}
		
		public int customerID
		{
			get {return pCustomerID;}
		}
		public int orderCount
		{
			get {return pOrderCount;}
		}
		public decimal totalAmount
		{
			get {return pTotalAmount;}
		}
	}
}