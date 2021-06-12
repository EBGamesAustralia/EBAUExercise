function sendHelloWorldRequest()
{
	fetch("/message/one")
	.then(function(response)
	{
		var outputText = response.status + " - " + response.statusText;
		document.getElementById("outputContainer").innerHTML = outputText;
	});
}