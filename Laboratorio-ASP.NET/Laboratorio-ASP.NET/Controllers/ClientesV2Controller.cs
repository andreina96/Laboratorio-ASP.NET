using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_ASP.NET.Models;

namespace Laboratorio_ASP.NET.Controllers
{
    public class ClientesV2Controller : Controller
    {
        LaboratorioMVCEntities db = new LaboratorioMVCEntities();

        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaClientes = db.Cliente.ToList();
            modelo.listaCuentas = db.Cuenta.ToList();
            modelo.listaTelefonos = db.Telefono.ToList();
            return View(modelo);        }
    }
}