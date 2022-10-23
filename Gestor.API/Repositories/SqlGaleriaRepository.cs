using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestor.API.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Gestor.API.Repositories
{
    public class SqlGaleriaRepository : IGaleriaRepository
    {
        
        private readonly GestorContext context;
        public SqlGaleriaRepository(GestorContext context)
        {
            this.context = context;
        
        }

        public async Task<List<Galeria>> GetAllGaleriasAsync()
        {
           return  await context.Galeria.ToListAsync();
        }

      


        /* public List<Galeria> GetGalerias()
        {
        return context.Galeria.ToList();
        } */
    }
}