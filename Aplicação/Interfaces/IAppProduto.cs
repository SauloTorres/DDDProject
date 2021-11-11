using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Aplicação.Interfaces
{
    public interface IAppProduto : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
