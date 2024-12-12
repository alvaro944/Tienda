using Microsoft.Maui.Controls;
using Alvaro_Practica3.Models;

namespace Alvaro_Practica3.Views
{
    public partial class DetalleArticuloPage : TabbedPage
    {
        public DetalleArticuloPage(Articulo articulo)
        {
            InitializeComponent();

            // Configura los datos del artículo
            DescripcionLabel.Text = $"Detalles del {articulo.Nombre}";
            PrecioLabel.Text = articulo.Precio;

            // Simula una lista de opiniones
            var opiniones = new List<Opinion>
            {
                new Opinion { Autor = "Usuario1", Comentario = "Excelente producto" },
                new Opinion { Autor = "Usuario2", Comentario = "Muy buena calidad" },
                new Opinion { Autor = "Usuario3", Comentario = "Me llegó en malas condiciones" }
            };

            OpinionesListView.ItemsSource = opiniones;
        }

        private void OnAddToCartClicked(object sender, EventArgs e)
        {
            // Añadir el artículo al carrito
            Carrito.Articulos.Add(new Articulo
            {
                Nombre = DescripcionLabel.Text,
                Precio = PrecioLabel.Text
            });

            DisplayAlert("Carrito", "Artículo añadido al carrito.", "OK");
        }



    }

    public class Opinion
    {
        public string? Autor { get; set; }
        public string? Comentario { get; set; }
    }
}
