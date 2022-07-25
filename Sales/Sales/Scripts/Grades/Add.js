function Add() {
    var name = $("#name").val(),
        comment = $("#comment").val(),
        model = { Grade: name, Quote: comment};
    if (name !== "" && comment !== "") {
    } else {
        $("#errorHandler").removeClass("hide").addClass("alert-danger").text("Cant Register Empty Values .");
    }
}