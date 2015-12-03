var serverURL = "http://localhost:59243/glados";

function forcePushFunc() {
    $.ajax(serverURL, {
        method: "PUT",
        success: respondToAction,
        data: {
            Username: document.getElementById("username").value,
            Password: document.getElementById("password").value
        },
        processData: false
    });
}

function forceGetFunc() {
    $.ajax(serverURL, {
        method: "GET",
        success: respondToAction
    });
}

function respondToAction(data, data2, data3) {
    var resultsDiv = document.getElementById("results");
    resultsDiv.textContent = JSON.parse(data);
}
