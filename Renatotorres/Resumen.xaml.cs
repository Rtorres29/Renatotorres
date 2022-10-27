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
    public partial class Resumen : ContentPage
    {

        public Resumen(String usuario, double totalFinal, String estudiante)
        {
            InitializeComponent();
            lblEstudiante.Text=estudiante;
            lblNotaFinal.Text = totalFinal.ToString();
            lblUsuario.Text = usuario;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}