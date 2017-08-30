// ===============================================================================
// 项目名称  :    HJ.SQLiteBackup
// 项目描述  :    
// ===============================================================================
// 类名称    :    BackUpModel
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-16 16:10:26
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJ.SQLiteBackup
{
    /// <summary>
    /// 备份管理实体
    /// </summary>
    public  class BackUpModel
    {
        
        public BackUpModel()
        {

        }
        /// <summary>
        /// 数据库文件名
        /// </summary>
        public  string destDBFileName { get; set; }
       
        /// <summary>
        /// 备份文件名
        /// </summary>
        public string backupDBFileName { get; set; }
    }
}
