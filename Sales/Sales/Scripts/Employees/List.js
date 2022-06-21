function ReloadView(id) {
    var id = $("#area").val();
    $.ajax({
        url: "/Employees/ListDataview/"+id,
        type: 'POST',
        data: JSON.stringify({ Id: id }),
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

