# Changelog

**./EBAUExercise/Controllers/ReportsController.cs**
* New file - Defines routes for Report endpoints.
	* GET /reports/customers
	* GET /reports/dates
* Each endpoint corresponds to a particular report.
* Only test data is returned for now but the file itself is functional.

---

**./EBAUExercise/Models/**
* Implemented 'get' properties for these classes:
	* TotalCustomerRow
	* TotalDateRow

---

**./EBAUExercise/Repository/PlaceholderDataRepository.cs**
* New file - Contains placeholder report data.
* Based on suggested report output in readme.

---

**./checklist.md**
* Ticked: 'Reports / Implement report controller'
