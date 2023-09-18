using DotNet5Crud.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5Crud.Controllers
{
    public class FactorialController : Controller
    {
        private readonly CompanyDBContext _context;

        public FactorialController(CompanyDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CalcFactorDelegate(int? numFactor)
        {
           
            if ( numFactor == null || numFactor < 0 )
            {
                return View();
            }
            else
            {  
              // usando delagate
               Func<double, double> fatorial = null;

              fatorial = x => x <= 1 ? 1 : x * fatorial(x - 1);

               var resultado = fatorial(numero);
                return View(resultado);
            }        
        }
        
        public async Task<IActionResult> Fatorial_LoopFor(int? numFactor)

        {

           
            if ( numFactor == null || numFactor < 0 )
            {
                return View();
            }
            else
            {  
              fatorial = numero;
              for (i = numero - 1; i >= 1; i--)
             {
                
                //Verificar output test
                Debug.WriteLine($"{fatorial} * {i}");
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"i={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
          }        
        }
      }
      
}