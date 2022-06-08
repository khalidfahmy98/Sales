function Del(id, ele) {
    if (id > 1) {
        $.ajax({
            url: "/Employees/Del",
            type: 'POST',
            data: JSON.stringify({ Id: id }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $(ele).parent("td").parent("tr").remove();
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Employee Deleted Successfully");
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Delete Primary System Admin.");
    }
}

