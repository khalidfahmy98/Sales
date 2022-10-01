function Add() {
    var requireds = $(".Validate").length,
        passed = 0;
    $(".Validate").each(function () {
        if ($(this).val() != "") {
            passed++;
        }
    });
    if (passed == requireds) {
        var reportDate = $("#monthTracker").text(),
            customerId,
            customerName,
            coaching,
            contactways,
            gifts,
            availabilty,
            comment,
            productId,
            quantity,
            ReportCustomerModel = {},
            ReportProductModel = {},
            ReportHeaderId,
            ReportCustomerBodyId , 
            ReportHeaderModel = { ReportDate: reportDate };
            $.ajax({
                url: "/Reporting/CreateHeader",
                type: 'POST',
                data: JSON.stringify({ model: ReportHeaderModel }),
                async: false,
                contentType: 'application/json; charset=utf-8',
                cache: false,
                processData: false,
                success: function (data, textStatus, jqXHR) {
                    if (data.status == "success") {
                        ReportHeaderId = data.msg; 
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
        $(".datarecord").each(function () {
            customerId = $(this).children("td").eq(0).children("span").data("customerid");
            customerName = $(this).children("td").eq(0).children(".altCustomer").val();
            coaching = $(this).children("td").eq(2).children(".coaching").val();
            contactways = $(this).children("td").eq(3).children(".contactways").val();
            gifts = $(this).children("td").eq(4).children(".gift").val();
            availabilty = $(this).children("td").eq(5).children(".availabilty").val();
            comment = $(this).children("td").eq(6).children(".comment").val();
            ReportCustomerModel = { ReportHeaderId: ReportHeaderId ,  CustomerId: customerId, CustomerAlternative: customerName, Coaching: coaching, ContactWays: contactways, Gifts: gifts, Avaliablity: availabilty, Comment: comment }
            $.ajax({
                url: "/Reporting/CreateCustomerBody",
                type: 'POST',
                data: JSON.stringify({ model: ReportCustomerModel }),
                async: false,
                contentType: 'application/json; charset=utf-8',
                cache: false,
                processData: false,
                success: function (data, textStatus, jqXHR) {
                    if (data.status == "success") {
                        ReportCustomerBodyId = data.msg;
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
            $(this).children("td").eq(1).each(function () {
                productId = $(this).children(".productQuantity").data("product");
                quantity = $(this).children(".productQuantity").val();
                ReportProductModel = { ReportHeaderId: ReportHeaderId, ReportCustomerBodyId: ReportCustomerBodyId, ProductId: productId, Quantity: quantity }
                $.ajax({
                    url: "/Reporting/CreateProductBody",
                    type: 'POST',
                    data: JSON.stringify({ model: ReportProductModel }),
                    async: false,
                    contentType: 'application/json; charset=utf-8',
                    cache: false,
                    processData: false,
                    success: function (data, textStatus, jqXHR) {
                        if (data.status == "success") {
                            $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Report Submitted Successfully .. ! ");
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert(errorThrown);
                    }
                });
            });
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").removeClass("alert-success").text("All Fields Required Except Comment .. ! ");

    }
}