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

        public void Add(ColetaModel coletaModel) => _repository.Add(coletaModel);

        public void Delete(int DiaColetaId)
        {
            var coleta = _repository.GetById(DiaColetaId);
            if (coleta != null)
            {
                _repository.Delete(coleta);
            }
        }

        public IEnumerable<ColetaModel> GetAll() => _repository.GetAll();  

        public ColetaModel GetById(int DiaColetaId) => _repository.GetById(DiaColetaId);

        public void Update(ColetaModel coletaModel) => _repository.Update(coletaModel);
    }
}
