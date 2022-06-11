function Add() {
    var customer = $("#customer").val(),
        grade = $("#grade").val(),
        manemp = $("#id").val(),
        model = { CustomerId: customer, GradeId: grade, ManEmpId: manemp };
    if (customer !== "" && grade !== "") {
        $.ajax({
            url: "/CustomerBridgeGrade/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Customer Grade Assigned Successfully .. ! ");
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