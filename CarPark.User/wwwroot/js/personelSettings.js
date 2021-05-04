function readUrl(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $(".personelImgUrl").attr('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}

$("#personelImg").change(function () {
    $(".imgArea").LoadingOverlay("show");
    readUrl(this);
    $(".imgArea").LoadingOverlay("hide");
})


var onFailed = function () {
    $.LoadingOverlay("hide");
}
var onSuccess = function (response) {
    $.LoadingOverlay("hide");
    if (response.success) {
        $("#nameSurnameArea").html(response.personel.name + " " + response.personel.surname);
        Swal.fire(
            'Başarılı',
            response.message,
            'success'
        )
    }
    else {
        Swal.fire(
            'Hata!',
            response.message,
            'error'
        )
    }

}
var onBegin = function () {
    $.LoadingOverlay("show");
}