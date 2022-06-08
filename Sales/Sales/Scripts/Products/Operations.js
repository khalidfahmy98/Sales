﻿function Del(id, ele) {
    $.ajax({
        url: "/Products/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                $(ele).parent("td").parent("tr").remove();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Product Deleted Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}

