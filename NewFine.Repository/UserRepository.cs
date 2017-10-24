/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：d42e6486-4bb0-47c7-86bb-0700bd8d0d8d
 * 创建人：  HZWNB147
 * 创建时间：2017/10/19 9:38:21
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Data;
using NewFine.Entity;
using NewFine.Entity.IRepository;
using NewFine.Data.Repository;
using NewFine.Utils;
namespace NewFine.Repository
{
	/// <summary>
    /// 仓库动作的实现
    /// </summary>
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public void DeleteFrom(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<UserEntity>(t => t.F_Id == keyValue);
                db.Delete<UserLogOnEntity>(t => t.F_UserId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(UserEntity userEntity,UserLogOnEntity userLogOnEntity,string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(userEntity);
                }
                else
                {
                    userLogOnEntity.F_Id = userEntity.F_Id;
                    userLogOnEntity.F_UserId = userEntity.F_Id;
                    userLogOnEntity.F_UserSecretkey = Md5.md5(Common.CreateNo(),16).ToLower();
                    userLogOnEntity.F_UserPassWord = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userLogOnEntity.F_UserPassWord,32).ToLower(),userLogOnEntity.F_UserSecretkey).ToLower(),32).ToLower();
                    db.Insert(userEntity);
                    db.Insert(userLogOnEntity);
                }
                db.Commit();
            }
        }
    }
}
