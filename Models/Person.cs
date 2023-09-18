using System;
using System.Collections.Generic;


#nullable disable

namespace DotNet5Crud.Models
{
    public partial class Person
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; } 
        
        public Person() { }

        public Person(string nome, int idade, string email)
        {
           Nome = nome;
           Idade = idade;
           Email = email;
        }
    }
}