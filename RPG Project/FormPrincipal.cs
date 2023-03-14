using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRPG_Click(object sender, EventArgs e)
        {
            FormRpg rpg = new FormRpg();
            rpg.Show();
        }

        private void btnSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.Show();
        }
    }
}
