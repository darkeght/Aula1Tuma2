select 
fun.Nome,
SUM(sal.Valor) as 'Total no 3 meses' -- Mostra o valor total nos 3 mesmes
from Funcionarios fun 
     inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome -- Apresenta o total de 3 meses por funcionario e agrupa  por nome as informações de salario




select 
fun.Nome,
AVG(sal.Valor) as 'Média no 3 meses', -- obtem a média dos valores
COUNT(sal.Valor) as 'Qunt Pagamentos', -- obtem a quantidade de registro para aquele cliente
SUM(sal.Valor) / COUNT(sal.Valor) as 'Nova média', -- Realiza de outra forma a média de valores
SUM(sal.Valor) as 'Total' -- Valor total acumulado nos 3 meses 
from Funcionarios fun -- Nossa tabela de funcionarios 
     inner join Salarios sal on fun.Id = sal.FuncionarioId -- Nosso inner join
group by fun.Nome -- Aqui agrupamos por nomes os valores de salario
order by SUM(sal.Valor)  desc -- Ordernamos do maior para o menor


select * from Salarios
where Id between 3 and 8  -- selecionamos valores entre 3 e 8

select * from Salarios 
where DataCriacao between '07/06/2019' and '08/07/2019' -- valores entre as datas informadas


select top 5 * from Salarios -- Obtemos  os 5 primeiros registros de acordo com a ordenação
order by Valor desc -- Ordernamos do maior valor para o menos

select * from Salarios 
where Id >= 3 and Id <= 8 -- Mesma coisa que o between faz

update Funcionarios
set 
 DataSaida = '10/03/2019', -- setamos a data da demissao
 DataAlteracao = GETDATE(), -- setamos a data da alteração do registro
 Ativo = 0
where Nome like 'Mustafa%' -- Update pelo like ele encontra todos os nomes que iniciam com Mustafa

select  * from Funcionarios where Nome like 'Mu%' -- Nomes ou texto iniciando com Mu
select  * from Funcionarios where Nome like '%fa' -- Nome ou Texto finalizando com mu
select  * from Funcionarios where Nome like '%a%' -- Texto ou nome que contem a vogal a


select 
Nome,
CONVERT(VARCHAR(10),DataInicio,103) as 'Inicio', -- Aqui convertemos as data para o formato brasileiro
CONVERT(VARCHAR(10),DataSaida,103) as 'Saida' -- Aqui convertemos as data para o formato brasileiro
from Funcionarios

