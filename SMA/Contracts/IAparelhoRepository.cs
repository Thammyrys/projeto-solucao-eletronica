using SMA.Data;
using System.Collections.Generic;

namespace SMA.Contracts
{
    public interface IAparelhoRepository
    {
        IEnumerable<Aparelho> PegarTodos();
        Aparelho GetById(int id);
        Aparelho UpdateAparelho(Aparelho aparelho);
        void DeleteById(int id);
        Aparelho Create(Aparelho aparelho);
        void MudarStatus(Aparelho aparelho);
    }
}
