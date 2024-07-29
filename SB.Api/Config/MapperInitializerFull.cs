
namespace SB.API.Config
{
  public class MapperInitializerFull : MapperInitializerCommon
  {
    public MapperInitializerFull(): base()
    {
      // CreateMap<OUDtoCreate, OUDtoCreateToEntity>();
        //.ForMember(d => d.LogoImg, c => c.MapFrom(y => y.LogoImg.Name))
        //.ForMember(d => d.TopImg, c => c.MapFrom(y => y.TopImg.Name))
        //.ForMember(d => d.WarningImg, c => c.MapFrom(y => y.WarningImg.Name))
        //.ForMember(d => d.FooterImg, c => c.MapFrom(y => y.FooterImg.Name));

      // CreateMapAll<City,
      //   CityDto,
      //   CityDtoCreate,
      //   CityDtoSearch>();
    }
  }

}
