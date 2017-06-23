using Entity;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Site
{
    public class AplicacaoR
    {
        private Contexto c;
        public void Insert(Models.Restaurante r)
        {
            c.restaurantes.Add(r);
            c.SaveChanges();
        }

        public void Update(Models.Restaurante r)
        {
            var restauranteAlterar = c.restaurantes.First(x => x.idR == r.idR);
            restauranteAlterar.nome = r.nome;
            c.SaveChanges();
        }

        public void Delete(Restaurante r)
        {
            var restauranteExcluir = c.restaurantes.First(x => x.idR == r.idR);
            c.Set<Restaurante>().Remove(restauranteExcluir);
            c.SaveChanges();
        }

        public IEnumerable<Restaurante> Select()
        {
            return c.restaurantes;
        }

        public Restaurante ListaId(int id)
        {
            return c.restaurantes.First(x => x.idR == id);
        }
    }
}