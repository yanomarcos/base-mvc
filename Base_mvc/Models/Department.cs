using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base_mvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Employer> Employers { get; set; } = new List<Employer>();

        public Department()
        {
        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
