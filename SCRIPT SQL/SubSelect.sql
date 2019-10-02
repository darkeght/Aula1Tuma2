select  * from Clientes;
select  * from Pedidos;

select * from Pedidos ped  -- nossa tabela de quetemos o registros
where ped.ClienteId in (select cli.Id from Clientes cli -- sub slect em nossa base de dados
		 inner join Pedidos ped on cli.Id = ped.ClienteId -- Validados 
where ped.Numero in ('N000000001','N000000006','N000000013')) -- selecionando os valores pelos pedisos
order by ped.Valor desc -- ordenando os valores