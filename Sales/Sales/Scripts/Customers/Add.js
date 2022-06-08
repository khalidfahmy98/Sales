function Add() {
    var fullname = $("#fullname").val(),
        phone = $("#phone").val(),
        mobilep = $("#mobilep").val(),
        mobiles = $("#mobiles").val(),
        pharmap = $("#pharmap").val(),
        pharmas = $("#pharmas").val(),
        address = $("#address").val(),
        area = $("#area").val(),
        type = $("#type").val(),
        comment = $("#comment").val(),
        special = $("#special").val(),
        model = {
            Name: fullname, Phone: phone, MobileP: mobilep
            , MobileS: mobiles, Address: address, NearestPharmacyP: pharmap
            , NearestPharmacyS: pharmas, TypeId: type, SpecialId: special , Comment : comment , AreaId : area
        };
    if (fullname !== "" && phone !== "" && mobilep !== "" && mobiles !== "" && pharmap !== "" && pharmas !== "" && address !== "") {
        $.ajax({
            url: "/Customers/Create",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Created New Customer Account Successfully ..  ! ");
                } else {
                    $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Register Empty Values .");
    }
}