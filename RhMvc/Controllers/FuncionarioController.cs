using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RhMvc.Context;

namespace RhMvc.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly RhContext _context;

        public FuncionarioController(RhContext context)
        {
            _context = context;
        }

        public IActionResult Obter()
        {
            var funcionarios = _context.Funcionario.ToList();

            return View(funcionarios);
        }
    }
}