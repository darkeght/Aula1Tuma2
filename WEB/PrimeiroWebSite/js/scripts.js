$(document).ready(
    function () {
        /* Chamamos nossa fun��o de intervalo */
        atualizaData();
});

/* Crimaos nossa primeira fun��o */
function atualizaData() {
    /* Agora adicionamos a fun��o dentro de nosso context
     * do setInterval */
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
    
}