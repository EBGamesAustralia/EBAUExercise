using System;
using System.Collections.Generic;
using System.Linq;
using EBAUExercise.Repository;
using EBAUExercise.Models;

namespace EBAUExercise.Services
{
    public class ReportService
    {
        private readonly SampleDataRepository _sampleDataRepository;

        public ReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }

        /// <summary>
        /// Build and output a list of data that breaks down the data by customer id, taking count of orders and summing 'order total'.
        /// </summary>
        public IEnumerable<TotalCustomerRow> CustomerReport()
        {
            var dataset = _sampleDataRepository.GetDataset;

            var retrievedRows = 
            from individualOrderObject in dataset
            group individualOrderObject by individualOrderObject.CustomerId into customerOrderGroup
            select new TotalCustomerRow
            {
                customerID = customerOrderGroup.Key,
                orderCount = customerOrderGroup.Count(),
                totalAmount = (from custOrder in customerOrderGroup select custOrder.OrderTotal).Sum()
            };

            return retrievedRows;
        }

        /// <summary>
        /// Build and output a list of data that shows the number of orders by date and a sum of 'order total'.
        /// </summary>
        private void StoreDailyReport()
        {
            var dataset = _sampleDataRepository.GetDataset;



        }
    }
}