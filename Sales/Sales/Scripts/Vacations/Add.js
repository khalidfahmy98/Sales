function Add() {
    var type = $("#vacationType").val(),
        from = $("#from").val(),
        to = $("#to").val(),
        deputy = $("#deputy").val(),
        reason = $("#reason").val(),
        remove = $("#type").val(),
        status = 0 ,
        model = { VacationTypeId: type, FromDate: from, ToDate: to, Deputy: deputy, Reason: reason, RemoveId: remove , Status  : status };
    if (type !== "" && from !== "" && to !== "" && deputy !== "" && reason !== "") {
        $.ajax({
            url: "/Vacations/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Submitted Vacation Request ! ");
                } else {
                    $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Request Empty Values .");
    }
}