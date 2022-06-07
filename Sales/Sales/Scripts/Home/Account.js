function edit(type) {
    if (type == 1) {
        $("#editPanel").removeClass("hide");
    } else {
        $("#editPanel").addClass("hide");
    }
}
function update() {
    var id = $("#id").val(),
        name = $("#name").val(),
        username = $("#username").val(),
        password = $("#password").val(),
        model = { Id: id, Name: name , Username : username , Password : password };
    if (name !== "" && id !== "" && username !== "" && password !== "") {
        $.ajax({
            url: "/Home/Update",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data.Success == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Updated Account Information.");
                    window.location.href = data.Link;
                } else {
                    $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Update Empty Values .");
    }
}