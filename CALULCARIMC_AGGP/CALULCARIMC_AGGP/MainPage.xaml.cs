using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CALULCARIMC_AGGP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //float peso;
        //float altura;
        float imc;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text)) { 
                CalcularImc(float.Parse(Peso.Text), float.Parse(Altura.Text));
                IMC.Text = imc.ToString();
                string rango = "";
                if(imc <18 )
                {
                    rango = "Tienes desnutricion";
                }
                else if(imc <= 24.9)
                {
                    rango = "Tienes un buen peso";
                }

                else if(imc >24.9 && imc < 30.0)
                {
                    rango = "estas pasado de pse";
                }
                else
                {
                    rango = "Tienes obecidad";
                }
                DisplayAlert("Rango de peso", rango, "Salir");
            }
            else
            {
                DisplayAlert("Campos Vacíos", "Ingresa todos los datos", "Salir");
            }
        }
        private void CalcularImc(float p, float a)
        {
                float imc = p / (a * a);

        }
    }
}
