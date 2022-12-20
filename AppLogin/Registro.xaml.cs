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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new Resumen(lblUsuario.Text));
        }
    }
}