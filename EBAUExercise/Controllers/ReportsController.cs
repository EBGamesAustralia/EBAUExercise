using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EBAUExercise.Services;
using EBAUExercise.Repository;
using EBAUExercise.Models;

//PlaceholderDataRepository.setTotalCustomerRows();
//PlaceholderDataRepository.setTotalDateRows();

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
            PlaceholderDataRepository.setTotalCustomerRows();
            return PlaceholderDataRepository.customerQuery;
        }
		
		[HttpGet("dates")]
        public List<TotalDateRow> GetTotalDatesReport()
        {
            PlaceholderDataRepository.setTotalDateRows();
            return PlaceholderDataRepository.dateQuery;
        }
	}
}