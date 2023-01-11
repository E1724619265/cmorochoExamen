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
    public partial class registro : ContentPage
    {
        public registro(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "Usuario Conectado: "+usuario;
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            try
            {


                double inicial = Convert.ToDouble(txtminicial.Text);

                double valor = (4000 - inicial) / 5;
                double ciento = 4000 * 0.05;

                double mensual = valor + ciento;
                txtpago.Text = mensual.ToString();

                double cuota = mensual * 5 + inicial;
                txtcuota.Text = cuota.ToString();

                if (inicial > 4000)
                {
                    DisplayAlert("Error", "Monto Excedido...", "cerrar");
                }
                if (inicial <= 0)
                {
                    DisplayAlert("Error", "Monto No Existe...", "cerrar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "cerrar");
            }

        }

        private void btnguardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string tpagar = txtcuota.Text;
            string usuario = lblusuario.Text;
            DisplayAlert("Gracias", "Datos Guardados con Exito", "cerrar");
            Navigation.PushAsync(new resumen(usuario,nombre, tpagar));
        }
    }
}