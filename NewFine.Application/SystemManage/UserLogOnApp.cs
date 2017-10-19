/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：cb892f01-9aae-489f-bc71-766f668d5f76
 * 创建人：  HZWNB147
 * 创建时间：2017/10/19 13:55:58
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Entity;
using NewFine.Repository;
namespace NewFine.Application
{
    public class UserLogOnApp
    {
        private IUserLogOnRepository service = new UserLogOnRepository();
        public UserLogOnEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void UpdateForm(UserLogOnEntity userLogOnEntity)
        {
            service.Update(userLogOnEntity);
        }

    }
}
