/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：5b56e14d-977e-434f-933e-51e7339f2cfe
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 15:31:08
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
namespace NewFine.Entity
{
    public class OrganizeEntity : IEntity<OrganizeEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string F_ParentId { get; set; }
        public int? F_Layers { get; set; }
        public string F_EnCode { get; set; }
        public string F_FullName { get; set; }
        public string F_ShortName { get; set; }
        public string F_CategoryId { get; set; }
        public string F_ManagerId { get; set; }
        public string F_TelePhone { get; set; }
        public string F_MobilePhone { get; set; }
        public string F_WeChat { get; set; }
        public string F_Fax { get; set; }
        public string F_Email { get; set; }
        public string F_AreaId { get; set; }
        public string F_Address { get; set; }
        public bool? F_AllowEdit { get; set; }
        public bool? F_AllowDelete { get; set; }
        public int? F_SortCode { get; set; }
        public bool? F_DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
    }
}
