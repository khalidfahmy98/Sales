$(document).ready(function () {
    ReloadView();
});
function Edit(Id , Name , Hexa) {
    $("#savebtn").addClass("hide");
    $("#editbtn").removeClass("hide");
    $("#id").val(Id);
    $("#fullname").val(Name);
    $("#hexa").val(Hexa);
}
function Update() {
    $("#savebtn").removeClass("hide");
    $("#editbtn").addClass("hide");
    var name = $("#fullname").val(),
        id = $("#id").val(),
        hexa = $("#hexa").val(),
        model = { Id: id, Color: name, Hexa: hexa };
    if (name != "" && hexa != "" && id != "") {
        $.ajax({
            url: "/Colors/Edit",
            type: 'POST',
            data: JSON.stringify({ model : model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data == "success") {
                    ReloadView();
                    $("#id").val("");
                    $("#fullname").val("");
                    $("#hexa").val("");
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
        url: "/Colors/Del",
        type: 'POST',
        data: JSON.stringify({ Id: id }),
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data, textStatus, jqXHR) {
            if (data == "success") {
                //$(ele).parent("td").parent("tr").remove();
                ReloadView();
                $("#errorHandler").removeClass("hide").addClass("alert-success").removeClass("alert-danger").text("Type Color Deleted Successfully");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        }
    });
}
function ReloadView() {
    $.ajax({
        url: "/Colors/DataView",
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

