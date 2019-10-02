select  * from Clientes;
select * from Pedidos;

select -- Inicianod o select
ped.*  -- Aqui temos todas as colunas da nossa tabela pedidos apenas
from Pedidos ped  -- seleção da nossa tabela de pediso
   inner join -- Terminador sql que junta as duas informações
   Clientes cli on ped.ClienteId = cli.Id -- Validamos o que conecta as informações
where cli.Nome = 'Felipe'; -- Aqui aplicamos um filtro para estas informações

select -- Inicianod o select
IIF( -- Iniciamos um if dentro de um select o mesmo pode mostrar ou nao uma informação
SUM(ped.Valor) -- Somamos os valores do pedido de cada pedido do nosso cliente que temos em nossa base
> 2000 -- aplicamos uma regra para o sorteo do nosso brinde
,'Brinde XIAOMI' -- caso positivo temos o brinde
,'Não Ganhou nada' -- caso valor negativo não temos brinde
) as 'Resultado', -- Damos um nome ao nosso resultado
SUM(ped.Valor) as 'Total' -- Aqui apresentamos o valor total do pedido
from Pedidos ped -- tabela de pedidos 
   inner join Clientes cli on ped.ClienteId = cli.Id -- inner join e nossas validações para as relações
where cli.Nome = 'Felipe' -- nosso filtro


select 
IIF(SUM(ped.Valor) > 2000,'Brinde XIAOMI','Não Ganhou nada') as 'Resultado',
SUM(ped.Valor) as 'Total',
cli.Nome
from Pedidos ped 
   inner join Clientes cli on ped.ClienteId = cli.Id
group by cli.Nome -- ao remover o where  e apresentar todos os valores tremos o 
-- group by, junta as informações pelo campo que estamos informando

select 
IIF(SUM(ped.Valor) > 2000,'Brinde XIAOMI','Não Ganhou nada') as 'Resultado',
SUM(ped.Valor) as 'Total',
cli.Nome
from Clientes cli 
	inner join Pedidos ped on cli.Id = ped.ClienteId 
group by cli.Nome