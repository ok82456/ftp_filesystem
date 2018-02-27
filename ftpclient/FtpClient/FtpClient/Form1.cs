using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FtpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = SQLiteHelper.ExecuteDataTable("select * from staff where gh='" + textBox1.Text + "'");
            if (dt.Rows.Count > 0 && dt.Rows[0]["MIMA"].Equals(textBox2.Text))
            {
                Form2 f2 = new Form2();
                FTPHelper ftp = new FTPHelper("127.0.0.1", "", "public", "123");
                List<FileStruct> files = ftp.ListFilesAndDirectories();
                f2.ShowDialog();
            }
            MessageBox.Show("用户密码错误");
        }
    }
}
