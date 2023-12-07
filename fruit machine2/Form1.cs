using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_machine2
{
    public partial class Form1 : Form
    {
        static Image orange = fruit_machine2.Properties.Resources.orange;
        static Image apple = fruit_machine2.Properties.Resources.Apple;
        static Image cherry  = fruit_machine2.Properties.Resources.cherry;
        static Image strawberry = fruit_machine2.Properties.Resources.strawberry;
        static Image lemon = fruit_machine2.Properties.Resources.Lemon;
        static int y = 30;
        static int x = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
