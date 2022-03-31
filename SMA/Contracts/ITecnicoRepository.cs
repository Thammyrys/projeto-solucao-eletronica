using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Contracts
{
    public interface ITecnicoRepository
    {
        IEnumerable<Tecnico>PegarTodos();
        Tecnico GetById(int id);
        Tecnico UpdateTecnico(Tecnico tecnico);
        void DeleteById(int id);
        Tecnico Create(Tecnico tecnico);
    }
}

