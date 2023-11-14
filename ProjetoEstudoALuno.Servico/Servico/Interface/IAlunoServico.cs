using ProjetoEstudoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoALuno.Servico.Servico.Interface
{
    public interface IAlunoServico
    {
        void AdiciionarAluno(Aluno aluno);

        List<Aluno> ListarAlunos();

        void Update(Aluno aluno);

        Aluno ListarPorId(int id);

        void Deletar(int id);
    }
}
