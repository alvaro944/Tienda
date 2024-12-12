using Microsoft.Maui.Controls;
using Alvaro_Practica3.Models;

namespace Alvaro_Practica3.Views
{
    public partial class ArticulosPage : ContentPage
    {
        public ArticulosPage()
        {
            InitializeComponent();

            // Simulamos una lista de art�culos
            var articulos = new List<Articulo>
            {
                new Articulo { Nombre = "Art�culo 1", Precio = "10.99 �" },
                new Articulo { Nombre = "Art�culo 2", Precio = "20.50 �" },
                new Articulo { Nombre = "Art�culo 3", Precio = "15.75 �" }
            };

            // Asignamos la lista al ListView
            ArticulosListView.ItemsSource = articulos;

            // Evento para navegar al detalle
            ArticulosListView.ItemSelected += OnArticuloSelected;
        }

        // M�todo que maneja la selecci�n de un art�culo
        private void OnArticuloSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Articulo articulo)
            {
                // Navegamos a la p�gina de detalle pasando el art�culo seleccionado
                Navigation.PushAsync(new DetalleArticuloPage(articulo));

                // Limpiamos la selecci�n
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
