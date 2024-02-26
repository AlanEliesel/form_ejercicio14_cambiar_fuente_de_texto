using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ejercicio14_cambiar_fuente_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbr_tamaño_Scroll(object sender, EventArgs e)
        {

            lbl_texto.Text = "Texto: " + tbr_tamaño.Value.ToString() + "%";

            int size = tbr_tamaño.Value;

            Font mifuente = new Font("Arial", size);

            lbl_texto.Font = mifuente;


        }
    }
}
