function Add() {
    var fullname = $("#fullname").val(),
        hexa = $("#hexa").val(),
        model = { Color: fullname, Hexa: hexa };
    if (fullname !== "" && hexa !== "") {
        $.ajax({
            url: "/Colors/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Type Color Successfully ..  ! ");
                } else {
                    $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Register Empty Values .");
    }
}