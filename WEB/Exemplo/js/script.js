/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuUsuario = { nome: "Felipe" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomeusuario"]').val(MeuUsuario.nome);


        $('input[name="bntsalvar"]').click(function () {
            MeuUsuario.nome = $('input[name="nomeusuario"]').val();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(MeuUsuario.nome);
        });

    }
);