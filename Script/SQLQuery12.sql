update Usuarios
set Login = 'n�o informado'
where Login is null
GO
select * from Usuarios