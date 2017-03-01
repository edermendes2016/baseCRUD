using app.Aplicacao.ViewModels;
using appCRUD.Dominio.Modelos;
using AutoMapper;

namespace app.Aplicacao.AutoMapper
{
    public class ViewModelToDominioMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioVW, Usuario>();
            CreateMap<UsuarioEnderecoVM, Usuario>();
            CreateMap<EnderecoVM, Endereco>();
            CreateMap<UsuarioEnderecoVM, Endereco>();

        }
    }
}