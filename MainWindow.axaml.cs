using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion
{
    public partial class MainWindow : Window
    {
        private bool _saludoAlternativo = false;

        public MainWindow()
        {
            InitializeComponent();
            Opened += (_, _) => TxtNombre.Focus();
        }

        private void BtnPresentarme_Click(object? sender, RoutedEventArgs e)
        {
            string nombre = TxtNombre.Text?.Trim() ?? string.Empty;
            string apellido = TxtApellido.Text?.Trim() ?? string.Empty;
            string textoEdad = TxtEdad.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(nombre))
            {
                TxtResultado.Text = "Advertencia: El nombre no puede estar vacío ni contener solo espacios.";
                TxtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                TxtResultado.Text = "Advertencia: El apellido no puede estar vacío ni contener solo espacios.";
                TxtApellido.Focus();
                return;
            }

            if (!int.TryParse(textoEdad, out int edad))
            {
                TxtResultado.Text = "Advertencia: Ingresa la edad como un número entero.";
                TxtEdad.Focus();
                return;
            }

            if (edad <= 0)
            {
                TxtResultado.Text = "Advertencia: La edad debe ser mayor que cero.";
                TxtEdad.Focus();
                return;
            }

            if (!_saludoAlternativo)
            {
                TxtResultado.Text = $"¡Hola! Mi nombre es {nombre} {apellido},\n" +
                                    $"tengo {edad} años y estoy aprendiendo\n" +
                                    $"a desarrollar interfaces gráficas con C#.";
            }
            else
            {
                TxtResultado.Text = $"¡Qué tal, {nombre} {apellido}!\n" +
                                    $"Registramos tus {edad} años exitosamente en el sistema.\n" +
                                    $"¡Excelente trabajo dominando Avalonia UI!";
            }
        }

        private void BtnLimpiar_Click(object? sender, RoutedEventArgs e)
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtEdad.Text = string.Empty;
            TxtResultado.Text = "Resultados y mensajes aparecerán aquí.";
            _saludoAlternativo = false;
            TxtNombre.Focus();
        }

        private void BtnCambiarSaludo_Click(object? sender, RoutedEventArgs e)
        {
            _saludoAlternativo = !_saludoAlternativo;

            string estado = _saludoAlternativo ? "Alternativo" : "Estándar";
            TxtResultado.Text = $"Modo de saludo cambiado a: {estado}. Presiona \"Presentarme\" para ver el resultado.";
        }
    }
}