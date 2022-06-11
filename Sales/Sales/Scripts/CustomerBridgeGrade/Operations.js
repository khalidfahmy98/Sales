$(document).ready(function () {
    ReloadView();
});
function Del(id, ele) {
    $.ajax({
        url: "/CustomerBridgeGrade/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Deleted Customer Grade Assigned Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView() {
    $.ajax({
        url: "/CustomerBridgeGrade/DataView",
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
