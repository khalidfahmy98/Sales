$(document).ready(function () {
    $('#time').dateAndTime();
});
function Add() {
    var customer = $("#id").val(),
        day = $("#day").val(),
        time = $("#time").val(),
        comment = $("#comment").val(),
        model = { Day: day, Time: time , Comment: comment, CustomerId: customer };
    if (day !== "" && comment !== "" && customer !== "") {
        $.ajax({
            url: "/CusWork/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView(customer);
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Customer Work Time Successfully .. ! ");
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
function Del(id, ele) {
    $.ajax({
        url: "/CusWork/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView(id);
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Deleted Customer Work Time Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView(id) {
    $.ajax({
        url: "/CusWork/DataView/"+id,
        type: 'GET',
        async: false,
        contentType: 'charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            $("#View").html(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
