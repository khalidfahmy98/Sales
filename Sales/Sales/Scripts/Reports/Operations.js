function Add() {
    var report = $("#report").val(),
        plan = $("#plan").val(),
        model = { PlanId: plan, Report: report };
    if (report !== "" ) {
        $.ajax({
            url: "/Report/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Submitted Call Report ");
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