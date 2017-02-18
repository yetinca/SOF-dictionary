$(document).ready(function () {
    $('table tbody').on('click', '#btn-delete', function() {
        $.ajax({
            url: "/Home/DeleteDict",
            type: "POST",
            data: { "id": $(this).parent().parent().attr('id') }, //id jest z kontrollera, this - to co klikneliśmy
            success: function (data) {
                if (data) {
                    $(this).parent().parent().remove();
                }
            }
        });
    });
});