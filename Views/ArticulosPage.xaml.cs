using Microsoft.Maui.Controls;
using Alvaro_Practica3.Models;

namespace Alvaro_Practica3.Views
{
    public partial class ArticulosPage : ContentPage
    {
        public ArticulosPage()
        {
            InitializeComponent();

            // Simulamos una lista de artículos
            var articulos = new List<Articulo>
            {
                new Articulo { Nombre = "Artículo 1", Precio = "10.99 €" },
                new Articulo { Nombre = "Artículo 2", Precio = "20.50 €" },
                new Articulo { Nombre = "Artículo 3", Precio = "15.75 €" }
            };

            // Asignamos la lista al ListView
            ArticulosListView.ItemsSource = articulos;

            // Evento para navegar al detalle
            ArticulosListView.ItemSelected += OnArticuloSelected;
        }

        // Método que maneja la selección de un artículo
        private void OnArticuloSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Articulo articulo)
            {
                // Navegamos a la página de detalle pasando el artículo seleccionado
                Navigation.PushAsync(new DetalleArticuloPage(articulo));

                // Limpiamos la selección
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
