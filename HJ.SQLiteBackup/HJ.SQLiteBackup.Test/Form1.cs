using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HJ.SQLiteBackup.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            BackUpModel model = new BackUpModel();
            model.destDBFileName = @"DataBase\SHOEDB.db";
            model.backupDBFileName = @"BuckUp\SHOEDB.db";
            BackUpDateBase myBackUpDateBase = new BackUpDateBase();
            myBackUpDateBase.Initializae(model);
            myBackUpDateBase.BackupDB();
            MessageBox.Show("OK");
        }
    }
}
