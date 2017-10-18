/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：8afb92a3-392a-46be-b41a-e862933ba8ea
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 15:52:22
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;

namespace NewFine.Entity
{
    public class LogEntity:IEntity<LogEntity>,ICreationAudited
    {
        public string F_Id { get; set; }
        public DateTime? F_Date { get; set; }
        public string F_Account { get; set; }
        public string F_NickName { get; set; }
        public string F_Type { get; set; }
        public string F_IPAddress { get; set; }
        public string F_IPAddressName { get; set; }
        public string F_ModuleId { get; set; }
        public string F_ModuleName { get; set; }
        public bool? F_Result { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
