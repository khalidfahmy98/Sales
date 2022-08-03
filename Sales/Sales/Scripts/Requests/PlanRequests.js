//function ApprovePlan(id) {
//    $.ajax({
//        url: "/Requests/ApprovePlan",
//        type: 'POST',
//        data: JSON.stringify({ Id: id }),
//        async: false,
//        contentType: 'application/json; charset=utf-8',
//        cache: false,
//        processData: false,
//        success: function (data, textStatus, jqXHR) {
//            if (data == "success") {
//                ReloadView();
//            }
//        },
//        error: function (jqXHR, textStatus, errorThrown) {
//            alert(errorThrown);
//        }
//    });
//}
//function ReloadView() {
//    $.ajax({
//        url: "/Requests/PlanDataview",
//        type: 'GET',
//        async: false,
//        contentType: 'charset=utf-8',
//        cache: false,
//        processData: false,
//        success: function (data, textStatus, jqXHR) {
//            $("#View").html(data);
//        },
//        error: function (jqXHR, textStatus, errorThrown) {
//            alert(errorThrown);
//        }
//    });
//}
function Approve() {
    $(".plans").each(function () {
        if ($(this).val() != "") {
            $.ajax({
                url: "/Requests/ApprovePlan?Id=" + $(this).val(),
                type: 'POST',
                data: JSON.stringify({ Id : $(this).val() }),
                async: false,
                contentType: 'charset=utf-8',
                cache: false,
                processData: false,
                success: function (data, textStatus, jqXHR) {
                    $("#View").html("<div class='alert alert-success'> Plan Approved Successfully </div>");
                    $("#approvebtn").Attr("disabled","disabled");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
        }
    });
}
function Review() {
    var id = $("#employee").val(),
        month = $("#month").val();
    $.ajax({
        url: "/Requests/PlanDataview?Id=" + id + "&Month=" + month,
        type: 'POST',
        data: JSON.stringify({ Id: id, Month: month }),
        async: false,
        contentType: 'charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            $("#View").html(data);
            $("#approvebtn").removeAttr("disabled");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
