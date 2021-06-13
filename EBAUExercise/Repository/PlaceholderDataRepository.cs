using System;
using System.Collections.Generic;
using EBAUExercise.Models;

namespace EBAUExercise.Repository
{
	public class PlaceholderDataRepository
	{
		private static List<TotalCustomerRow> customerRows = new List<TotalCustomerRow>();
		private static List<TotalDateRow> dateRows = new List<TotalDateRow>();
		
		
		public static void setTotalCustomerRows()
		{
			/*
			TotalCustomerRow rowA = new TotalCustomerRow(5, 2, 50);
			TotalCustomerRow rowB = new TotalCustomerRow(19, 1, 10);

			customerRows.Clear();
			customerRows.Add(rowA);
			customerRows.Add(rowB);
			*/
		}

		public static void setTotalDateRows()
		{
			/*
			DateTime fifteen = new DateTime(2021, 1, 15);
			DateTime sixteen = new DateTime(2021, 1, 16);

			TotalDateRow rowA = new TotalDateRow(fifteen, 2, 35);
			TotalDateRow rowB = new TotalDateRow(sixteen, 1, 25);

			dateRows.Clear();
			dateRows.Add(rowA);
			dateRows.Add(rowB);
			*/
		}

		public static List<TotalCustomerRow> customerQuery
		{
			get {return customerRows;}
		}
		public static List<TotalDateRow> dateQuery
		{
			get {return dateRows;}
		}
	}
}