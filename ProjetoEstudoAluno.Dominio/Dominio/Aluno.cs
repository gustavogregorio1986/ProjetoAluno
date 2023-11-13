using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEstudoAluno.Dominio.Dominio
{
    [Table("tb_Aluno")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        public string NomeAluno { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Total { get; set; }

        public double Recuperacao { get; set; }

        public double TotalRecuperacao { get; set; }

        public string Situacao { get; set; }
    }
}
