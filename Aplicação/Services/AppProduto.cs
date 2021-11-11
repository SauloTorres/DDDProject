using Aplicação.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
namespace Aplicação.Services
{
    public class AppProduto : IAppProduto
    {
        private readonly IProdutoRepository _contextProduto;

        public AppProduto(IProdutoRepository context)
        {
            _contextProduto = context;
        }
        public void Add(Produto entity)
        {
            _contextProduto.Add(entity);
        }

        public void Remove(Produto entity)
        {
            _contextProduto.Remove(entity);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _contextProduto.GetAll();
        }

        public Produto GetById(int id)
        {
            return _contextProduto.GetById(id);
        }

        public void Update(Produto entity)
        {
            _contextProduto.Update(entity);
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _contextProduto.BuscarPorNome(nome);
        }
    }
}
