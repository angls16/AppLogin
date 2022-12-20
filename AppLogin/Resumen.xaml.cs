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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string ValorTotal )
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblEstudiante.Text = nombre;
            lblPagar.Text = ValorTotal; 
        }
    }
}