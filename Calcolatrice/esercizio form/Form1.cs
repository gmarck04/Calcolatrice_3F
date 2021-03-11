//Autore: Francesco Di Lena
//Classe: 3 F

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            risultatoTxt.Text = "Risultato";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 100, 0);
            
            Random x = new Random();
            BackColor = Color.FromArgb(x.Next(0,256),100,100);

            numero1Txt.AutoCompleteCustomSource.Clear();
            for(int i=0; i < 1000; i=i+5)
            {

                // testo1Txt.AutoCompleteCustomSource.Add(i.ToString());
                numero1Txt.AutoCompleteCustomSource.Add(i.ToString().PadLeft(3,'0'));
            }
        }

        private void bottone1btn_Click(object sender, EventArgs e)
        {
            int n1 = 0; int n2 = 0;

            // n1 = Convert.ToInt32(testo1Txt.Text);
            
            // n2 = Convert.ToInt32(testo2Txt.Text);

            bool conversionevalida = int.TryParse(numero1Txt.Text, out n1);

           // bool conversionevalida2 = int.TryParse(testo2Txt.Text, out n2);

            if (!conversionevalida)  // if(conversionevalida==false)
            {
                numero1Txt.BackColor = Color.Red;
                MessageBox.Show("ERRORE: accetto solo numeri positivi");
                numero1Txt.Clear();
                numero1Txt.Focus();
                numero1Txt.BackColor = Color.White;
            }
            else
            {

                if (n1 < 0)
                {
                    MessageBox.Show("ERRORE: accetto solo numeri positivi");
                    numero1Txt.Clear();
                    numero1Txt.Focus();
                }
                else
                {


                    if (!int.TryParse(numero2Txt.Text, out n2))// if(conversionevalida2==false)
                    {

                        numero2Txt.BackColor = Color.Red;
                        MessageBox.Show("ERRORE: accetto solo numeri positivi");
                        numero1Txt.Clear();
                        numero1Txt.Focus();
                        numero2Txt.BackColor = Color.White;
                    }
                    else
                    {
                        if (n2 < 0)
                        {
                            MessageBox.Show("ERRORE: accetto solo numeri positivi");
                            numero1Txt.Clear();
                            numero1Txt.Focus();

                        }
                       
                    }
                    
                }
                
                }


            int n3 = n1 + n2;

            risultatoTxt.Text = Convert.ToString(n3);

            //if(!int.TryParse(testo2txt.Text, out n2))

        }
        //if (testo1Txt.Text=="")

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            numero1Txt.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            numero1Txt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bottone2btn_Click(object sender, EventArgs e)
        {



        }

        private void testo1Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void testo2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void testo3Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void testoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void maiuscoleBtn_Click(object sender, EventArgs e)
        {
            testoTB.CharacterCasing = CharacterCasing.Upper;
            numero1Txt.Cursor = Cursors.Hand;
        }

        private void ControlloFontBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(risultatoTxt.Font.Bold.ToString());

            risultatoTxt.Font = new Font("Century Gothic", 30, FontStyle.Underline);
        }
    }

}
