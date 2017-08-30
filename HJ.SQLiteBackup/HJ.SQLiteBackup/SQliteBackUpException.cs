// ===============================================================================
// 项目名称  :    HJ.SQLiteBackup
// 项目描述  :    
// ===============================================================================
// 类名称    :    SQliteBackUpException
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-16 16:31:33
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
    public class SQliteBackUpException: Exception
    {
        public SQliteBackUpException(string message)
            : base(message)
        {

        }

        public SQliteBackUpException(string message, Exception myException)
            : base(message,myException)
        {

        }
    }
}
