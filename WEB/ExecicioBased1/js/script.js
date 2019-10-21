/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuDoguinho = { nome: "Felipe",idade:109,raca:"srd",coloracao:"caramelo"  };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nome"]').val(MeuDoguinho.nome);
        $('input[name="idade"]').val(MeuDoguinho.idade);
        $('input[name="raca"]').val(MeuDoguinho.raca);
        $('input[name="coloracao"]').val(MeuDoguinho.coloracao);


        $('input[name="bntsalvar"]').click(function () {
            MeuDoguinho.nome = $('input[name="nome"]').val();
            MeuDoguinho.idade = $('input[name="idade"]').val();  
            MeuDoguinho.raca = $('input[name="raca"]').val();  
            MeuDoguinho.coloracao = $('input[name="coloracao"]').val();

            LimparTela();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(MeuDoguinho.nome + "\r\n" + MeuDoguinho.idade + "\r\n" + MeuDoguinho.raca + "\r\n" + MeuDoguinho.coloracao);
        });
    }
);

function LimparTela() {
    //Obtemos todos os campos do tipo input
    var meusInputs = $('input[type="text"],input[type="number"]');
    //Loop para cada campo
     meusInputs.val("");
}