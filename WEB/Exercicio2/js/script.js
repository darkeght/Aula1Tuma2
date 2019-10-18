/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        //Informamos que no botão do click ele ira chamar nosso alerta
        $('input[name="bntconverter"]').click(function () {

            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

            $.getJSON(url, function (data) {

                var valordolar = data.value[0].cotacaoVenda;
                /*  Obter um valor */
                var valoreal = $('input[name="valoreal"]').val()
                    .replace(".", "")
                    .replace(".", "")
                    .replace(",", ".");


                var convercao = (valoreal / valordolar)
                    .toLocaleString('en-US', { minimumFractionDigits: 2, currency: 'USD' });

                /* Inserir um valor*/
                $('input[name="valordolar"]').val(convercao);
            });

        });

        //Colocamos a mask em nosso campo 999.999,00
        //$('input[name="valoreal"]').mask("000.000,00");
        $('input[name="valoreal"]').maskMoney({
            showSymbol: false,
            symbol: "R$",
            decimal: ",",
            thousands: "."
        });
    }
);

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="bntconverter"]').click();
    }
});