using System.Windows;
using System.Windows.Controls;

namespace practica1 {
    public partial class VistaIdentificacion : UserControl {
        public VistaIdentificacion() {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e) {
            string User = this.txtUsuario.Text;
            string Password = this.txtPassword.Password;

            if (User == "") {
                MessageBox.Show("Introduce el nombre de usuario.");
                this.txtUsuario.Focus();
                return;
            }

            if (Password == "") {
                MessageBox.Show("Introduce la contraseña.");
                this.txtPassword.Focus();
                return;
            }

            if (User != "Alumno" || Password != "1234") {
                MessageBox.Show("El usuario o la contraseña son incorrectos.");
                this.txtUsuario.Focus();
                return;
            }

            MessageBox.Show("Identificación correcta.");
        }
    }
}