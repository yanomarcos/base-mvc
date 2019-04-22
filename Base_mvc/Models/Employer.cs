using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base_mvc.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Department Departamento { get; set; }

        public Employer()
        {
        }

        public Employer(int id, string nome, string email, DateTime dataNascimento, Department departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }
    }
}
