using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class Categoria
    {
        public virtual ICollection<Prato> prato { get; set; }
        public virtual ICollection<Restaurante> restaurante { get; set; }
    }
}