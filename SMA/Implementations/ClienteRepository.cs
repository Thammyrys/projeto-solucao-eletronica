using SMA.Contracts;
using SMA.Contracts.Data;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Implementations
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SMAContext context;
        public ClienteRepository(SMAContext context)
        {
            this.context = context;
        }
        public Cliente Create(Cliente cliente)
        {
            try
            {
                context.Add(cliente);
                context.SaveChanges();
                return cliente; 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                var cliente = context.Clientes.Find(id);
                if (cliente == null)
                    return;

                context.Remove(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente PegarPeloId(int id)
        {
            try
            {
                var cliente = context.Clientes.FirstOrDefault(x => x.Id == id);
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> PegarTodos()
        {
            try
            {
                var cliente = context.Clientes.ToList();
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            try
            {
                var clienteParaUpdate = PegarPeloId(cliente.Id);

                context.Update(clienteParaUpdate);
                context.SaveChanges();

                return clienteParaUpdate;
                         
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
