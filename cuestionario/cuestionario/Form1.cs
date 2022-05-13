using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuestionario
{
    public partial class Form1 : Form
    {
        private List<Cuestion> encuesta = new List<Cuestion>();
        private int Preg = 0;
        private int nPreg = 0;
        private int pIntro = 0;
        private int pExtro = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarencuesta();
        }
        private void llenarencuesta()
        {
            //IntroVertido
            Cuestion pregunta = new Cuestion();
            encuesta.Add(new Cuestion
            {
                concepto = "¿Cuándo estas en una reunión con un grupo\nde personas,aportas a la conversación\nparticipando constantemente en ella?",
                res1 = "No, suelo estar callado o alegarme",
                res2 = "Si, me es muy fácil comunicarme ",
            });
            
            encuesta.Add(new Cuestion
            {
                concepto = "Para ti ¿Como prefieres pasar tus tardes?",
                res1 = "En mi habitación jugando\nvideojuegos en línea contras personas ",
                res2 = "Salir a dar una vuelta",
                res3 = "Escuchar música en habitación \no dibujar",
                res4 = "Reunirme con amigos para pasar el rato ",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Crees que un grupo selectivo de personas\nes mejor que un grupo mayor de \nindividuos?",
                res1 = "SI",
                res2 = "NO",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Te es fácil el conocer personas nuevas y\nentablar una conversación por un gran \ntiempo?",
                res1 = "No, me es un poco laborioso el poder dirigirme a las personas",
                res2 = "Si, considero que me es muy fácil socializar con personas nuevas ",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Te consideras una persona solitaria\nmas no tímida?",
                res1 = "Considero que soy una persona que le gusta estar solo,\nen ocasiones disfruto de estar con un grupo selectivo de\npersonas ",
                res2 = "Considero que me es más difícil el conocer o entablar una\n conversación con otras personas y me pongo muy nervioso ",
            });

            //Extrovertido
            encuesta.Add(new Cuestion
            {
                concepto = "¿En general tu grado de sociabilidad es: ?",
                res1 = "Bajo",
                res2 = "Alto",
                res3 = "Medio",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "Te considera una persona?",
                res1 = "Pesimista ",
                res2 = "Optimista",
                res3 = "Realista",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Los fines de semana se te hace más\nagradable?",
                res1 = "Salir con la familia ",
                res2 = "Salir a una fiesta",
                res3 = "Quedarte en casa jugando videojuegos",
                res4 = "Lo que salga para hacer",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Cuando sales te preocupa el que dran de tu\nvestidura?",
                res1 = "No, para nada",
                res2 = "Si, me tomo el tiempo de escoger bien",
            });
            encuesta.Add(new Cuestion
            {
                concepto = "¿Cuando tomas deciciones que sueles hacer?",
                res1 = "¿Analizar correctamente, las variables, posibilidades,\npros y contras de la desición?",
                res2 = "Hacer lo que tu instinto dice que es lo mejor",
            });

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Preg = 0;
            pIntro = 0;
            pExtro = 0;
            realizaPregunta();
         
        }
        private void realizaPregunta()
        {
            Cuestion pregunta = new Cuestion();
            pregunta = encuesta[Preg];
            lbpre.Visible = true;
            lbpre.Text = pregunta.concepto;

            radioButtonA.Visible = true;
            radioButtonA.Text = pregunta.res1;
            radioButtonA.Checked = false;

            radioButtonB.Text = pregunta.res2;
            radioButtonB.Checked = false;
            radioButtonB.Visible = true;

            radioButtonC.Text = pregunta.res3;
            radioButtonC.Checked = false;
            radioButtonC.Visible = true;

            radioButtonD.Text = pregunta.res4;
            radioButtonD.Checked = false;
            radioButtonD.Visible = true;

            btnSig.Visible = true;
            
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            Cuestion pregunta = new Cuestion();
            pregunta = encuesta[Preg];
            btnIniciar.Visible = false;

            if(radioButtonA.Checked == true) { nPreg++; }
            if (radioButtonB.Checked == true) { nPreg++; }
            if (radioButtonC.Checked == true) { nPreg++; }
            if (radioButtonD.Checked == true) { nPreg++; }
            if (Preg < encuesta.Count() - 1)
            {
                Preg++;
                realizaPregunta();
            }
            else
            {
                final();
            }
            if (radioButtonA.Checked == true) { pIntro ++; }
            if (radioButtonB.Checked == true) { pExtro ++; }
            if (radioButtonC.Checked == true) { pIntro ++; }
            if (radioButtonD.Checked == true) { pExtro ++; }
        }
        private void final()
        {
            radioButtonA.Visible = false;
            radioButtonB.Visible = false;
            radioButtonC.Visible = false;
            radioButtonD.Visible = false;
            btnSig.Visible = false;
            lbpre.Visible = false;

                    if (pIntro > pExtro)
                    {
                        MessageBox.Show("Cumple con las caracteristicas de ser una persona Introvertida");
                    }
                    
                    if (pIntro == pExtro)
                    {
                        MessageBox.Show("Es una persona 50% Introvertida a sí como un 50% Extrovertida");
                    }
                   
                    if (pIntro < pExtro)
                    {
                        MessageBox.Show("La mayoria de las caracteristicas que cumple son de una persona Extrovertida");
                    }
            btnIniciar.Visible = true;
        }
    }
}
