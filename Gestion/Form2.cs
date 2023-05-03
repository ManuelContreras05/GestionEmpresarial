using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        
        //Inicializamos variables
        private Stream myStream;
        int counter = 0;
        string line;

        private void btnLinea_Click(object sender, EventArgs e)
        {
            //Crea un cuadro de dialogo "OpenFileDialog" y establece su propiedad "intialDirectory" en el directorio de inicio de la aplicacion
            //y su porpiedad "Filter" en la extension de archivo ".txt"
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivo (.) | .txt";

            //Permite al Usuario seleccionar un archivo para abrir, lee el contenido del archivo linea por linea 
            //utilizando un objeto "StreamReader" y agrega cada linea al control "TextBox". Si ocurre algun error durante el proceso, se muestra un mensaje
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null )
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);

                            while ((line = file.ReadLine()) != null)
                            {
                                txtArchivo.Text = txtArchivo.Text + line + Environment.NewLine;
                                counter++;
                            }
                            file.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not  read file from  disk. Original  error: " + ex.Message);

                    throw;
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Declarar una variable de matriz de cadena y crea un objeto "DataGridViewTextBoxColumn" para mostrar una columna de datos
            //en un control "DataGridView". Se establece con un encabezado, un ancho y se especifica que el usuario no puede editar los valores de la columna.
            string[] result; 
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Columna1";
            col1.Width = 200;
            col1.ReadOnly = true;

            //Crea un objeto "OpenFileDialog" que permite al usuario seleccionar un archivo con extension .csv en el directorio de inicio de la aplicacion y establece
            //que solo se mostraran archivos con esa extension.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.csv) | *.csv";

            //Abre el archivo seleccioando por el usuario en el cuadro de dialogo "OpenFileDialog" y lee su contenido linea por linea. Luego, divide cada linea en campos
            //separados por ';' y agrega una nueva fila al control DataGridView 'dtgDTG' con los campos de la linea leida. Si ocurre un error en el proceso sale un mensaje 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);

                        while ((line = file.ReadLine()) != null)
                        {
                            result = line.Split(';');
                            dtgDTG.Rows.Add(result[0], result[1], result[2], result[3], result[4], result[5], result[6]);
                            counter++;
                        }
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not  read file from  disk. Original  error: " + ex.Message);
                    throw;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia todo los controles 
            dtgDTG.Rows.Clear();
            txtArchivo.Clear(); 
            this.cmbAreaEmpresa.Text = "";
        }
    }
}
