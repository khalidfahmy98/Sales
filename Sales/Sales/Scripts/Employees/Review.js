function ReloadView() {
    var id = $("#employee").val(),
        type = $("#type").val();
    $.ajax({
        url: "/Employees/ReviewDataview?Id=" + id + "&typ=" + type,
        type: 'POST',
        data: JSON.stringify({ Id: id, typ: type }),
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
$("#View").on("change", ".grade", function () {
    var grade = $(this).val(),
        customer = $(this).siblings(".customerId").val(),
        emp = $(this).siblings(".empId").val(),
        model = { GradeId: grade, CustomerId: customer, ManEmpId: emp };
    $.ajax({
        url: "/CustomerBridgeGrade/CreateListed",
        type: 'POST',
        data: JSON.stringify({ model: model }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView();
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
});

