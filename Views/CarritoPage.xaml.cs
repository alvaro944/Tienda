using Microsoft.Maui.Controls;

namespace Alvaro_Practica3.Views
{
    public partial class CarritoPage : ContentPage
    {
        public CarritoPage()
        {
            InitializeComponent();
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            // Asigna la lista de artículos al ListView
            CarritoListView.ItemsSource = Carrito.Articulos;

            // Actualiza el total
            TotalLabel.Text = $"Total: {Carrito.CalcularTotal():F2} €";
        }
    }
}
