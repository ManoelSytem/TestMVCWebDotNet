using DotNet5Crud.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5Crud.Controllers
{
    public class PersonController : Controller
    {
        private readonly CompanyDBContext _context;

        public PersonController(CompanyDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListPerson()
        {
          
           List<Person> listPerson = new List<Person>();
           
           
            
        }
    } 
  }