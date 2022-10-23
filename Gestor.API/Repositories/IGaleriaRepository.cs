using System.Collections.Generic;
using System.Threading.Tasks;
using Gestor.API.DataModels;

namespace Gestor.API.Repositories
{
    public interface IGaleriaRepository
    {
        Task<List<Galeria>> GetAllGaleriasAsync();
        
    }
}