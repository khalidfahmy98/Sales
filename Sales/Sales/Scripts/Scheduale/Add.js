function Add() {
    var customer = $("#customer").val(),
        month = $("#month").val(),
        date = $("#date").val(),
        manemp = $("#id").val(),
        model = { CustomerId: customer, Month: month, ManEmpId: manemp, VisitDate: date};
    if (customer !== "" && month !== "" && date !== "") {
        $.ajax({
            url: "/Scheduale/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Schedualed Visit Successfully .. ! ");
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