using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuletaJava
{
    public partial class InsertarApuesta : Form
    {
        public InsertarApuesta()
        {
            InitializeComponent();

            //Set minimo
            nudApuesta.Minimum = 10;

            //Set maximo
            nudApuesta.Maximum = 1000;

            lbMinMax.Text = "Minimo: " + nudApuesta.Minimum + " - Maximo: " + nudApuesta.Maximum;
        }

        //Ventana inicial para insertar el saldo con el que se va a jugar.
        //Al darle a aceptar se enviara el saldo a la clase Casino.
        //Minimo 10 maximo 1000
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int apuesta = (int)nudApuesta.Value;


            Hide();
            Casino micasino = new Casino(apuesta);
            micasino.Show();
        }
    }
}
