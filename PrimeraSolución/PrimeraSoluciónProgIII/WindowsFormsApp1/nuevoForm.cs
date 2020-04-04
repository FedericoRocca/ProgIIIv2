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
    public partial class nuevoForm : Form
    {
        public nuevoForm()
        {
            InitializeComponent();
        }

        private void nuevoForm_Load(object sender, EventArgs e)
        {
            Animal _animal = new Animal();
            _animal.Color = "Rojo";

            Gato _gato = new Gato();
            _gato.Color = "Cafe";

            Gato _otroGato = new Gato();
            _otroGato.Color = "Negro";

            Perro _perro = new Perro();
            _perro.Color = "Fuego";

            List<Animal> animales = new List<Animal>();
            animales.Add(_animal);
            animales.Add(_perro);
            animales.Add(_gato);
            animales.Add(_otroGato);

            //MessageBox.Show(_animal.comunicarse());
            //MessageBox.Show(_perro.comunicarse());
            //MessageBox.Show(_gato.Color);

            foreach (Animal elAnimal in animales)
            {
                MessageBox.Show(elAnimal.comunicarse());
            }

            
        }
    }
}
