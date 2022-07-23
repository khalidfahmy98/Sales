function Add() {
    var month = $("#month").val(),
        leader = $("#leader").val(),
        manemp = $("#id").val(),
        customer = 0 ,
        count = 0;
    var model = {};
    if ($('input[name="customers"]:checked').length > 0) {
        $("#errorHandler").addClass("hide");
        $('input[name="customers"]:checked').each(function () {
            if (count == $('input[name="customers"]:checked').length) {
                // Leave me empty
            } else {
                customer = $(this).val();
                $(this).parent("td").parent("tr").children("td").eq(6).children(".visitdate").each(function () {
                    if ($(this).val() != "") {
                        model = { ManEmpId: manemp, CustomerId: customer, Month: month, VisitDate: $(this).val() , Status: 0 };
                        $.ajax({
                            url: "/Scheduale/Create",
                            type: 'POST',
                            data: JSON.stringify({ model: model }),
                            async: false,
                            contentType: 'application/json; charset=utf-8',
                            cache: false,
                            processData: false,
                            success: function (data, textStatus, jqXHR) {
                                if (data == "success") {
                                    ReloadView();
                                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created Plan Successfully .. ! ");
                                }
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                alert(errorThrown);
                            }
                        });
                    }
                });
            }
        });
    }else{
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Create Plan With out Customer Choosed .. ! ");
    }
}




