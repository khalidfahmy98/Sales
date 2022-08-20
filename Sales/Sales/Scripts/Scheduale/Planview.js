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
