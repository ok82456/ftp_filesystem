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
    public partial class Form2 : Form
    {
        public List<FileStruct> dirs;
        public List<FileStruct> files;

        public Form2()
        {
            InitializeComponent();
        }

        public void InitForm()
        {
            foreach (FileStruct item in dirs)
            {

            }
        }
    }
}
