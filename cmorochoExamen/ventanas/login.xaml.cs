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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btningresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string password = "uisrael2023";

            if (usuario == txtusuario.Text && password == txtpassword.Text)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario y/0 Contraseña Incorrectos", "cerrar");
            }
        }
    }
}