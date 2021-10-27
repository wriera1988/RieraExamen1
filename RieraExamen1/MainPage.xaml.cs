using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RieraExamen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try  {
                //datos que se envian a la otra ventana 
                string Usuario = txtuasuario.Text;
                string Clave = txtClave.Text;
                await Navigation.PushAsync(new Registro());
            }
            catch(Exception ex)   {
                await DisplayAlert("Mensaje de advertencia", ex.Message,"OK");
            }
}
    }
}
