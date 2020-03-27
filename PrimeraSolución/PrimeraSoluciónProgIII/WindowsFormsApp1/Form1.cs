using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formInicial : Form
    {
        public formInicial()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if( txbSaludar.Text.Length <= 0 )
            {
                MessageBox.Show("Debes ingresar el nombre");
            }
            else
            {
                MessageBox.Show("Hola " + txbSaludar.Text + "!");
            }
        }

        private void formInicial_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evento load del form principal", "Titulo del messagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Evento FormClosing del form principal", "Titulo del messagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                this.Dispose();
            }
        }
    }
}
