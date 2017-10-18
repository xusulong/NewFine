/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：43f41100-7515-4c26-aadb-73daa57a94f2
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 15:46:34
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFine.Entity
{
    public interface IDeleteAudited
    {
        bool? F_DeleteMark { get; set; }
        string F_DeleteUserId { get; set; }
        DateTime? F_DeleteTime { get; set; }
    }
}
