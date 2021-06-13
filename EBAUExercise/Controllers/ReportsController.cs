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
		private readonly DoWorkService _doWorkService;

        public ReportsController(DoWorkService doWorkService)
        {
            _doWorkService = doWorkService;
        }

        [HttpGet("customers")]
        public IEnumerable<TotalCustomerRow> GetTotalCustomersReport()
        {
            SampleDataRepository x = new SampleDataRepository();
            ReportService y = new ReportService(x);
            IEnumerable<TotalCustomerRow> resultSet = y.CustomerReport();

            return resultSet;
        }
		
		[HttpGet("dates")]
        public List<TotalDateRow> GetTotalDatesReport()
        {
            List<TotalDateRow> resultSet = new List<TotalDateRow>();
            return resultSet;
        }
	}
}