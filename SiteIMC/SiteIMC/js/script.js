$(document).ready(function () {

    $('input[name="btncalcular"]').click(function () {

        var informacoes = $('form[name="formimc"]').serialize();

        var url = "http://localhost:54615/api/CalculoIMC?";

        $.get(url + informacoes, function (data) {

            alert(data);

        });

    });

});