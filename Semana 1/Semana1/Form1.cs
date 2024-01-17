namespace Semana1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una variable para abrir el formulario de F_Suma
            F_suma f_Suma =  new F_suma();

            // Muestra el formulario 
            f_Suma.Show();
        }
    }
}