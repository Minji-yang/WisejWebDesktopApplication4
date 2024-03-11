using System;
using Wisej.Web;

namespace WisejWebDesktopApplication4
{
    public partial class Window3 : Form
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Window3_Load(object sender, EventArgs e)
        {

            label1.Parent = tableLayoutPanel1;
            label2.Parent = tableLayoutPanel1;
            label3.Parent = tableLayoutPanel1;
        }
    }
}
