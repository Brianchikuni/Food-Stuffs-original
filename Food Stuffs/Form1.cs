using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Stuffs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capture capture = new Capture();

            capture.ShowDialog();
        }

        private void serverFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();

            verify.ShowDialog();
        }
    }
}
