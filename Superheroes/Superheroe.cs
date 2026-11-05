using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Superheroes
{
    public partial class Superheroe : ObservableObject
    {
        // Genera automáticamente la propiedad "Nombre".
        [ObservableProperty]
        private string? _nombre;

        // Genera automáticamente la propiedad "ImagenRuta".
        [ObservableProperty]
        private string? _imagenRuta;

        // Genera automáticamente la propiedad "Vengador".
        [ObservableProperty]
        private bool _vengador;

        // Genera automáticamente la propiedad "Xmen".
        [ObservableProperty]
        private bool _xmen;

        // Genera automáticamente la propiedad "Heroe".
        [ObservableProperty]
        private bool _heroe;

        // Constructores.
        public Superheroe()
        {
            Nombre = string.Empty;
            ImagenRuta = string.Empty;
            Vengador = false;
            Xmen = false;
            Heroe = false;
        }

        public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            ImagenRuta = imagenRuta;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }
    }
}
