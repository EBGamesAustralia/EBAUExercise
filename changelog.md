# Changelog

**./EBAUExercise/Models/TotalDateRow.cs**
* The 'orderDate' property is now a string.
	* Converted from raw DateTime object.
	* Uses the format as shown in example output: "dd/MM/yyyy" (eg. 15/01/2021)
	* Input parameters remain unchanged.
* Wrote private method to convert DateTime object to date string.
	* Used by both constructors.


**./EBAuExercise/wwwroot/index.html**
* When the 'Report 2' results are displayed, a short date string is displayed as opposed to the full timestamp.
* Formatting is handled server-side as described above.