$(document).ready(function () {
    ReloadView();
    $("#month").change(function () {
        switch ($(this).val()) {
            case "3":
                $("#workdays").val("22");
                break;
            case "4":
                $("#workdays").val("21");
                break;
            case "1":
            case "5":
            case "6":
            case "7":
            case "8":
            case "10":
            case "11":
                $("#workdays").val("23");
                break;
            case "2":
            case "9":
            case "12":
                $("#workdays").val("20");
                break;
            default:
                $("#workdays").val("23");
        }
        $("#days").text($("#workdays").val());
        $("#callmonth").text($("#avg").text() * $("#days").text());
    });
    $("#type").change(function () {
        var id;
        if ($("#workdays").val() == 0) {
            $("#errorHandler").removeClass("hide").addClass("alert-danger").removeClass("alert-success").text("Please Choose Month First .. ! ");
        } else {
            $("#errorHandler").addClass("hide");
            $("#days").text($("#workdays").val());
            id = $(this).val();
            $.ajax({
                url: "/Types/GetVisits?Id="+id,
                type: 'POST',
                data: JSON.stringify({ Id: id }),
                async: false,
                contentType: 'application/json; charset=utf-8',
                cache: false,
                processData: false,
                success: function (data, textStatus, jqXHR) {
                    if (data.success == "success") {
                        $("#avg").text(data.Visits);
                        $("#callmonth").text($("#avg").text() * $("#days").text());
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });

        }
    });
    $(".visitdate").keyup(function () {
        if (!$(this).hasClass("counted")) {
            $(this).addClass("counted");
            $("#calls").text(parseInt($("#calls").text()) + 1);
        }
    });
});
function Del(id, ele) {
    $.ajax({
        url: "/Scheduale/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Deleted Schedualed Visit Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView() {
    $.ajax({
        url: "/Scheduale/DataView",
        type: 'GET',
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
