using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatRacingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPly_Click(object sender, EventArgs e)
        {
            if (cbgree.Checked == true) {
                Playground playground = new Playground();
                playground.Show();
                this.Hide();
            }

        }
    }
}
