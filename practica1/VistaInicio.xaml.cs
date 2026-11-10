using System.Windows;
using System.Windows.Controls;

namespace practica1 {
    public partial class VistaInicio : UserControl {
        public VistaInicio() {
            InitializeComponent();
        }

        private void VerGaleria_Click(object sender, RoutedEventArgs e) {
            MainWindow ventana = Window.GetWindow(this) as MainWindow;

            if (ventana != null) {
                ventana.MostrarGaleria();
            }
        }
    }
}
