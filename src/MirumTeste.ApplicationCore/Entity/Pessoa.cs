using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.ApplicationCore.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Rg { get; set; }
        public string Email { get; set; }
        public ICollection<Cargo> Cargos { get; set; }
        public int CargoId { get; set; }
    }
}
