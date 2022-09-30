$(document).ready(function () {
    ReloadView();
});
function ReloadView() {
    var date = $("#monthTracker").text().split("/"),
        month = date[1];
    $.ajax({
        url: "/Reporting/Dataview?Month=" + month,
        data: JSON.stringify({ Month: month }),
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
