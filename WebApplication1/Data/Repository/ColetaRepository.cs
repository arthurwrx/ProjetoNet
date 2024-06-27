using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Data.Repository
{
    public class ColetaRepository : IColetaRepository

    {
        private readonly DatabaseContext _dataContext;

        public ColetaRepository(DatabaseContext context)
        {
            _dataContext = context;
        }

        public void Add(ColetaModel coletaModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(ColetaModel coletaModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ColetaModel> GetAll()
        {
            return _dataContext.ColetaModels.ToList();
        }

        public ColetaModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ColetaModel coletaModel)
        {
            throw new NotImplementedException();
        }
    }
}
