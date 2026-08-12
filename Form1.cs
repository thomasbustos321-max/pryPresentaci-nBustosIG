namespace pryPresentaciònBustosIG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = " hola, soy " + txtNombre.Text + " " + txtApellido.Text + " " + "tengo" + txtEdad.Text + " " + "años, y estudio " + txtCarrera.Text; 

        }
    }
}
