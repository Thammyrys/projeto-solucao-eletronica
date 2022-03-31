using SMA.Contracts;
using SMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SMA.Implementations
{
    public class AparelhoRepository : IAparelhoRepository
    {
        private readonly SMAContext context;
        public AparelhoRepository(SMAContext context)
        {
            this.context = context;
        }
        public Aparelho Create(Aparelho aparelho)
        {
            try
            {

                if(aparelho.Id > 0)
                {
                    context.Update(aparelho);
                    context.SaveChanges();

                    return aparelho;
                }

                context.Add(aparelho);
                context.SaveChanges();
                return aparelho;
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
                var aparelho = context.Aparelhos.Find(id);

                if (aparelho == null)
                    return;

                context.Remove(aparelho);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Aparelho GetById(int id)
        {
            try
            {
                var aparelho = context.Aparelhos.FirstOrDefault(x => x.Id == id);
                return aparelho;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MudarStatus(Aparelho aparelho)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aparelho> PegarTodos()
        {
            try
            {
                var aparelhos = context.Aparelhos.ToList();
                return aparelhos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Aparelho UpdateAparelho(Aparelho aparelho)
        {
            try
            {
                var aparelhoParaUpdate = GetById(aparelho.Id);

                context.Update(aparelhoParaUpdate);
                context.SaveChanges();

                return aparelhoParaUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
