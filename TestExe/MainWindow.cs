using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestFunction("test");
        }
        private static void TestFunction(string msg)
        {
            MessageBox.Show(msg);
        }

    }
}
