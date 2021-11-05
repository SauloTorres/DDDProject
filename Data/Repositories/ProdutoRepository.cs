using Data.Context;
using DDDProject.Infra.Data.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        private readonly DDDProjectContext db = new DDDProjectContext();
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
