using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor.API.DomainModels
{
    public class Galeria
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid ConcessionId { get; set; }
        public Concession Concession { get; set; } // PRA DEPOIS Q CRIAR Concession models
        public string Description { get; set; }

        public DateTime dataAtualizacao { get; set; }

        public Guid GalleryTypeId { get; set; }
        public GalleryType GalleryType { get; set; }  // PRA DEPOIS Q CRIAR GalleryType

        public string titulo { get; set; }

        public Guid ElaboradorId { get; set; }
         // public User Elaborador { get; set; } PRA DEPOIS Q CRIAR UserElaborador
       
        public int qtdFotos { get; set; } //Caso dê problema, remover esse

        //Guid é a Foreign key podendo substituir o int
        }    
    }
