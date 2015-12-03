var serverURL = "http://localhost:59243/";

function initDefaults() {
    document.getElementById("logged-in-results").textContent = "User is not logged in";
}

function forcePushFunc() {
    $.ajax(serverURL + "login", {
        method: "POST",
        success: respondToLogin,
        data: {
            Username: document.getElementById("username").value,
            Password: document.getElementById("password").value
        },
        processData: false
    });
}

function forceGetFunc() {
    $.ajax(serverURL + "glados", {
        method: "GET",
        success: respondToAction
    });
}

function respondToLogin(data, data2, data3) {
    document.getElementById("logged-in-results").textContent = "User is logged in";
}

function respondToAction(data, data2, data3) {
    var resultsDiv = document.getElementById("results");
    resultsDiv.textContent = JSON.stringify(data);
}
