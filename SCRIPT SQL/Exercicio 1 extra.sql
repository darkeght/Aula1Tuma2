INSERT INTO Flores (Nome,Quantidade) VALUES 
('Rosa',3),
('Magarida',4),
('Copo de leite',2),
('11 horas',5),
('Violeta',4)
-- 1.3 - Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade para a menor
SELECT -- comando de seleção do banco de dados 
*  -- com * falamos que vamos retornar todos os campos de nosso select
FROM -- From indica a tabela que vamos selecionar para a contagem de linhas
Flores -- Nossa primeira tabela de seleção ela representa a quantidade de 
-- linhas que o select irá realizar
ORDER BY -- aqui colocamos o comando de ordenação de dados o by indica que ele
-- espera um campo de nossa tabela selecionada para realizar a ordenação
Quantidade -- aqui especifiquei o campo que vamos ordernar 
DESC -- Aqui informo que vamos ordernar do maior para o menos 
-- por padrão a ordenação já é realizada do menor para o maior
-- 	1.3 - Devemos retornar uma seleção com a quantidade total de flores que temos em nossa tabela
SELECT 
COUNT(*) -- aqui contamos a quantidade de registro dentro do nosso select
-- não discriminando um campo especificamente 
FROM Flores -- nossa tabela de dados 