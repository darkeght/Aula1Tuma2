/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        //Informamos que no botão do click ele ira chamar nosso alerta
        $('input[name="btnboasvindas"]').click(function () {
            /* Aqui obtemos o valor digitado pelo usuario */
            var nomeusuario = $('input[name="nomeusuario"]').val();
            /* Apresentamos nosso alerta de boas vinda */
            alert("Seja bem vindo " + nomeusuario + " ao nosso sistema de cervejaria.");
        });
    }
);

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="btnboasvindas"]').click();
    }
});