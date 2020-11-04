using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Romanos2sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numerito = Convert.ToInt32(txtnumerito.Text);
            int roman=1;
            if (numerito<1000 )
            {
                MessageBox.Show("TU numero no esta en el rango de numeros aceptados");
            }
            switch (numerito)
            {
                

            }



            MessageBox.Show("EL numero ingresado en romano es :" + roman);

        }
    }
}
