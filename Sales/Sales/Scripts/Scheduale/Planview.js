$(document).ready(function () {
    $('.starttime').dateAndTime();
});

$(document).on('click', '.startpoint', function () {
    var id = $(this).val(),
        time = $(this).siblings(".starttime"),
        date = $(this).siblings(".day").val().split("/"),
        day = date[0],
        model = { SchedualeId: id, Time: time, Day: day}
    //$('.startpoint').not(this).prop('checked', false);
    $.ajax({
        url: "/Scheduale/UpdateStart",
        type: 'POST',
        data: JSON.stringify({ Model: model  }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Selected Starting Point");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
});

function ReloadView() {
    var emp = $("#employee").val(),
        month = $("#month").val(), 
        type = $("#type").val();
    $.ajax({
        url: "/Scheduale/PlanView?emp=" + emp + "&month=" + month + "&type=" + type  ,
        type: 'POST',
        data: JSON.stringify({ Emp: emp, Month: month , Type : type  }),
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
