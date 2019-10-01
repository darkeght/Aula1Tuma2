update Usuarios
set Login = 'não informado'
where Login is null
GO
select * from Usuarios