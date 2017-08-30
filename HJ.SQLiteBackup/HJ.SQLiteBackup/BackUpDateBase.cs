// ===============================================================================
// 项目名称  :    HJ.SQLiteBackup
// 项目描述  :    
// ===============================================================================
// 类名称    :    BackUpDateBase
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-16 15:58:32
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJ.SQLiteBackup
{
    /// <summary>
    /// 表示SQLite数据库备份
    /// </summary>
    public class BackUpDateBase
    {
      

        //表示备份实体
        private  BackUpModel m_BackUpModel;

        public BackUpDateBase()
        {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initializae(BackUpModel myBackUpModel)
        {
            m_BackUpModel = myBackUpModel;
           
        }
        //数据备份
        public void BackupDB()
        {
            try
            {
                using (SQLiteConnection con = GetConnection(m_BackUpModel.destDBFileName))
                {
                    using (SQLiteConnection bakCon = GetConnection(m_BackUpModel.backupDBFileName))
                    {
                        con.Open();
                        bakCon.Open();
                        con.BackupDatabase(bakCon, "main", "main", -1, null, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new SQliteBackUpException(ex.Message, ex);          
            }      
        }
        //创建数据库连接
        public SQLiteConnection GetConnection(string dbName)
        {
            try
            {
                SQLiteConnectionStringBuilder scsb = new SQLiteConnectionStringBuilder();
                scsb.DataSource = dbName;               
                SQLiteConnection con = new SQLiteConnection(scsb.ConnectionString);
                return con;
            }
            catch (Exception ex)
            {                
                throw new SQliteBackUpException(ex.Message,ex);
            }          
        }
    }
}
