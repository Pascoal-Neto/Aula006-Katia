using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero = "";
        Candidato alguem;
        Candidato[] lista = new Candidato[4];
        int branco = 0, nulo = 0;

        private void insereCandidato()
        {
            alguem = new Candidato();
            alguem.Numero = 12;
            alguem.Nome = "Antonio Silva";
            alguem.Turma = "1° ADS";
            alguem.Foto = "antonio.jpg";
            lista[0] = alguem;

            alguem = new Candidato();
            alguem.Numero = 13;
            alguem.Nome = "Joana Lima";
            alguem.Turma = "1° ADS";
            alguem.Foto = "Joana.jpg";
            lista[1] = alguem;

            alguem = new Candidato();
            alguem.Numero = 14;
            alguem.Nome = "Frederico Ferreira";
            alguem.Turma = "1° ADS";
            alguem.Foto = "Frederico.jpg";
            lista[2] = alguem;

            alguem = new Candidato();
            alguem.Numero = 15;
            alguem.Nome = "Vivian Almeida";
            alguem.Turma = "1° ADS";
            alguem.Foto = "Vivian.jpg";
            lista[3] = alguem;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false; //desabilitar o campo de texto
            txtNum2.Enabled = false;
            btnconfirma.Enabled = false; //desabilitao botão confirma
            lblmensagem.Enabled = false; //Panel ocultada
            insereCandidato();
        }
        
        private void Preenche(string n)
        {
            if (numero.Length == 0)
            {
                txtNum1.Text = n;
                numero += n; //numero=numero+n
            }
            else
            {
               txtNum2.Text = n;
                numero += n; //numero=numero+n
                for (int i = 0; i < 4; i++)
                {
                    if (Convert.ToInt32(numero) == lista[i].Numero)
                    {
                        lblcanditato.Text = lista[i].Nome;
                        lblturma.Text = lista[i].Turma;
                        pxfoto.Image = Image.FromFile(@"" + lista[i].Foto);
                        i = 3;
                    }
                    else
                    {
                        lblcanditato.Text = "VOTO NULO";

                    }
                    lblmensagem.Visible = true;
                    btnconfirma.Enabled = true;
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Preenche("8");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Preenche("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Preenche("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Preenche("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Preenche("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Preenche("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Preenche("7");
        }

        private void pxfoto_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Preenche("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Preenche("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Preenche("1");
        }

       
    }
}
