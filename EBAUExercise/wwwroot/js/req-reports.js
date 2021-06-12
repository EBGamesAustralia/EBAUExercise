function sendCustomersQueryRequest()
{
	fetch("/reports/customers")
	.then(response => response.json())
	.then(function(data)
	{
		var columnList = ["Customer ID", "Order Count", "Total"];
		var propertyList = ["customerID", "orderCount", "totalAmount"];
		displayQueryResultTable(columnList, propertyList, data);
	});
}


function sendDatesQueryRequest()
{
	fetch("/reports/dates")
	.then(response => response.json())
	.then(function(data)
	{
		var columnList = ["Order Date", "Order Count", "Order Total"];
		var propertyList = ["orderDate", "ordersMade", "totalAmount"];
		displayQueryResultTable(columnList, propertyList, data);
	});
}


function displayQueryResultTable(colList, propList, rowArray)
{
	var containerElement = document.getElementById("outputContainer");
	var breakElement = document.createElement("br");
	var tableElement = document.createElement("table");
	
	tableElement.id = "dataTable";
	tableElement.className = "table table-responsive table-bordered border-primary";
	
	containerElement.innerHTML = "";
	writeHeaderRow(tableElement, colList);
	writeBodyRows(tableElement, propList, rowArray);
	
	containerElement.appendChild(breakElement);
	containerElement.appendChild(tableElement);
}


function writeHeaderRow(tblObject, colsObject)
{
	var headContainer = document.createElement("thead");
	var rowObject = document.createElement("tr");
	
	var columnIndex = 0;
	var currentColumnName = "";
	var currentColumnElement = null;
	
	for (columnIndex = 0; columnIndex < colsObject.length; columnIndex = columnIndex + 1)
	{
		currentColumnName = colsObject[columnIndex];
		currentColumnElement = document.createElement("th");
		
		currentColumnElement.innerHTML = currentColumnName;
		currentColumnElement.setAttribute("scope", "col");
		
		rowObject.appendChild(currentColumnElement);
	}
	
	headContainer.appendChild(rowObject);
	tblObject.appendChild(headContainer);
}


function writeBodyRows(tblObject, propObject, rowsArr)
{
	var bodyContainer = document.createElement("tbody");
	
	var dataIndex = 0;
	var currentDataObject = {};
	var currentRowObject = null;
	
	var cellIndex = 0;
	var currentCellProp = "";
	var currentCellValue = null;
	var currentCellObject = null;
	
	for (dataIndex = 0; dataIndex < rowsArr.length; dataIndex = dataIndex + 1)
	{
		currentDataObject = rowsArr[dataIndex];
		currentRowObject = document.createElement("tr");
		
		cellIndex = 0;
		currentCellProp = "";
		currentCellValue = null;
		currentCellObject = null;
		
		while (cellIndex >= 0 && cellIndex < propObject.length)
		{
			currentCellProp = propObject[cellIndex];
			currentCellValue = currentDataObject[currentCellProp];
			currentCellObject = document.createElement("td");
			
			currentCellObject.innerHTML = currentCellValue;
			currentRowObject.appendChild(currentCellObject);
			
			cellIndex = cellIndex + 1;
		}
		
		bodyContainer.appendChild(currentRowObject);
	}
	
	tblObject.appendChild(bodyContainer);
}