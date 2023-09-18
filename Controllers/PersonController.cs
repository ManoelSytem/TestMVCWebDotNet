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

        public async Task<IActionResult> ListPersonFilter(string filterValueAlternaive)
        {
          if(String.IsNullOrEmpty(filterValueAlternaive){
             
           List<Person> listperson = new List<Person>
              {
              new Person { Name = "Mahesh Chand", Idade = 23, Email = "Mah@tes.com" },
              new Person { Name = "Venessa da Mata", Idade = 38, Email = "vanm@tes.com" },
              
              new Person { Name = "Bell Marques", Idade = 70 , Email = "bell@tes.com" },
              
               new Person { Name = "Claudia Duarte", Idade = 30 , Email = "claudia@emp.com" },
               
              new Person { Name = "Belizario Dos Santos", Idade = 30 , Email = "beel@emp.com" }
              
              };
              
              Lista<Person> filtrado = 
              listperson.FindAll(p => p. > 30);
              
              //Ver output
              Console.WriteLine(string.Join(',', filtrado));
              Debug.WriteLine(string.Join(',', filtrado));
              }
        }
    } 
  }