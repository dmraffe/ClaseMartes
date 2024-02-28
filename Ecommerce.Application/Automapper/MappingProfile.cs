using AutoMapper;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Commands.DeleteCategory;
using Ecommerce.Application.Features.Category.Commands.UpdateCategory;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Application.Features.Product.Commands.DeleteProduct;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
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

              
            CreateMapperForCategory();
            CreateMapperForProduc();
            CreatemappingForOrden();
        
        }

        private void CreatemappingForOrden()
        {
            CreateMap<Orden, CarritoDto>();
        }

        private void CreateMapperForCategory()
        {
            CreateMap<Category, CategoryDTO>().ForMember(dest => dest.ProductCount, opt => opt.MapFrom(src => src.Products.Count)); ;
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<DeleteCategoryCommand, Category>();
        }

        private void CreateMapperForProduc()
        { 
            CreateMap<Product, ProductDTO>();  
            CreateMap<ProducDTIN, Product>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<DeleteProductCommand, Product>();
        }
    }
}
