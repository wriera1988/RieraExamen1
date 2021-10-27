using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RieraExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
        }

        public Resumen(string Usuario, string Clave)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            lblClave.Text = Clave;
            txtUsuario.Text = Usuario;
            txtClave.Text = Clave;
                
        }
    }
}