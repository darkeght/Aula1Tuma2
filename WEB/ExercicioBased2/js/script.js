/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuDoguinho = { marca: "Santa cruz", valor: 54999.00, peso: 11.30 };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="marca"]').val(MeuDoguinho.marca);
        $('input[name="valor"]').val(MeuDoguinho.valor);
        $('input[name="peso"]').val(MeuDoguinho.peso);


        $('input[name="bntsalvar"]').click(function () {
            MeuDoguinho.marca = $('input[name="marca"]').val();
            MeuDoguinho.valor = $('input[name="valor"]').val();  
            MeuDoguinho.peso = $('input[name="peso"]').val();  

            LimparTela();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(MeuDoguinho.marca + "\r\n" + MeuDoguinho.valor + "\r\n" + MeuDoguinho.peso);
        });
    }
);

function LimparTela() {
    //Obtemos todos os campos do tipo input
    var meusInputs = $('input[type="text"],input[type="number"]');
    //Loop para cada campo
     meusInputs.val("");
}