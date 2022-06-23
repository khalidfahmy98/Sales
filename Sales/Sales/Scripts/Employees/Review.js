function ReloadView() {
    var id = $("#employee").val();
    $.ajax({
        url: "/Employees/ReviewDataview/" + id,
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
function Del(id, emp) {
    $.ajax({
        url: "/Employees/DelCus",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                //$(ele).parent("td").parent("tr").remove();
                $.ajax({
                    url: "/Employees/ReviewDataview/" + emp,
                    type: 'POST',
                    data: JSON.stringify({ Id: emp }),
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
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Customer Deleted From List Succesfully ");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}

