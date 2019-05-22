using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace Diseño
{
    public partial class Form1 : Form
    {
        MantenimientoDoctor neg = new MantenimientoDoctor();
        MantenimientoDoctor enlc = new MantenimientoDoctor();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            neg.CodDoctor = txtNumDoctor.Text;
            neg.CodHospital = txtCodHospital.Text;
            neg.ApellidoDoc = txtApellidoDoc.Text;
            neg.EspecialidadDoc = txtEspecialidadDoc.Text;
            neg.insertarDoctor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }
    }
}
