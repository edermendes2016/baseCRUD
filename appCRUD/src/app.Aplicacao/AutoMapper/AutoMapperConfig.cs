using AutoMapper;

namespace app.Aplicacao.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistrerMappings()
        {
            Mapper.Initialize(
                x =>
                {
                    x.AddProfile<DominioToViemModelMappingProfile>();
                   // x.AddProfile<ViewModelToDominioMappingProfile>();
                });
        }
    }
}