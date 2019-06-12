using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int? MenuId { get; set; }
        public ICollection<Menu> subMenu { get; set; }
    }
}
