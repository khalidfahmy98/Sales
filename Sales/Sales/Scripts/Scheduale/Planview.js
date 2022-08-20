$(document).on('click', '.startpoint', function () {
    var id = $(this).val();
    $('.startpoint').not(this).prop('checked', false);
    $.ajax({
        url: "/Scheduale/UpdateStart",
        type: 'POST',
        data: JSON.stringify({ Id: id  }),
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
        url: "/Scheduale/PlanView?emp=" + emp + "&month=" + month + "&type=" + type ,
        type: 'POST',
        data: JSON.stringify({ Emp: emp, Month: month , Type : type}),
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
