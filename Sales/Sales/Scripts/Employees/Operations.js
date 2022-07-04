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

$(".leader").change(function () {
    var emp = $(this).siblings(".employeeId").val(),
        leader = $(this).val();
        $.ajax({
            url: "/Employees/Leading",
            type: 'POST',
            data: JSON.stringify({ Emp: emp , Leader : leader }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Leader Changed Successfully .. ! ");
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });

});
