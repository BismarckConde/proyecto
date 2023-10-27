namespace PracticaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Coprovacion();
        }

        private void Coprovacion()
        {

            if (txtUsuario.Text.Equals("Gustavo") && txtContra.Text.Equals("Gaem0610"))
            {
                MessageBox.Show($"Bienvenido otra vez {txtUsuario.Text}!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal nomina = new Principal();
                this.Hide();
                nomina.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}