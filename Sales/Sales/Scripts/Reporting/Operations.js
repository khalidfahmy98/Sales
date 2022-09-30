$(document).ready(function () {
    ReloadView();
});
function ReloadView() {
    var date = $("#monthTracker").text();
    $.ajax({
        url: "/Reporting/Dataview?Date=" + date,
        data: JSON.stringify({ Date: date }),
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
