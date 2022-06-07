function Login() {
    var Username = $("#username").val(),
        Password = $("#password").val(),
        model = { Username: Username, Password: Password }
    if (Username !== "" && Password !== "") {
        $("#errorHandler").addClass("hide");
        $.ajax({
            url: "/Home/Authorize",
            type: 'POST',
            data: JSON.stringify({ model: model }),
            async: false,
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            success: function (data, textStatus, jqXHR) {
                if (data.success == "success") {
                    $("#errorHandler").addClass("hide");
                    window.location.href = data.link;
                }
                else {
                    $("#errorHandler").removeClass("hide").text(data.msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });

    } else {
        $("#errorHandler").removeClass("hide").text("Incorrect Information ..");
    }
}
$(document).ready(function () {
    $(document).keypress(function (e) {
        if (e.which == 13) {
            Login();
        }
    })
});
