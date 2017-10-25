/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：af1250b1-1c84-4ad1-9b9a-9ea08ff654fb
 * 创建人：  HZWNB147
 * 创建时间：2017/10/25 10:39:58
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFine.Utils
{
  public class ExtList<T> : IEqualityComparer<T> where T : class, new()
    {
         private string[] comparintFiledName = { };

        public ExtList() { }
        public ExtList(params string[] comparintFiledName)
        {
            this.comparintFiledName = comparintFiledName;
        }
        bool IEqualityComparer<T>.Equals(T x, T y)
        {
            if (x == null && y == null)
            {
                return false;
            }
            if (comparintFiledName.Length == 0)
            {
                return x.Equals(y);
            }
            bool result = true;
            var typeX = x.GetType();//获取类型
            var typeY = y.GetType();
            foreach (var filedName in comparintFiledName)
            {
                var xPropertyInfo = (from p in typeX.GetProperties() where p.Name.Equals(filedName) select p).FirstOrDefault();
                var yPropertyInfo = (from p in typeY.GetProperties() where p.Name.Equals(filedName) select p).FirstOrDefault();

                result = result
                    && xPropertyInfo != null && yPropertyInfo != null
                    && xPropertyInfo.GetValue(x, null).ToString().Equals(yPropertyInfo.GetValue(y, null));
            }
            return result;
        }
        int IEqualityComparer<T>.GetHashCode(T obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
