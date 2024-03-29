﻿function Add() {
    var name = $("#name").val(),
        novisits = $("#novisits").val(),
        color = $("#color").val(),
        condition = $("#condition").val(),
        model = { Type: name, NoVisits: novisits, ColorId: color, Condition: condition};
    if (name !== "" && novisits !== "") {
        $.ajax({
            url: "/Types/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Customer Type Successfully .. ! ");
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