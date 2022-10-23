using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gestor.API.DomainModels;
using Gestor.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gestor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GaleriaController : Controller
    {
        private readonly IGaleriaRepository  galeriaRepository;
        private readonly IMapper mapper;

        public GaleriaController( IGaleriaRepository galeriaRepository, IMapper mapper)
        {
            this.galeriaRepository = galeriaRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task <IActionResult> GetAllGaleriasAsync()
        {
           var galerias = await galeriaRepository.GetAllGaleriasAsync();

           mapper.Map<List<Galeria>>(galerias);

           // var domainModelsGalerias = new List<Galeria>();

           return Ok(mapper.Map<List<Galeria>>(galerias));

           /* foreach (var galeria in galerias)
           {
                domainModelsGalerias.Add(new Galeria
                {
                     Id = galeria.Id,
                     Name = galeria.Name,
                     Description = galeria.Description,
                     dataAtualizacao = galeria.dataAtualizacao,
                     GalleryTypeId = galeria.GalleryTypeId,
                     titulo = galeria.titulo,
                     ElaboradorId = galeria.ElaboradorId,
                     qtdFotos = galeria.qtdFotos,
                     ConcessionId = galeria.ConcessionId,
                     GalleryType = new GalleryType()
                     {
                        Id = galeria.GalleryType.Id,
                        galleryType = galeria.GalleryType.galleryType
                     },
                     Concession = new Concession()
                     {
                        Id = galeria.Concession.Id,
                        concession = galeria.Concession.concession
                     }
                }); */

                 // return Ok(domainModelsGalerias);
           }
         
        }

    
    }
