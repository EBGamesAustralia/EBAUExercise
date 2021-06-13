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
        public List<TotalCustomerRow> GetTotalCustomersReport()
        {
            List<TotalCustomerRow> resultSet = new List<TotalCustomerRow>();
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