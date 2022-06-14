using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        int turno = 0;
        int cont = 0;

        private void iniciar()
        {
            lblPlay.Text = "";
            lblEmpezar.Text = "¡Tu Comienzas!";
            pbxPlayerVsCP.BackgroundImage = TresEnRaya.Properties.Resources.playerVSpc;
            lblPlay.Text = "JUGADOR:X \n              CPU:O";
            lblPlay.Location = new Point(48,2);
            lblPlay.BackColor = Color.Transparent;
            btn1.Enabled = true;
            btn1.BackgroundImage = null;
            btn1.Text = "";
            btn2.Enabled = true;
            btn2.BackgroundImage = null;
            btn2.Text = "";
            btn3.Enabled = true;
            btn3.BackgroundImage = null;
            btn3.Text = "";
            btn4.Enabled = true;
            btn4.BackgroundImage = null;
            btn4.Text = "";
            btn5.Enabled = true;
            btn5.BackgroundImage = null;
            btn5.Text = "";
            btn6.Enabled = true;
            btn6.BackgroundImage = null;
            btn6.Text = "";
            btn7.Enabled = true;
            btn7.BackgroundImage = null;
            btn7.Text = "";
            btn8.Enabled = true;
            btn8.BackgroundImage = null;
            btn8.Text = "";
            btn9.Enabled = true;
            btn9.BackgroundImage = null;
            btn9.Text = "";
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            iniciar();
            
        }

        private void jugar(Button a)
        {
            lblEmpezar.Text = "";
            if (turno == 0)
            {
                a.BackgroundImage = TresEnRaya.Properties.Resources.X;
                a.Enabled = false;
                a.Text = "X";
                turno = 1;

                if (btn1.BackgroundImage != null || btn2.BackgroundImage != null || btn3.BackgroundImage != null || btn4.BackgroundImage != null || btn7.BackgroundImage != null)
                {
                    validarGanador();
                }

                while (turno == 1 && cont < 4)
                {
                    Random ran = new Random();
                    int ranNum = ran.Next(1, 10);
                    string namebtn = "btn" + ranNum.ToString();
                    switch (namebtn)
                    {
                        case "btn1":
                            if (btn1.BackgroundImage == null)
                            {
                                btn1.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn1.Text = "O";
                                btn1.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn2":
                            if (btn2.BackgroundImage == null)
                            {
                                btn2.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn2.Text = "O";
                                btn2.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn3":
                            if (btn3.BackgroundImage == null)
                            {
                                btn3.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn3.Text = "O";
                                btn3.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn4":
                            if (btn4.BackgroundImage == null)
                            {
                                btn4.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn4.Text = "O";
                                btn4.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn5":
                            if (btn5.BackgroundImage == null)
                            {
                                btn5.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn5.Text = "O";
                                btn5.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn6":
                            if (btn6.BackgroundImage == null)
                            {

                                btn6.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn6.Text = "O";
                                btn6.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn7":
                            if (btn7.BackgroundImage == null)
                            {
                                btn7.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn7.Text = "O";
                                btn7.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn8":
                            if (btn8.BackgroundImage == null)
                            {
                                btn8.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn8.Text = "O";
                                btn8.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                        case "btn9":
                            if (btn9.BackgroundImage == null)
                            {
                                btn9.BackgroundImage = TresEnRaya.Properties.Resources.O;
                                btn9.Text = "O";
                                btn9.Enabled = false;
                                turno = 0;
                                cont++;
                                validarGanador();
                            }
                            break;
                    }

                }

            }


        }

        private void validarGanador()
        {
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                Resultado resultado = new Resultado();
                if (btn1.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn1.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                Resultado resultado = new Resultado();
                if (btn4.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn4.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                Resultado resultado = new Resultado();
                if (btn7.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn7.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                Resultado resultado = new Resultado();
                if (btn1.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn1.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                Resultado resultado = new Resultado();
                if (btn2.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn2.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Resultado resultado = new Resultado();
                if (btn3.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn3.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                Resultado resultado = new Resultado();
                if (btn1.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn1.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                Resultado resultado = new Resultado();
                if (btn3.Text == "X")
                {
                    resultado.lblResultado.Text = "¡GANASTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.ganaste;
                    resultado.ShowDialog();
                }
                else if (btn3.Text == "O")
                {
                    resultado.lblResultado.Text = "¡PERDISTE!";
                    resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.perdiste;
                    resultado.ShowDialog();
                }

            }
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                Resultado resultado = new Resultado();
                resultado.lblResultado.Text = "¡EMPATE!";
                resultado.pbxResultado.BackgroundImage = TresEnRaya.Properties.Resources.empate;
                resultado.ShowDialog();
            }
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            jugar(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            jugar(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            jugar(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            jugar(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            jugar(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            jugar(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            jugar(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            jugar(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            jugar(btn9);
        }
    }
}
