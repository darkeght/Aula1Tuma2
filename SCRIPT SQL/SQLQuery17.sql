insert into Usuarios
(Nome,Login,Senha)
values
('Adagoberto','urineidson','66tapanasoreia')
GO
select * from Usuarios
update Usuarios set Ativo = 0 where Id in (11,9,8,7) 