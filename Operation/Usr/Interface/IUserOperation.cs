namespace TCI.Operation.Usr.Interface
{
    public interface IUserOperation : IBaseOperation<Domain.User, Model.User>
    {
        Model.User Login(Model.Login login);
    }
}
