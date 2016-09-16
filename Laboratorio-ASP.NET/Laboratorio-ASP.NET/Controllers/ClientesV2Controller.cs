using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
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

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente c = db.Cliente.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.modeloCliente = c;
            List<Telefono> telefonos = new List<Telefono>();
            telefonos = db.Telefono.Where(a => a.Cedula == c.Cedula).ToList();
            int countt = telefonos.Count();
            if (countt == 1)
            {
                modelo.modeloTelefono1 = telefonos.ElementAt(0);
            }
            else if (countt == 2)
            {
                modelo.modeloTelefono2 = telefonos.ElementAt(1);
            }

            List<Cuenta> cuentas = new List<Cuenta>();
            cuentas = db.Cuenta.Where(a => a.Cedula == c.Cedula).ToList();
            int countc = cuentas.Count();
            if (countc == 1)
            {
                modelo.modeloCuenta1 = cuentas.ElementAt(0);
            }
            else if (countc == 2)
            {
                modelo.modeloCuenta2 = cuentas.ElementAt(1);
            }
            else if( countc == 3)
            {
                modelo.modeloCuenta3 = cuentas.ElementAt(2);
            }

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(modelo.modeloCliente);
                db.SaveChanges();
                if (modelo.modeloTelefono1.Numero != null)
                {
                    modelo.modeloTelefono1.Cedula = modelo.modeloCliente.Cedula;
                    db.Telefono.Add(modelo.modeloTelefono1);
                }
                if (modelo.modeloTelefono2.Numero != null)
                {
                    modelo.modeloTelefono2.Cedula = modelo.modeloCliente.Cedula;
                    db.Telefono.Add(modelo.modeloTelefono2);
                }
                if (modelo.modeloCuenta1.Numero != null && modelo.modeloCuenta1.Tipo != null)
                {
                    modelo.modeloCuenta1.Cedula = modelo.modeloCliente.Cedula;
                    db.Cuenta.Add(modelo.modeloCuenta1);
                }
                if (modelo.modeloCuenta2.Numero != null && modelo.modeloCuenta2.Tipo != null)
                {
                    modelo.modeloCuenta2.Cedula = modelo.modeloCliente.Cedula;
                    db.Cuenta.Add(modelo.modeloCuenta2);
                }
                if (modelo.modeloCuenta3.Numero != null && modelo.modeloCuenta3.Tipo != null)
                {
                    modelo.modeloCuenta3.Cedula = modelo.modeloCliente.Cedula;
                    db.Cuenta.Add(modelo.modeloCuenta3);
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}