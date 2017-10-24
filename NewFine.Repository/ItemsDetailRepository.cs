/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：1d2a268b-ff5f-47a4-ac50-6f40396c2645
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 11:25:10
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
using NewFine.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace NewFine.Repository
{
    public class ItemsDetailRepository : RepositoryBase<ItemsDetailEntity>, IItemsDetailRepository
    {
        public List<ItemsDetailEntity> GetItemList(string enCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT d.* 
                            FROM Sys_ItemsDetail d
                                INNER JOIN Sys_Item i ON i_F_id = d.F_ItemId
                            WHERE 1=1
                                AND i.F_EnCode = @enCode
                                AND d.F_EnabledMark = 1
                                AND d.F_DeleteMark =0
                            Order BY d.F_SortCode ASC");
            DbParameter[] parameter = { new SqlParameter("@enCode", enCode) };
            return this.FindList(strSql.ToString(), parameter);
        }

    }
}
