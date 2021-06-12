function clearOutputSection()
{
	document.getElementById("outputDisplay").innerHTML = "";
}


function sendHelloWorldRequest()
{
	fetch("/message/one")
	.then(function(response)
	{
		var outputText = response.status + " - " + response.statusText;
		document.getElementById("outputDisplay").innerHTML = outputText;
	});
}


function sendIocRequest()
{
	fetch("/tasks")
	.then(response => response.json())
	.then(function(data)
	{
		var containerElement = document.getElementById("outputDisplay");
		containerElement.innerHTML = "";
		addTaskField("Saved", data.isDataSaved, containerElement);
		addTaskField("Increment Count", data.count, containerElement);
	});
}


function addTaskField(propName, propVal, containObj)
{
	var fieldElement = document.createElement("p");
	var nameHTML = "<strong>" + propName + ": </strong>";
	
	fieldElement.innerHTML = nameHTML + propVal;
	containObj.appendChild(fieldElement);
}