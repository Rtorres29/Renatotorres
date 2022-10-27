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
    public partial class Registro : ContentPage
    {
        String Usuario = "";
        String Estudiante = "";
        double TotalFinal = 0;
        public Registro( string usuario, string contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario+".";
            this.Usuario = usuario;
        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try { 
            double cutoaInicial = double.Parse(e.NewTextValue);
                if(cutoaInicial<1 && cutoaInicial > 3000)
                {
                    DisplayAlert("ERROR", "la cuota inicial debe estar entre 1 y 3000", "Aceptar");
                    return;
                }
                double valorMensualCalculado = ((3000 - cutoaInicial) / 5) + (3000 * 0.05);
                double totalFinal = cutoaInicial + (valorMensualCalculado * 5);
                TotalFinal = totalFinal;
                txtPago.Text = valorMensualCalculado.ToString();
                Estudiante= txtEstudiante.Text;
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", "El valor ingresado en la cuota inicial es inválido", "Aceptar");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (TotalFinal == 0) { 
            DisplayAlert("ERROR", "Cuota mensual aún no ha sido calculada", "Aceptar");
                return;
            }
            DisplayAlert("CORRECTO", "Elemento guardado con éxito", "Aceptar");
            Navigation.PushAsync(new Resumen(Usuario, TotalFinal, Estudiante));
        }
    }
}