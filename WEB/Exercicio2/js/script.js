/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        //Informamos que no botão do click ele ira chamar nosso alerta
        $('input[name="bntconverter"]').click(function () {

            var valordolar = 4.16;
            var valoreal = $('input[name="valoreal"]').val()
                .replace(".", "")
                .replace(",", ".");
            

            var convercao = (valoreal / valordolar)
                .toFixed(2)
                .toString()
                .replace(/(\d)(\d{2})$/, "$1,$2");

            $('input[name="valordolar"]').val(convercao);
        });

        //Colocamos a mask em nosso campo 999.999,00
        $('input[name="valoreal"]').mask("000.000,00");

        //usando api externa
        $.getJSON("https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-17-2019%27&$top=100&$format=json", function (data) {
            var teste = data.value[0].cotacaoCompr;
            //data[0].valoreconvertido analisar o codigo pelo debug para verificar os valores
        });
    }
);

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});