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
    public partial class Casino : Form
    {
        int numPremio, posicion, saldo, apuesta, cantidad;
        String color, tipoApuesta;

        Ruleta miruleta = new Ruleta();

        public Casino()
        {
            InitializeComponent();

        }

        public Casino(int saldo)
        {
            InitializeComponent();

            this.saldo = saldo;

            
            posicion = miruleta.GenerarTirada();
            
            numPremio = miruleta.NumPremio;
            color = "";

            lbSaldo.Text = ("" + saldo);

            nudApuesta.Maximum = saldo;

            if (rbNumero.Checked)
            {
                nudNumero.Enabled = true;
                lbApuestaJugador.Text = "numero";
                tipoApuesta = "numero";
            }
            else
            {
                nudNumero.Enabled = false;
            }

        }

        public void ComprobarResultado() {

            switch (tipoApuesta)
            {
                //Colores
                case "rojo":
                    if (miruleta.Color.Equals("rojo"))
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;
                case "negro":
                    if (miruleta.Color.Equals("negro"))
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;

                    //Pares
                case "par":
                    if (miruleta.NumPremio % 2 == 0 && miruleta.NumPremio != 0)
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;
                case "impar":
                    if (miruleta.NumPremio % 2 == 1 && miruleta.NumPremio != 0)
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;

                    //Falta Pasa
                case "falta":
                    if (miruleta.NumPremio >= 1 && miruleta.NumPremio <= 18)
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;
                case "pasa":
                    if (miruleta.NumPremio >= 19 && miruleta.NumPremio <= 36)
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo += apuesta * 2;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;

                    //Numero
                case "numero":
                    if (nudNumero.Value==int.Parse(lbNumPremio.Text))
                    {
                        lbResultado.Text = "Has ganado!";
                        MessageBox.Show("Has ganado!");
                        saldo = saldo + apuesta * 36;
                        lbSaldo.Text = ("" + saldo);
                    }
                    else
                    {
                        lbResultado.Text = "Has perdido!";
                        MessageBox.Show("Has perdido!");
                        lbSaldo.Text = ("" + saldo);
                    }
                    break;



                default:
                    MessageBox.Show("Error"); ComprobarResultado(); break;
            }
        }

        public void MostrarResultado()
        {

            lbNumPremio.Text = "" + numPremio;

            //Color premiado
            if (posicion == 0)
            {
                color = "Verde";
                miruleta.Color = "verde";
            }
            else
            {
                if (posicion % 2 == 0)
                {
                    lbColorPremio.Text = "Negro";
                    miruleta.Color = "negro";
                }
                else
                {
                    lbColorPremio.Text = "Rojo";
                    miruleta.Color = "rojo";
                }
            }

            //Par o Impar
            if (numPremio != 0)
            {
                if (numPremio % 2 == 0)
                {
                    lbParImparPremio.Text = "Par";
                }
                else
                {
                    lbParImparPremio.Text = "Impar";
                }

                //Falta Pasa

                if (numPremio <= 18)
                {
                    lbFaltaPasaPremio.Text = "Falta";
                }
                else
                {
                    lbFaltaPasaPremio.Text = "Pasa";
                }
            }
        }

        private void Casino_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbRojo_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "rojo";
            lbApuestaJugador.Text = "Rojo";
        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "negro";
            lbApuestaJugador.Text = "Negro";
        }

        private void rbPar_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "par";
            lbApuestaJugador.Text = "Par";
        }

        

        private void rbImpar_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "impar";
            lbApuestaJugador.Text = "Impar";
        }

        private void rbFalta_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "falta";
            lbApuestaJugador.Text = "Falta";
        }

        private void rbPasa_CheckedChanged(object sender, EventArgs e)
        {
            tipoApuesta = "pasa";
            lbApuestaJugador.Text = "Pasa";
            MostrarResultado();
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            btnRepetir.Enabled = true;
            nudApuesta.Enabled = false;
            btnApostar.Enabled = false;
            gbApuestas.Enabled = false;

            apuesta = (int)nudApuesta.Value;

            lbApuestaJugador.Text = tipoApuesta;

            saldo-= apuesta;
            lbSaldo.Text = "" + saldo;

            MostrarResultado();
            ComprobarResultado();
            
        }

        public void ResetResultados() {
            //Numero
            lbNumPremio.Text = "";
            
            //Color
            lbColorPremio.Text = "";

            //Par o Impar
            lbParImparPremio.Text = "";

            //Falta Pasa
            lbFaltaPasaPremio.Text = "";

            //Apuesta jugador
            lbApuestaJugador.Text = "";

            //Resultado
            lbResultado.Text = "";

        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {

            if (saldo < 1)
            {
                MessageBox.Show("Te has quedado sin saldo");

            }
            else
            {
                btnRepetir.Enabled = false;
                nudApuesta.Enabled = true;
                btnApostar.Enabled = true;
                gbApuestas.Enabled = true;

                nudApuesta.Maximum = saldo;
                nudApuesta.Minimum = 10;
                nudApuesta.Value = 10;
                nudNumero.Value = 0;
                ResetResultados();

                lbSaldo.Text = "" + saldo;
                posicion = miruleta.GenerarTirada();

                numPremio = miruleta.NumPremio;
                color = "";


            }
        }

        private void rbNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumero.Checked)
            {
                nudNumero.Enabled = true;
                lbApuestaJugador.Text = "numero";
                tipoApuesta = "numero";
            }
            else
            {
                nudNumero.Enabled = false;
                nudNumero.Value = 0;
            }
        }
    }
}
