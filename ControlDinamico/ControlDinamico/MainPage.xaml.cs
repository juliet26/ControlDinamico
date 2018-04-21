using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlDinamico
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
            Prueba.Clicked += Prueba_Clicked;
		}

        private void Prueba_Clicked(object sender, EventArgs e)
        {
            Panel.Children.Add(new Button()
            {
                Text = $"Boton{Panel.Children.Count+1}"
            });
        }
    }
}
