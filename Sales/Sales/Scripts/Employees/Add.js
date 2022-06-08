function Add() {
    var fullname = $("#fullname").val(),
        username = $("#username").val(),
        password = $("#password").val(),
        email = $("#email").val(),
        phone = $("#phone").val(),
        nationalid = $("#nationalid").val(),
        address = $("#address").val(),
        status = 1,
        rule = 1,
        model = { Name: fullname, Username: username, Password: password, Email: email, NationalId: nationalid, Address: address, Phone: phone, Rule: rule , Status : status };
    if (fullname !== "" && username !== "" && password !== "") {
        if (username.length > 6) {
            if (password.length > 6) {
                $.ajax({
                    url: "/Managers/Create",
                    type: 'POST',
                    data: JSON.stringify({ model: model }),
                    async: false,
                    contentType: 'application/json; charset=utf-8',
                    cache: false,
                    processData: false,
                    success: function (data, textStatus, jqXHR) {
                        if (data == "success") {
                            $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Manager Account Successfully ..  ! ");
                        } else {
                            $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert(errorThrown);
                    }
                });
            } else {
                $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Password Cant Be Less Than 6 Digits. ");
            }
        } else {
            $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Username Cant Be Less Than 6 Digits. ");
        }
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Register Empty Values .");
    }
}