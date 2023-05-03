using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Sumary>
///Nombre: Jose Manuel 
///Asignatura: Herramientas de programacion 2
///fecha: 04/05/2023
///</Sumary>


namespace Gestion
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creamos una instancia del form2 y la muestra dentro del formulario principal. 
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cierra el formulario actual en el que se encuentra el codigo
            this.Close();
        }
    }
}
