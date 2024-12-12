using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alvaro_Practica3.Models;

namespace Alvaro_Practica3;

public static class Carrito
{
    // Lista estática para almacenar los artículos seleccionados
    public static List<Articulo> Articulos { get; } = new List<Articulo>();

    // Método para calcular el total
    public static double CalcularTotal()
    {
        return Articulos.Sum(a => double.Parse(a.Precio.Replace("€", "").Trim()));
    }
}

