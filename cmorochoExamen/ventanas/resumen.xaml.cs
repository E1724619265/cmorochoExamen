using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cmorochoExamen.ventanas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(string usuario, string nombre, string total )
        {
            InitializeComponent();

            lblusuario.Text = usuario;
            lblnombre.Text = nombre;
            lbltotal.Text = total;
        }

        private void btnacerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Informacion", "Este calculo lo realizo el Sr. Cristian Morocho estudiante de noveno sistemas", "Cerrar");
        }
    }
}