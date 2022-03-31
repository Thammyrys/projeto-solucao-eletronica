using SMA.Contracts.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SMA.Contracts
{
    public interface IClienteRepository
    {
        Cliente PegarPeloId(int id);
        List<Cliente> PegarTodos();
        Cliente UpdateCliente(Cliente cliente);
        void DeleteById(int id);
        Cliente Create(Cliente cliente);


    }
}
