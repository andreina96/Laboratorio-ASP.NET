using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Laboratorio_ASP.NET.Models
{
    public class ModeloIntermedio
    {
        public Cliente modeloCliente { get; set; }
        public Cuenta modeloCuenta1 { get; set; }
        public Cuenta modeloCuenta2 { get; set; }
        public Cuenta modeloCuenta3 { get; set; }
        public Telefono modeloTelefono1 { get; set; }
        public Telefono modeloTelefono2 { get; set; }
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Cuenta> listaCuentas = new List<Cuenta>();
        public List<Telefono> listaTelefonos = new List<Telefono>();
    }
}