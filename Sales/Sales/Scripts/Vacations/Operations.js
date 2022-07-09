$(document).ready(function () {
    ReloadView();
});
function ReloadView() {
    $.ajax({
        url: "/Vacations/DataView",
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

