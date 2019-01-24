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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int apuesta = (int)nudApuesta.Value;

            Hide();
            Casino micasino = new Casino(apuesta);
            micasino.Show();
        }
    }
}
