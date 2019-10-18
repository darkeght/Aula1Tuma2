/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        /*Valor padr�o ao carregar o site*/
        $('input[name="valoreal"]').val("9.999,99");

        //Informamos que no bot�o do click ele ira chamar nosso alerta
        $('input[name="bntconverter"]').click(function () {
            /* Nossa url que obtemos os valores da cota��o da moeda */
            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

            /* aqui nesta oarte temos a fun��o getJSON que obtem de uma api web as informa��es das cota��es*/
            $.getJSON(url, function (data) {
                /* obtemos da nossa api web o valor de venda da moeda  */
                var valordolar = data.value[0].cotacaoVenda;
                /*  Obter um valor */
                var valoreal = $('input[name="valoreal"]').val()
                    .replace(".", "")
                    .replace(".", "")
                    .replace(",", ".");

                /* aqui realizamos a conver�ao da moeda para real */
                var convercao = (valoreal / valordolar)
                    /* aqui temos o formato da moeda em um padr�o norte americano */
                    .toLocaleString('en-US', { minimumFractionDigits: 2, currency: 'USD' });

                /* Inserir um valor*/
                $('input[name="valordolar"]').val(convercao);
            });

        });

        //Aqui definimos uma mascara 
        $('input[name="valoreal"]').maskMoney({
            showSymbol: false,
            symbol: "R$",
            decimal: ",",
            thousands: "."
        });
    }
);
/* Aqui adicionamos ao on de nosso documento o evento keypress para ao pressionar enter o mesmo chamar o evento */
$(document).on('keypress', function (e) {
    if (e.which === 13) {
        /* Com isso temo nosso evento clicl ele desta maneira chama o nosso bot�o click */
        $('input[name="bntconverter"]').click();
    }
});