using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Contracts
{
    public interface IAtendenteRepository
    {
        IEnumerable<Atendente> PegarTodos();
        Atendente GetById(int id);
        Atendente UpdateAtendente(Atendente atendente);
        void DeleteById(int id);
        Atendente Create(Atendente atendente);
    }
}
