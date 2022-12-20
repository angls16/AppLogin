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

        

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double CostoCurso = 3000;
            double ValorInicial =  double.Parse(entInicial.Text);
            string Nombre = entNombre.Text;
            double resta = CostoCurso - ValorInicial;
            double PagoMensual = (resta) / 5;
            double Porcentaje = PagoMensual * 0.05;
            double PorcentajeSuma = PagoMensual + Porcentaje;
            double TotalPago = (PorcentajeSuma * 5) + ValorInicial;

            txtPago.Text = Convert.ToString(PorcentajeSuma);

        }
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            double CostoCurso = 3000;
            double ValorInicial = double.Parse(entInicial.Text);
            string Nombre = entNombre.Text;
            double resta = CostoCurso - ValorInicial;
            double PagoMensual = (resta) / 5;
            double Porcentaje = PagoMensual * 0.05;
            double PorcentajeSuma = PagoMensual + Porcentaje;
            double TotalPago = (PorcentajeSuma * 5) + ValorInicial;
            await Navigation.PushAsync(new Resumen(lblUsuario.Text, Nombre,Convert.ToString(TotalPago)));
        }
    }
}