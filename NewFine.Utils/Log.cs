/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：43bfcc5f-8cc2-4833-97b5-b5e2e2aa0231
 * 创建人：  HZWNB147
 * 创建时间：2017/10/25 15:20:14
 * 描述：
 * 
 * 
 ************************************************************************************/
using log4net;
namespace NewFine.Utils
{
    /// <summary>
    /// 基于log4net的Log类实现
    /// </summary>
    public class Log
    {
        private ILog logger;
        public Log(ILog log)
        {
            this.logger = log;
        }
        public void Debug(object message)
        {
            this.logger.Debug(message);
        }
        public void Error(object message)
        {
            this.logger.Error(message);
        }
        public void Info(object message)
        {
            this.logger.Info(message);
        }
        public void Warn(object message)
        {
            this.logger.Warn(message);
        }
    }
}
