using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana1
{
    public partial class F_suma : Form
    {
        public F_suma()
        {
            InitializeComponent();
        }

        private void bt_sumar_Click(object sender, EventArgs e)
        {
            // Declaracion de variables

            int valor1 = 0;
            int valor2 = 0;
            int total = 0;

            // Convertir los valores de textBox de String to Int
            total = Convert.ToInt32(tb_num_1.Text) + Convert.ToInt32(tb_num_2);

            // Convertir el la suma de valor 1 y valor 2 a String y lo muestra en textBox
            tb_total.Text = Convert.ToString(total);

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos lo textBox

            tb_num_1.Clear();
            tb_num_2.Clear();
            tb_total.Clear();
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.Close();
        }
    }
}
