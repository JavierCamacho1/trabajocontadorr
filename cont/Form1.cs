using System;

namespace cont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        int[] arreglo = new int[3];
        byte contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador == 3)
            {
                MessageBox.Show("Ya se lleno el arreglo", MessageBoxIcon.Warning.ToString());
                txt1.Clear();
            }
            else
            {
                if (string.IsNullOrEmpty(txt1.Text))
                {
                    MessageBox.Show("Porfavor escribe un digito!");
                    txt1.Focus();
                }
                else
                {
                    int valor = int.Parse(txt1.Text);
                    arreglo[contador] = valor;
                    contador++;
                    txt1.Clear();
                    txt1.Focus();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                int num = arreglo[i];
                lis2.Items.Add("Entrada de muestra: " + num);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            lis2.Items.Clear();
            txt1.Focus();
        }
    }
}