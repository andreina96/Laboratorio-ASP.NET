using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_ASP.NET.Models
{
    public class ModeloIntermedio
    {
        public Cliente modeloCliente { get; set; }
        public Cuenta modeloCuenta { get; set; }
        public Telefono modeloTelefono { get; set; }
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Cuenta> listaCuentas = new List<Cuenta>();
        public List<Telefono> listaTelefonos = new List<Telefono>();
    }
}