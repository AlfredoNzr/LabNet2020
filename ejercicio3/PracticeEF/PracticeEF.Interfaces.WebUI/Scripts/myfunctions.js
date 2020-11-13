$(document).ready(function () {

    $('#frmInsertUpdate').submit(function (ev) {
        $.ajax({
            type: $('#frmInsertUpdate').attr('method'),
            url: $('#frmInsertUpdate').attr('action'),
            data: $('#frmInsertUpdate').serialize(),
            success: function (data) {
                    $(".modal-title").html(data.title);
                    $(".modal-body").html(data.message);
                    $("#modal").show();
            },
            error: function (data) {
                    $(".modal-title").html(data.title);
                    $(".modal-body").html(data.message);
                    $("#modal").show();
            }
        });
        ev.preventDefault();
    });

    $("#btnClose").click(function () {
        $("#modal").hide();
    });

});