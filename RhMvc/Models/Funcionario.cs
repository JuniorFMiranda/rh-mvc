using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhMvc.Models
{
    public sealed class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }        
        public bool Ativo { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}