namespace TCI.Operation.Usr.Interface
{
    public interface IUserOperation : IBaseOperation<Domain.Usr.User, Model.Usr.User>
    {
        Model.Usr.User Login(Model.Usr.Login login);
    }
}
