using NewFine.Data;
namespace NewFine.Entity.IRepository
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        void DeleteFrom(string keyValue);
        void SubmitForm(UserEntity userEntity, UserLogOnEntity userLogOnEntity, string keyValue);
    }
}
