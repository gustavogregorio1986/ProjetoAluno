using ProjetoEstudoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoAluno.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        void AdiciionarAluno(Aluno aluno);

        List<Aluno> ListarAlunos();

        void Update(Aluno aluno);

        Aluno ListarPorId(int id);

        void Deletar(int id);


    }
}
