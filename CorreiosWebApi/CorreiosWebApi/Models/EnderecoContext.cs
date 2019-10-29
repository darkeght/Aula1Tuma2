namespace CorreiosWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EnderecoContext : DbContext
    {
        public EnderecoContext()
            : base("name=EnderecoContext")
        {
        }

         public virtual DbSet<Endereco> Enderecos { get; set; }
    }

}