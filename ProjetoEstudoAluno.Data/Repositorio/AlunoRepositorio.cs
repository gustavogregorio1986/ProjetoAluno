using ProjetoEstudoAluno.Data.Contexto;
using ProjetoEstudoAluno.Data.Repositorio.Interface;
using ProjetoEstudoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoAluno.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _db;

        public AlunoRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void AdiciionarAluno(Aluno aluno)
        {
            _db.Add(aluno);
        }

        public void Deletar(int id)
        {
            _db.Remove(id);
        }

        public List<Aluno> ListarAlunos()
        {
            return _db.Alunos.ToList();
        }

        public Aluno ListarPorId(int id)
        {
            return _db.Alunos.FirstOrDefault(x => x.IdCliente == id);
        }

        public void Update(Aluno aluno)
        {
            _db.Update(aluno);
        }
    }
}
