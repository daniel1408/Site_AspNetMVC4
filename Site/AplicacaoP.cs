using Entity;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Site
{
    public class AplicacaoP
    {
        private Contexto c = new Contexto();

        public void Insert(Models.Prato p)
        {
            c.pratos.Add(p);
            c.SaveChanges();
        }

        public void Update(Models.Prato p)
        {
            var pratoAlterar = c.pratos.First(x => x.idP == p.idP);
            pratoAlterar.idR = p.idR;
            pratoAlterar.prato = p.prato;
            pratoAlterar.preco = p.preco;
            c.SaveChanges();
        }

        public void Delete(Prato p)
        {
            var pratoExcluir = c.pratos.First(x => x.idP == p.idP);
            c.Set<Prato>().Remove(pratoExcluir);
            c.SaveChanges();
        }

        public IEnumerable<Prato> Select()
        {
            return c.pratos;
        }

        public Prato ListaId(int id)
        {
            return c.pratos.First(x => x.idP == id);
        }
    }
}