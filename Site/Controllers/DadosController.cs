using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class DadosController : Controller
    {
        public ActionResult IndexP()
        {
            var p = new AplicacaoP();
            var listaPratos = p.Select();
            return View(listaPratos);
        }       


        public ActionResult CadastrarP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarP(Prato p)
        {
                var prato = new AplicacaoP();
                prato.Insert(p);
                return RedirectToAction("IndexP");
        }


        public ActionResult EditarP(int id)
        {
            var p = new AplicacaoP();
            var prato=p.ListaId(id);
            return View(prato);
        }
        [HttpPost]
        public ActionResult EditarP(Prato p)
        {
                var prato = new AplicacaoP();
                prato.Update(p);
                return RedirectToAction("IndexP");
        }


        public ActionResult ExcluirP(int id)
        {
            var r = new AplicacaoP();
            var restaurante = r.ListaId(id);
            return View(restaurante);
        }
        [HttpPost, ActionName("ExcluirP")]
        public ActionResult ExcluirConfirmar(Prato p)
        {
            var prato = new AplicacaoP();
            prato.Delete(p);
            return RedirectToAction("IndexP");
        }

    }
}