using AutoMapper;
using OnlinePremios.Mvc.ViewModels;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Mvc.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Compra, CompraViewModel>().ReverseMap();
            CreateMap<Cota, CotaViewModel>().ReverseMap();
            
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Sorteio, SorteioViewModel>().ReverseMap();
        }
    }

}
