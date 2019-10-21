$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                $.get("https://viacep.com.br/ws/38402100/json/", function (data) {
                    $('input[name="bairro"]').val(data.bairro);
                });
            }
        );
    }
);