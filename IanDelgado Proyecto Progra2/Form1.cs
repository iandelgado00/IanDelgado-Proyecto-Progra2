using System;
using System.Windows.Forms;

namespace IanDelgado_Proyecto_Progra2
{
    public partial class Form1 : Form
    {
        private static readonly Random rng = new Random();

        // Variables del juego
        int n1 = 0, n2 = 0, resultado = 0;
        char operador = '+';

        int nivel = 1;
        int aciertos = 0;
        int fallos = 0;

        int aciertosConsecutivos = 0;
        int fallosConsecutivos = 0;

        bool esDosJugadores = false;
        int turnoJugador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            esDosJugadores = false;
            if (lbltur != null) lbltur.Visible = false;
            ActualizarPantalla();
            NuevaOperacion();
        }
        private void boton1_Click(object sender, EventArgs e)
        {
            esDosJugadores = false;
            if (lbltur != null) lbltur.Visible = false;
            ReiniciarJuego();
            MessageBox.Show("Modo 1 Jugador seleccionado.", "Juego de mate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void boton2_Click(object sender, EventArgs e)
        {
            esDosJugadores = true;
            if (lbltur != null) lbltur.Visible = true;
            turnoJugador = rng.Next(1, 3);
            ReiniciarJuego();
            ActualizarTurnoVisual();
            MessageBox.Show($"Modo 2 Jugadores seleccionado.\nempieza el Jugador {turnoJugador}", "Sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReiniciarJuego()
        {
            nivel = 1;
            aciertos = 0;
            fallos = 0;
            aciertosConsecutivos = 0;
            fallosConsecutivos = 0;
            ActualizarPantalla();
            NuevaOperacion();
        }

        private void NuevaOperacion()
        {
            int rangoMaximo = 10 * nivel;
            char[] operadores = { '+', '-', '*', '/' };
            operador = operadores[rng.Next(operadores.Length)];

            if (operador == '/')
            {
                
                n2 = rng.Next(1, rangoMaximo + 1);
                int cociente = rng.Next(1, 10 + (nivel * 2));
                n1 = n2 * cociente; 
                resultado = cociente;
            }
            else
            {
                n1 = rng.Next(1, rangoMaximo + 1);
                n2 = rng.Next(1, rangoMaximo + 1);

                switch (operador)
                {
                    case '+':
                        resultado = n1 + n2;
                        break;
                    case '-':
                        if (n1 < n2) { int temp = n1; n1 = n2; n2 = temp; } 
                        resultado = n1 - n2;
                        break;
                    case '*':
                        resultado = n1 * n2;
                        break;
                }
            }

            
            if (lblNum1 != null) lblNum1.Text = n1.ToString();
            if (lblNum2 != null) lblNum2.Text = n2.ToString();

            Control[] encontrados = this.Controls.Find("lblOperador", true);
            if (encontrados.Length > 0 && encontrados[0] is Label lblOp)
            {
                lblOp.Text = operador.ToString();
            }

            if (txtRespuesta != null)
            {
                txtRespuesta.Clear();
                txtRespuesta.Focus();
            }
        }

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta == null || !int.TryParse(txtRespuesta.Text, out int respuestaUsuario))
            {
                MessageBox.Show("ingrese un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtRespuesta != null)
                {
                    txtRespuesta.Clear();
                    txtRespuesta.Focus();
                }
                return;
            }

            bool esCorrecta = (resultado == respuestaUsuario);

            if (esCorrecta)
            {
                MessageBox.Show("Respuesta Correcta", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aciertos++;
                aciertosConsecutivos++;
                fallosConsecutivos = 0;

                if (aciertosConsecutivos == 3)
                {
                    nivel++;
                    aciertosConsecutivos = 0;
                    MessageBox.Show($"Subieron al Nivel {nivel}.", "Subida de Nivel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Incorrecto. El resultado es: {resultado}", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fallos++;
                fallosConsecutivos++;
                aciertosConsecutivos = 0;

                if (fallosConsecutivos == 3 && nivel > 1)
                {
                    nivel--;
                    fallosConsecutivos = 0;
                    MessageBox.Show($"Bajaron al Nivel {nivel}.", "Bajada de Nivel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            ActualizarPantalla();

            if (esDosJugadores)
            {
                turnoJugador = (turnoJugador == 1) ? 2 : 1;
                ActualizarTurnoVisual();
            }

            NuevaOperacion();
        }

        private void ActualizarPantalla()
        {
            if (lbl1 != null) lbl1.Text = nivel.ToString();
            if (aci0 != null) aci0.Text = aciertos.ToString();
            if (fall0 != null) fall0.Text = fallos.ToString();
        }

        private void ActualizarTurnoVisual()
        {
            if (lbltur == null) return;

            if (turnoJugador == 1)
            {
                lbltur.Text = "Turno: Jugador 1";
                lbltur.BackColor = System.Drawing.Color.Yellow;
                lbltur.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lbltur.Text = "Turno: Jugador 2";
                lbltur.BackColor = System.Drawing.Color.Blue;
                lbltur.ForeColor = System.Drawing.Color.White;
            }
        }

        // estas son las veces que hice doble click sin querer en los labels y el panel, no hacen nada pero no quiero borrarlas por si acaso
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void aci0_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void boton2_Click_1(object sender, EventArgs e)
        {
            boton2_Click(sender, e);
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            btnAceptar_Click(sender, e);
        }
    }
}