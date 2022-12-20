using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = entUsuario.Text;
            string contraseña = entContraseña.Text;
            string Usuario = "angel2022";
            string Contraseña = "itq2022";
            if (usuario == Usuario && contraseña == Contraseña)
            {
                await Navigation.PushAsync(new Registro(usuario, contraseña));
            }
            else
            {
                DisplayAlert("ERROR", "Usuario o Contraseña incorrecta","gracias mo");
            }
        }
    }
}