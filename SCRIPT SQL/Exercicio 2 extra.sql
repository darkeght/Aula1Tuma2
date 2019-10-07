-- 2.2  - Agora devemos inserir 2 funcionarios diferentes
INSERT INTO Funcionarios (Nome) Values
('Felipe'),
('Giomar');
-- 2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
INSERT INTO Produtos (Nome,Valor) Values
('Skol Beats Senses 313ml',5.49), -- Unidades
('Budweiser 550ml',6.99),-- Unidades
('Stella Artois 275ml',3.49),-- Unidades
('Patagonia Bohemian Pil 740ml',15.90),-- Unidades
('Corona Extra 355ml',4.99)-- Unidades
--2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5
SELECT * FROM Funcionarios;
SELECT * FROM Produtos;
INSERT INTO Pedidos (FuncionarioId,ProdutoId,Quantidade) Values
(1, -- Id do Felipe
12, -- Id da Cerveja Patagonia
2), -- Quantidade do item 
/* -Aqui mais um novo registro- */
(1, -- Id de Felipe
11, -- Id Stella
5), -- Quantidade do item
/* -Aqui mais um novo registro- */
(2, -- Id do Giomar
10, -- Id da Bud
4); -- Quantidade
-- 2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
SELECT * FROM Funcionarios ORDER BY Nome
-- 2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
SELECT * FROM Produtos ORDER BY Valor DESC
-- 2.7  - Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
SELECT
ped.Id,
fun.Nome,
ped.ProdutoId,
ped.Quantidade
FROM Pedidos ped 
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
-- 2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
SELECT 
fun.Nome,
SUM(ped.Quantidade) as 'Quantidade'
FROM Pedidos ped 
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
GROUP BY fun.Nome
-- 2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total 
SELECT 
fun.Nome,
SUM(ped.Quantidade * pro.Valor) as 'Total'
FROM Pedidos ped 
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
inner join Produtos pro on ped.ProdutoId = pro.Id
GROUP BY fun.Nome;
select * from Produtos;
select * from Pedidos;
-- 2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
SELECT TOP 1
       pro.Nome,
       SUM(ped.Quantidade) as 'Quantidade' FROM Produtos pro 
inner join Pedidos ped on pro.Id = ped.ProdutoId
GROUP BY pro.Nome
ORDER BY SUM(ped.Quantidade) DESC
-- 2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
SELECT TOP 1
pro.Nome,
SUM(ped.Quantidade * pro.Valor) as 'ReceitaTotal'
FROM Produtos pro 
inner join Pedidos ped on pro.Id = ped.ProdutoId
GROUP BY pro.Nome
ORDER BY 'ReceitaTotal' DESC
-- 2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado
SELECT * FROM Produtos -- Seleçao da tabela de produtos aqui vamos listar todos os produtos
WHERE Id not in -- O 'not in' indica que não queremos o que contem dentro de nossa lista de informações 
(SELECT ped.ProdutoId FROM Funcionarios fun          -- Realizamos um sub-select  para retornar todos 
inner join Pedidos ped on fun.Id = ped.FuncionarioId -- os itens que ja solicitamos por funcionario do mercado
WHERE fun.Nome like 'Felipe%') -- Aqui filtramos pelo nome os pedidos especificos de felipe
-- 2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado
SELECT pro.Nome, -- O campo nome e usado para agrupar as informações 
COUNT(ped.ProdutoId) as 'Quantidade' -- Aqui retornamos a quantidade que foi realizado um pedido com aquele item e não a quantidade
-- de unidades pedida para aquele item, assim conseguimos saber a frequencia que este pedido e solicitado
FROM Produtos pro  -- Selecionamos a tabela produtos para retornar todos os produtos 
left join -- O 'left join' ignora se nossa tabela da direta contem ou não a informação de relação
-- dando prioridade para os registro da nossa tabela da esquerda
-- ou seja left retorna sempre todos os registro da esquerda mesmo não contendo na direita
Pedidos ped on pro.Id = ped.ProdutoId -- os condicionais dentro do left join não mudam comparados com inner join
GROUP BY pro.Nome -- Agrupamos por nome os pedidos pois em pedidos podemos ter itens solicitados mais de uma vez
ORDER BY 'Quantidade' DESC -- E finalmente ordenamos pela quantidade solicitada do item em nossa tabela de pedidos




