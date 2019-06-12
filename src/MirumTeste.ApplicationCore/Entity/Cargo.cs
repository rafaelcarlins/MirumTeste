using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.ApplicationCore.Entity
{
    public class Cargo
    {
        public Cargo()
        {

        }

        public int Id { get; set; }
        public string Funcao { get; set; }
        public decimal SalarioBase { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
