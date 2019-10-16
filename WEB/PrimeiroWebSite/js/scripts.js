$(document).ready(
    function () {
        /* Chamamos nossa função de intervalo */
        atualizaData();
});

/* Crimaos nossa primeira função */
function atualizaData() {
    /* Agora adicionamos a função dentro de nosso context
     * do setInterval */
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
    
}