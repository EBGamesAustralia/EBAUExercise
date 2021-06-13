# Changelog

**./EBAUExercise/Models/TotalDateRow.cs**
* Removed:
	* Private properties.
	* Constructors
	* 'AddOrder' function
* Simplified get/set for public properties.
* Kept 'stringifyDate' function for now.

---

**./EBAUExercise/Services/ReportService.cs**
* 'retrievedRows' in 'CustomerReport' is declared as the intended type.
* Added query for order totals by date.

---

**./EBAUExercise/Controllers/ReportController.cs**
* The '/reports/dates' endpoint now queries the sample data set.

---

**./EBAUExercise/wwwroot/index.html**
* 'Order totals by date' endpoint results are displayed.
* Slight overflow on output section.

---

**./checklist.md**
* Ticked: 'reports / Query order totals by date'
* 'reports' is now complete.
