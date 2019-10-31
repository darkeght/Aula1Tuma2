namespace RegistroImoveis.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RegistroImoveis.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroImoveis.Models.RegistroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroContext context)
        {
            var listProprietarios = new List<Proprietario>() {
                new Proprietario(){
                    Nome = "Felipe",
                    DataNascimento = DateTime.Parse("03/08/1992"),
                    Email = "contato@usysweb.com.br"
                },
                new Proprietario()
                {
                    Nome = "Giomar",
                    DataNascimento = DateTime.Parse("24/01/1836"),
                    Email = "contato@pulsaopubmatico.org"
                }
            };

            listProprietarios.ForEach(s =>
                context.Proprietarios.AddOrUpdate(x => x.Nome, s)
            );

            context.SaveChanges();

            var listaImoveis = new List<Imovel>()
            {
                new Imovel(){
                    Cep = "89130000",
                    Bairro = "Tapajos",
                    Logradouro = "Rua Brasilia",
                    Municipio = "Indaial",
                    Numero = "210",
                    Complemento = "próximo ao carambas",
                    ProprietarioId = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Felipe").Id
                },
                new Imovel(){
                    Cep = "89130000",
                    Bairro = "Tapajos",
                    Logradouro = "Rua Mina Gerais",
                    Municipio = "Indaial",
                    Numero = "856",
                    Complemento = "ao la do do bar do zeca",
                    ProprietarioId = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Giomar").Id
                }
            };

            listaImoveis.ForEach(s =>
                context.Imovels.AddOrUpdate(x => new { x.ProprietarioId, x.Cep}, s)
            );

            context.SaveChanges();
        }
    }
}
