using WebApplication1.Data.Repository;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ColetaService : IColetaService
    {
        private readonly IColetaRepository _repository;

        public ColetaService(IColetaRepository repository)
        {
            _repository = repository;
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
            throw new NotImplementedException();
        }

        public ColetaModel GetById(int DiaColetaId)
        {
            throw new NotImplementedException();
        }

        public void Update(ColetaModel coletaModel)
        {
            throw new NotImplementedException();
        }
    }
}
