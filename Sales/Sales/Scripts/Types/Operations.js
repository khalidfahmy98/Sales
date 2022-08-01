$(document).ready(function () {
    ReloadView();
});
function Edit(Id, Name, condition , novisits , color) {
    $("#savebtn").addClass("hide");
    $("#editbtn").removeClass("hide");
    $("#id").val(Id);
    $("#name").val(Name);
    $("#novisits").val(novisits);
    $("#condition").val(condition);
    $("#color").val(color);
}
function Update() {
    $("#savebtn").removeClass("hide");
    $("#editbtn").addClass("hide");
    var name = $("#name").val(),
        id = $("#id").val(),
        condition = $("#condition").val(),
        novisits = i$("#novisits").val(novisits),
        color = $("#color").val(color),
        model = { Id: id , Type: name, NoVisits: novisits, ColorId: color, Condition: condition };
    if (name != "" && id != "" && novisits != "" ) {
        $.ajax({
            url: "/Types/Edit",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#id").val("");
                    $("#name").val("");
                    $("#novisits").val("");
                    $("#condition").val("");
                    $("#color").val("");
                    $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Updated Values Successfully");
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").removeClass("alert-success").text("Cant Update Empty Values .. !");
    }
}
function Del(id, ele) {
    $.ajax({
        url: "/Types/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Deleted Customer Type Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView() {
    $.ajax({
        url: "/Types/DataView",
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
