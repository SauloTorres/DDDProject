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
    public class AppCliente : IAppCliente
    {
        private readonly IClienteRepository _contextCliente;

        public AppCliente(IClienteRepository context)
        {
            _contextCliente = context;
        }
        public void Add(Cliente entity)
        {
            _contextCliente.Add(entity);
        }

        public void Remove(Cliente entity)
        {
            _contextCliente.Remove(entity);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _contextCliente.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _contextCliente.GetById(id);
        }

        public void Update(Cliente entity)
        {
            _contextCliente.Update(entity);
        }
    }
}
