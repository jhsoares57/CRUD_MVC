using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente
    {
        public string nome { get; set; }
        public List<Cliente> Clientes(string cliente)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { nome = "hugo" });
            return clientes;
        }
    }
}
