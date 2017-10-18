using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Data.Repository;
namespace NewFine.Entity.IRepository
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        void DeleteFrom(string keyValue);
        void SubmitForm(UserEntity userEntity,UserLogOnEntity userLogOnEntity, string keyValue)
    }
}
