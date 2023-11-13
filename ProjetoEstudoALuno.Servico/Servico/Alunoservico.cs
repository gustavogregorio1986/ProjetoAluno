using ProjetoEstudoAluno.Data.Repositorio.Interface;
using ProjetoEstudoAluno.Dominio.Dominio;
using ProjetoEstudoALuno.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoALuno.Servico.Servico
{
    public class Alunoservico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public Alunoservico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdiciionarAluno(Aluno aluno)
        {
            _repositorio.AdiciionarAluno(aluno);
        }

        public void Deletar(int id)
        {
            _repositorio.Deletar(id);
        }

        public List<Aluno> ListarAlunos()
        {
            return _repositorio.ListarAlunos();
        }

        public Aluno ListarPorId(int id)
        {
            return _repositorio.ListarPorId(id);
        }

        public void Update(Aluno aluno)
        {
            _repositorio.Update(aluno);
        }
    }
}
