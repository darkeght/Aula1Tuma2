//carregamento do documento
$(document).ready(function () {
    //adicionando uma função ao click do botão
    $('#Button1').click(function () {
        //conectando com api web
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
            //loop para cada objeto
            $.each(data, function (key, value) {
                //criamos uma variavel que irá armazenar a informação
                var templateContent = "";
                //iniciamos um separador de informação
                templateContent += "{";
                //outro laço para repetir para cada informação
                $.each(value, function (key, value) {
                    //adicionamos todas as informações do nosso objeto
                    templateContent += key + ":" + value + ",";
                });
                //finalizamos nosso objeto
                templateContent += "},";
                //adicionamos ao nosso campo de texto
                $('#divContent').append(
                    "<button onclick=\"alert('"+templateContent+"')\">" + value.bairro + "</button>"
                );
            });
        });
    });
});