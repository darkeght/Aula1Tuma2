select gen.Nome as 'Genero',
       art.Nome as 'Artista', 
	   can.Nome as 'Cancao'  from  Generos gen
	   inner join Artistas art on gen.Id = art.GeneroId
	   inner join Cancoes can  on art.Id = can.ArtistaId

select gen.Nome as 'Genero',
       COUNT(art.Nome) as 'Quantidade Artistas'
	   from Generos gen 
	   inner join Artistas art on gen.Id = art.GeneroId
group by gen.Nome

select gen.Nome as 'Genero',
       COUNT(can.Nome) as 'Quantidades de Canções'
	   from Generos gen 
	   inner join Artistas art on gen.Id = art.GeneroId
	   inner join Cancoes can  on art.Id = can.ArtistaId
group by gen.Nome