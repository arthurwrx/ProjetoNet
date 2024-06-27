using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IColetaService
    {
        IEnumerable<ColetaModel> GetAll();
        ColetaModel GetById(int DiaColetaId);
        void Add(ColetaModel coletaModel);
        void Update(ColetaModel coletaModel);
        void Delete(ColetaModel coletaModel);
    }
}
