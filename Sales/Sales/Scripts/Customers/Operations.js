function Update() {
    var fullname = $("#fullname").val(),
        id = $("#id").val(),
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
        lang = $("#lang").val(),
        lat = $("#lat").val(),
        model = {
            Id : id , Name: fullname, Phone: phone, MobileP: mobilep
            , MobileS: mobiles, Address: address, NearestPharmacyP: pharmap
            , NearestPharmacyS: pharmas, TypeId: type, SpecialId: special, Comment: comment
            , AreaId: area, ManEmpId: id, Lang: lang, Lat: lat
        };
    if (fullname !== "" && phone !== "" && pharmap !== "" && address !== "") {
        $.ajax({
            url: "/Customers/Update",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Updated Customer Information .. ! ");
                } else {
                    $("#errorHandler").removeClass("hide").addClass("alert-danger").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Update Empty Values .");
    }
}
function Del(id, ele) {
    $.ajax({
        url: "/Customers/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                $(ele).parent("td").parent("tr").remove();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Customer Deleted Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}

