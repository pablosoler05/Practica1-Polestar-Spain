using System.Windows;
using System.Windows.Input;

namespace practica1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ContenidoPrincipal.Content = new VistaInicio();
        }

        private void BotonMenu_Click(object sender, RoutedEventArgs e) {
            if (CapaMenu.Visibility == Visibility.Visible) {
                CerrarMenu();
            } else {
                CapaMenu.Visibility = Visibility.Visible;
            }
        }

        private void CerrarMenu() {
            CapaMenu.Visibility = Visibility.Collapsed;
        }

        private void CerrarMenu_Click(object sender, RoutedEventArgs e) {
            CerrarMenu();
        }

        private void IrInicio_Click(object sender, RoutedEventArgs e) {
            ContenidoPrincipal.Content = new VistaInicio();
            CerrarMenu();
        }

        private void IrIdentificacion_Click(object sender, RoutedEventArgs e) {
            ContenidoPrincipal.Content = new VistaIdentificacion();
            CerrarMenu();
        }

        private void IrGaleria_Click(object sender, RoutedEventArgs e) {
            MostrarGaleria();
        }

        public void MostrarGaleria() {
            ContenidoPrincipal.Content = new VistaGaleria();
            CerrarMenu();
        }

        private void Ventana_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Escape && CapaMenu.Visibility == Visibility.Visible) {
                CerrarMenu();
                BotonMenu.Focus();
                e.Handled = true;
            }
        }
    }
}