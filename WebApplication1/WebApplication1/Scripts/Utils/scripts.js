//carregamento do documento

var data = [
    {
        "cep": "91710-480",
        "logradouro": "Rua Dallas",
        "complemento": "",
        "bairro": "Cascata",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91220-420",
        "logradouro": "Rua Oscar Allem",
        "complemento": "",
        "bairro": "Jardim Itu",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90680-310",
        "logradouro": "Rua Allan Kardec",
        "complemento": "",
        "bairro": "Partenon",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91060-530",
        "logradouro": "Rua Lasar Segall",
        "complemento": "",
        "bairro": "São Sebastião",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90130-120",
        "logradouro": "Travessa La Salle",
        "complemento": "",
        "bairro": "Menino Deus",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91380-010",
        "logradouro": "Rua Arnaldo Ballve",
        "complemento": "",
        "bairro": "Jardim Itu",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91150-796",
        "logradouro": "Rua Edgar Allan Poe",
        "complemento": "",
        "bairro": "Santa Rosa de Lima",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91520-600",
        "logradouro": "Rua Marechal Mallet",
        "complemento": "",
        "bairro": "Vila João Pessoa",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91340-001",
        "logradouro": "Avenida João Wallig",
        "complemento": "de 1156/1157 ao fim",
        "bairro": "Passo da Areia",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91030-120",
        "logradouro": "Rua Vicente Pallotti",
        "complemento": "",
        "bairro": "Passo da Areia",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91260-170",
        "logradouro": "Rua João Dallegrave",
        "complemento": "",
        "bairro": "Morro Santana",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91340-000",
        "logradouro": "Avenida João Wallig",
        "complemento": "até 1154/1155",
        "bairro": "Passo da Areia",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90840-660",
        "logradouro": "Rua José Lino Avallone",
        "complemento": "",
        "bairro": "Santa Tereza",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91750-520",
        "logradouro": "Rua Vincenzo Gallicchio",
        "complemento": "",
        "bairro": "Vila Nova",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91740-085",
        "logradouro": "Rua Generino Dalla Valle",
        "complemento": "",
        "bairro": "Cavalhada",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91349-900",
        "logradouro": "Avenida João Wallig 1800",
        "complemento": "",
        "bairro": "Passo da Areia",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91710-110",
        "logradouro": "Travessa Clemêncio Wallau",
        "complemento": "",
        "bairro": "Coronel Aparício Borges",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91230-135",
        "logradouro": "Rua Rosane Valls Hofmeister",
        "complemento": "",
        "bairro": "Passo das Pedras",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91120-370",
        "logradouro": "Praça Elias Jorge Moussalle",
        "complemento": "",
        "bairro": "Sarandi",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91770-330",
        "logradouro": "Rua Doutora Noemi Valle Rocha",
        "complemento": "",
        "bairro": "Serraria",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90250-570",
        "logradouro": "Rua Padre Ignácio Rafael Valle",
        "complemento": "",
        "bairro": "Farrapos",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90520-105",
        "logradouro": "Praça Frederico Arnaldo Ballvé",
        "complemento": "",
        "bairro": "Passo da Areia",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90830-600",
        "logradouro": "Rua Grêmio Foot-Ball Porto Alegrense",
        "complemento": "",
        "bairro": "Cristal",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91430-140",
        "logradouro": "Praça Monsenhor Avelino Dalla Vecchia",
        "complemento": "",
        "bairro": "Jardim Carvalho",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "90880-400",
        "logradouro": "Praça Grêmio Foot-Ball Porto Alegrense",
        "complemento": "",
        "bairro": "Medianeira",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    },
    {
        "cep": "91770-320",
        "logradouro": "Avenida Doutor Francisco Roberto Dall'Igna",
        "complemento": "",
        "bairro": "Espírito Santo",
        "localidade": "Porto Alegre",
        "uf": "RS",
        "unidade": "",
        "ibge": "4314902",
        "gia": ""
    }
];

$(document).ready(function () {
    //adicionando uma função ao click do botão
    $('#Button1').click(function () {
        //conectando com api web
        //$.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
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
                    "<button onclick=\"alert('" + templateContent + "')\">" + value.bairro + "</button>"
                );
            });
        //});
    });
});