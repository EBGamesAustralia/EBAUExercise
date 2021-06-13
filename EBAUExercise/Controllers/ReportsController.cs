using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EBAUExercise.Services;
using EBAUExercise.Repository;
using EBAUExercise.Models;

namespace EBAUExercise.Controllers
{

	[ApiController]
    [Route("[controller]")]
    
    public class ReportsController : ControllerBase
	{
		public static SampleDataRepository orderTable = new SampleDataRepository();
        public static ReportService orderQueries = new ReportService(orderTable);
        
        private readonly DoWorkService _doWorkService;

        public ReportsController(DoWorkService doWorkService)
        {
            _doWorkService = doWorkService;
        }

        [HttpGet("customers")]
        public IEnumerable<TotalCustomerRow> GetTotalCustomersReport()
        {
            IEnumerable<TotalCustomerRow> resultSet = orderQueries.CustomerReport();
            return resultSet;
        }
		
		[HttpGet("dates")]
        public IEnumerable<TotalDateRow> GetTotalDatesReport()
        {
            IEnumerable<TotalDateRow> resultSet = orderQueries.StoreDailyReport();
            return resultSet;
        }
	}
}