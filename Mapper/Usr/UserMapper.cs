using TCI.Domain.Per;

namespace TCI.Mapper.Usr
{
    public class UserMapper : BaseMapper<Domain.Usr.User, Model.Usr.User>
    {
        public override void Register()
        {
            base.Register();
            EntityToModelMapper
                .ForMember(s => s.Name, d => d.MapFrom(x => (x.Person as RealPerson).Name))
                .ForMember(s => s.Family, d => d.MapFrom(x => (x.Person as RealPerson).Family));
        }
    }
}
