$(document).ready(function () {
    ReloadView();
});
function Edit(Id, Name, Hexa) {
    $("#savebtn").addClass("hide");
    $("#editbtn").removeClass("hide");
    $("#id").val(Id);
    $("#name").val(Name);
    $("#comment").val(Hexa);
}
function Update() {
    $("#savebtn").removeClass("hide");
    $("#editbtn").addClass("hide");
    var name = $("#name").val(),
        id = $("#id").val(),
        comment = $("#comment").val(),
        model = { Id: id, Area: name, Comment: comment };
    if (name != "" && hexa != "" && id != "") {
        $.ajax({
            url: "/Areas/Edit",
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
                    $("#comment").val("");
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
        url: "/Areas/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                ReloadView();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Deleted Customer Areas Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView() {
    $.ajax({
        url: "/Areas/DataView",
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
