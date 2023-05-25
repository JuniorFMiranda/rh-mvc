using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhMvc.Models
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }        
        public EnumStatusFuncionario Status { get; set; }
    }
}