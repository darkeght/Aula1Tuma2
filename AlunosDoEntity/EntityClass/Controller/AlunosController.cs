using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Controller
{
    public class AlunosController
    {
        //Este novo objeto representa nosso banco de dados
        EntityAlunosContext context = new EntityAlunosContext();
        public IQueryable<Aluno> GetAlunos()
        {
            //Retorna os alunos dentro do sistema
            return context.Alunos;
        }

        public void AddAluno(Aluno item)
        {
            //Adiciono meu aluno na minha lista em memoria 
            context.Alunos.Add(item);
            //Salvo essa informação no banco de dados
            context.SaveChanges();
        }
    }
}
