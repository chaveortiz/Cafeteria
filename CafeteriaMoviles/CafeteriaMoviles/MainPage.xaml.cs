
using Cafeteria.BIZ;
using Cafeteria.COMMON.Entidades;
using Cafeteria.COMMON.Interfaces;
using Cafeteria.DAL;
using CafeteriaMoviles.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CafeteriaMoviles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IUsuario manager = new UsuarioManager(new GenericRepository<Usuario>());
            btnIniciarSesion.Clicked += (sender, e) =>
            {
                Usuario usuario = manager.Login(txbUsuario.Text, pssClave.Text);
                if (usuario != null)
                {
                    Navigation.PushAsync(new Vistas.Productos());
                }
                else
                {
                    DisplayAlert("Mi Escuela", "Usuario o contraseña incorrectos", "Ok");
                }

            };
            btnCrearCuenta.Clicked += (sender, e) =>
            {
                Usuario usuario = manager.CrearCuenta(txbUsuario.Text, pssClave.Text);
                if (usuario != null)
                {
                    DisplayAlert("Mi escuela", "Cuenta Creada correctamente", "OK");
                    Navigation.PushAsync(new Vistas.Ventas());
                }
                else
                {
                    DisplayAlert("Mi escuela", "Error al crear cuenta", "OK");
                }
            };
        }
    }
}