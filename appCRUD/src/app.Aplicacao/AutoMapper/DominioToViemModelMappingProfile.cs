using app.Aplicacao.ViewModels;
using appCRUD.Dominio.Modelos;
using AutoMapper;

namespace app.Aplicacao.AutoMapper
{
    public class DominioToViemModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Usuario, UsuarioVW>().ReverseMap();
            CreateMap<Usuario, UsuarioEnderecoVM>().ReverseMap();
            CreateMap<Endereco, EnderecoVM>().ReverseMap();
            CreateMap<Endereco, UsuarioEnderecoVM>().ReverseMap();
        }
    }
}