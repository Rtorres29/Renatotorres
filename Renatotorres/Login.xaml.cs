using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Renatotorres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "renatotorres2022";
            string clave = "uisrael2022";



            string tUsuario = txtUsuario.Text;
            string tContrasenia = txtClave.Text;

            if (usuario == tUsuario & clave == tContrasenia)
            {
               await Navigation.PushAsync(new Registro( txtUsuario.Text, txtClave.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario  Ingresado no es correcto ", "cerrar");

            }

        
    }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new Registro(txtUsuario.Text, txtClave.Text));
        }

    }
        }
