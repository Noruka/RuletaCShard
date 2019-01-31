namespace RuletaJava
{
    partial class Casino
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.gbApuestas = new System.Windows.Forms.GroupBox();
            this.rbNumero = new System.Windows.Forms.RadioButton();
            this.rbPasa = new System.Windows.Forms.RadioButton();
            this.rbFalta = new System.Windows.Forms.RadioButton();
            this.rbImpar = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbApuestaJugador = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbFaltaPasaPremio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbParImparPremio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbColorPremio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNumPremio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lbApuesta = new System.Windows.Forms.Label();
            this.nudApuesta = new System.Windows.Forms.NumericUpDown();
            this.gbApuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(86, 24);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(20, 20);
            this.lbSaldo.TabIndex = 2;
            this.lbSaldo.Text = "X";
            // 
            // gbApuestas
            // 
            this.gbApuestas.Controls.Add(this.rbNumero);
            this.gbApuestas.Controls.Add(this.rbPasa);
            this.gbApuestas.Controls.Add(this.rbFalta);
            this.gbApuestas.Controls.Add(this.rbImpar);
            this.gbApuestas.Controls.Add(this.rbPar);
            this.gbApuestas.Controls.Add(this.rbNegro);
            this.gbApuestas.Controls.Add(this.rbRojo);
            this.gbApuestas.Controls.Add(this.nudNumero);
            this.gbApuestas.Controls.Add(this.label5);
            this.gbApuestas.Controls.Add(this.label4);
            this.gbApuestas.Controls.Add(this.label3);
            this.gbApuestas.Controls.Add(this.label2);
            this.gbApuestas.Location = new System.Drawing.Point(30, 68);
            this.gbApuestas.Name = "gbApuestas";
            this.gbApuestas.Size = new System.Drawing.Size(262, 293);
            this.gbApuestas.TabIndex = 3;
            this.gbApuestas.TabStop = false;
            this.gbApuestas.Text = "Apuestas";
            // 
            // rbNumero
            // 
            this.rbNumero.AutoSize = true;
            this.rbNumero.Checked = true;
            this.rbNumero.Location = new System.Drawing.Point(20, 252);
            this.rbNumero.Name = "rbNumero";
            this.rbNumero.Size = new System.Drawing.Size(62, 17);
            this.rbNumero.TabIndex = 17;
            this.rbNumero.TabStop = true;
            this.rbNumero.Text = "Numero";
            this.rbNumero.UseVisualStyleBackColor = true;
            this.rbNumero.CheckedChanged += new System.EventHandler(this.rbNumero_CheckedChanged);
            // 
            // rbPasa
            // 
            this.rbPasa.AutoSize = true;
            this.rbPasa.Location = new System.Drawing.Point(131, 192);
            this.rbPasa.Name = "rbPasa";
            this.rbPasa.Size = new System.Drawing.Size(49, 17);
            this.rbPasa.TabIndex = 16;
            this.rbPasa.Text = "Pasa";
            this.rbPasa.UseVisualStyleBackColor = true;
            this.rbPasa.CheckedChanged += new System.EventHandler(this.rbPasa_CheckedChanged);
            // 
            // rbFalta
            // 
            this.rbFalta.AutoSize = true;
            this.rbFalta.Location = new System.Drawing.Point(20, 192);
            this.rbFalta.Name = "rbFalta";
            this.rbFalta.Size = new System.Drawing.Size(48, 17);
            this.rbFalta.TabIndex = 15;
            this.rbFalta.Text = "Falta";
            this.rbFalta.UseVisualStyleBackColor = true;
            this.rbFalta.CheckedChanged += new System.EventHandler(this.rbFalta_CheckedChanged);
            // 
            // rbImpar
            // 
            this.rbImpar.AutoSize = true;
            this.rbImpar.Location = new System.Drawing.Point(131, 125);
            this.rbImpar.Name = "rbImpar";
            this.rbImpar.Size = new System.Drawing.Size(51, 17);
            this.rbImpar.TabIndex = 14;
            this.rbImpar.Text = "Impar";
            this.rbImpar.UseVisualStyleBackColor = true;
            this.rbImpar.CheckedChanged += new System.EventHandler(this.rbImpar_CheckedChanged);
            // 
            // rbPar
            // 
            this.rbPar.AutoSize = true;
            this.rbPar.Location = new System.Drawing.Point(20, 125);
            this.rbPar.Name = "rbPar";
            this.rbPar.Size = new System.Drawing.Size(41, 17);
            this.rbPar.TabIndex = 13;
            this.rbPar.Text = "Par";
            this.rbPar.UseVisualStyleBackColor = true;
            this.rbPar.CheckedChanged += new System.EventHandler(this.rbPar_CheckedChanged);
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(131, 57);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(54, 17);
            this.rbNegro.TabIndex = 12;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = true;
            this.rbNegro.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(20, 57);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(47, 17);
            this.rbRojo.TabIndex = 11;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rbRojo_CheckedChanged);
            // 
            // nudNumero
            // 
            this.nudNumero.Enabled = false;
            this.nudNumero.Location = new System.Drawing.Point(133, 249);
            this.nudNumero.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(52, 20);
            this.nudNumero.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apostar numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apostar Falta o Pasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apostar Pares o Impares:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apostar Color:";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lbResultado);
            this.gbResultados.Controls.Add(this.label16);
            this.gbResultados.Controls.Add(this.lbApuestaJugador);
            this.gbResultados.Controls.Add(this.label14);
            this.gbResultados.Controls.Add(this.lbFaltaPasaPremio);
            this.gbResultados.Controls.Add(this.label12);
            this.gbResultados.Controls.Add(this.lbParImparPremio);
            this.gbResultados.Controls.Add(this.label10);
            this.gbResultados.Controls.Add(this.lbColorPremio);
            this.gbResultados.Controls.Add(this.label8);
            this.gbResultados.Controls.Add(this.lbNumPremio);
            this.gbResultados.Controls.Add(this.label6);
            this.gbResultados.Enabled = false;
            this.gbResultados.Location = new System.Drawing.Point(298, 68);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(290, 293);
            this.gbResultados.TabIndex = 4;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(214, 196);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 11;
            this.lbResultado.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Resultado: ";
            // 
            // lbApuestaJugador
            // 
            this.lbApuestaJugador.AutoSize = true;
            this.lbApuestaJugador.Location = new System.Drawing.Point(214, 161);
            this.lbApuestaJugador.Name = "lbApuestaJugador";
            this.lbApuestaJugador.Size = new System.Drawing.Size(0, 13);
            this.lbApuestaJugador.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Apuesta Jugador: ";
            // 
            // lbFaltaPasaPremio
            // 
            this.lbFaltaPasaPremio.AutoSize = true;
            this.lbFaltaPasaPremio.Location = new System.Drawing.Point(214, 124);
            this.lbFaltaPasaPremio.Name = "lbFaltaPasaPremio";
            this.lbFaltaPasaPremio.Size = new System.Drawing.Size(0, 13);
            this.lbFaltaPasaPremio.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Falta/Pasa: ";
            // 
            // lbParImparPremio
            // 
            this.lbParImparPremio.AutoSize = true;
            this.lbParImparPremio.Location = new System.Drawing.Point(214, 93);
            this.lbParImparPremio.Name = "lbParImparPremio";
            this.lbParImparPremio.Size = new System.Drawing.Size(0, 13);
            this.lbParImparPremio.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Par/Impar: ";
            // 
            // lbColorPremio
            // 
            this.lbColorPremio.AutoSize = true;
            this.lbColorPremio.Location = new System.Drawing.Point(214, 61);
            this.lbColorPremio.Name = "lbColorPremio";
            this.lbColorPremio.Size = new System.Drawing.Size(0, 13);
            this.lbColorPremio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Color: ";
            // 
            // lbNumPremio
            // 
            this.lbNumPremio.AutoSize = true;
            this.lbNumPremio.Location = new System.Drawing.Point(214, 32);
            this.lbNumPremio.Name = "lbNumPremio";
            this.lbNumPremio.Size = new System.Drawing.Size(0, 13);
            this.lbNumPremio.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero Ganador:";
            // 
            // btnRepetir
            // 
            this.btnRepetir.BackColor = System.Drawing.Color.Blue;
            this.btnRepetir.Enabled = false;
            this.btnRepetir.Location = new System.Drawing.Point(90, 386);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(123, 28);
            this.btnRepetir.TabIndex = 5;
            this.btnRepetir.Text = "Volver a jugar";
            this.btnRepetir.UseVisualStyleBackColor = false;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(375, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Dejar de Jugar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApostar.Location = new System.Drawing.Point(229, 386);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(127, 28);
            this.btnApostar.TabIndex = 7;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = false;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lbApuesta
            // 
            this.lbApuesta.AutoSize = true;
            this.lbApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApuesta.Location = new System.Drawing.Point(165, 24);
            this.lbApuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApuesta.Name = "lbApuesta";
            this.lbApuesta.Size = new System.Drawing.Size(77, 20);
            this.lbApuesta.TabIndex = 9;
            this.lbApuesta.Text = "Apuesta: ";
            // 
            // nudApuesta
            // 
            this.nudApuesta.Location = new System.Drawing.Point(242, 28);
            this.nudApuesta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudApuesta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudApuesta.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudApuesta.Name = "nudApuesta";
            this.nudApuesta.Size = new System.Drawing.Size(90, 20);
            this.nudApuesta.TabIndex = 10;
            this.nudApuesta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Casino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(599, 442);
            this.Controls.Add(this.nudApuesta);
            this.Controls.Add(this.lbApuesta);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRepetir);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbApuestas);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Casino";
            this.Text = "Casino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Casino_FormClosing);
            this.gbApuestas.ResumeLayout(false);
            this.gbApuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.GroupBox gbApuestas;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbApuestaJugador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbFaltaPasaPremio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbParImparPremio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbColorPremio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNumPremio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.RadioButton rbNumero;
        private System.Windows.Forms.RadioButton rbPasa;
        private System.Windows.Forms.RadioButton rbFalta;
        private System.Windows.Forms.RadioButton rbImpar;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.Label lbApuesta;
        private System.Windows.Forms.NumericUpDown nudApuesta;
    }
}

