function Add() {
    var emp = $("#employee").val(),
        model = {},
        count = 0;
    if ($('input[name="customers"]:checked').length > 0) {
        $("#errorHandler").addClass("hide");
        $('input[name="customers"]:checked').each(function () {
            if (count == $('input[name="customers"]:checked').length) {
            } else {
                model = { EmployeeId: emp, CustomerId: this.value };
                $.ajax({
                    url: "/Employees/CreateList",
                    type: 'POST',
                    data: JSON.stringify({ model: model }),
                    async: false,
                    contentType: 'application/json; charset=utf-8',
                    cache: false,
                    processData: false,
                    success: function (data, textStatus, jqXHR) {
                        if (data == "success") {
                            $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created Employee List Successfully ..  ! ");
                            count++;
                        } else {
                            $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert(errorThrown);
                    }
                });
            }
        });
        //console.log(model);
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Create Employee List Without Customer Choosed .. ! ");
    }
}
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

