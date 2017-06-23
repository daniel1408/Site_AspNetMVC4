using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Contrato
{
    interface IRepositorio <T> where T:class
    {
        void Salvar(T entidade);
        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarId(String id);



    }
}
