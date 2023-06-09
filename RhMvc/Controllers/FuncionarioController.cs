using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RhMvc.Context;
using RhMvc.Models;

namespace RhMvc.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly RhContext _context;

        public FuncionarioController(RhContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var funcionarios = _context.Funcionario.ToList();

            return View(funcionarios);
        }

        public IActionResult Criar()
        {
            return View();
        }
                
        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}