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
            _dataContext.Coletas.Add(coletaModel);
            _dataContext.SaveChanges();
        }

        public void Delete(ColetaModel coletaModel)
        {
            _dataContext.Coletas.Remove(coletaModel);
            _dataContext.SaveChanges();
        }

        public IEnumerable<ColetaModel> GetAll()
        {
            return _dataContext.Coletas.ToList();
        }

        public ColetaModel GetById(int DiaColetaId) => _dataContext.Coletas.Find(DiaColetaId);

        public void Update(ColetaModel coletaModel)
        {
            _dataContext.Coletas.Update(coletaModel);
            _dataContext.SaveChanges();
        }
    }
}
