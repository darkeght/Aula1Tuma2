$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                $.get("https://viacep.com.br/ws/38402100/json/", function (data) {
                    $('input[name="bairro"]').val(data.bairro);
                });


                $.get("https://cataas.com/cat/gif/says/Hello?filter=sepia&color=orange&size=10&type=or", function (data) {
                    $('input[name="bairro"]').attr("src",data);
                });
            }
        );
    }
);