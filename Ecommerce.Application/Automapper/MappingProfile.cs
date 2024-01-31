using AutoMapper;
using Ecommerce.Dominio;
using Ecommerce.Dominio.ModelDTIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Automapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile() {

            CreateMapperForProduc();
        
        }

        private void CreateMapperForProduc()
        {
            CreateMap<ProducDTIN, Product>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));  
        }
    }
}
