using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Data.Repository
{
    public interface IColetaRepository
    {
        IEnumerable<ColetaModel> GetAll();
        ColetaModel GetById(int id);
        void Add(ColetaModel coletaModel);
        void Update(ColetaModel coletaModel);
        void Delete(ColetaModel coletaModel);


    }
}
