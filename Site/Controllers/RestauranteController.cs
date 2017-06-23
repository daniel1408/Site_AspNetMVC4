using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class RestauranteController : Controller
    {
        public ActionResult IndexR()
        {
            var r = new AplicacaoR();
            var listaRestaurantes = r.Select();
            return View(listaRestaurantes);
        }

        public ActionResult CadastrarR()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarR(Restaurante r)
        {
                var restaurante = new AplicacaoR();
                restaurante.Insert(r);
                return RedirectToAction("IndexR");
        }

        public ActionResult EditarR(int id)
        {
            var r = new AplicacaoR();
            var restaurante = r.ListaId(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(restaurante);
        }

        [HttpPost]
        public ActionResult EditarR(Restaurante r)
        {
                var restaurante = new AplicacaoR();
                restaurante.Update(r);
                return RedirectToAction("IndexR");
        }


        public ActionResult ExcluirR(int id)
        {
            var r = new AplicacaoR();
            var restaurante = r.ListaId(id);    
            return View(restaurante);
        }

        [HttpPost, ActionName("ExcluirR")]
        public ActionResult ExcluirConfirmar(Restaurante r)
        {
            var restaurante = new AplicacaoR();
            restaurante.Delete(r);
           return RedirectToAction("IndexR");
        }
    }
}