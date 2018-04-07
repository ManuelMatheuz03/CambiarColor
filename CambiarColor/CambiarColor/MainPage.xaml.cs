using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CambiarColor
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void sldValue_Changed(object sender, EventArgs e)
        {
            var Rojo = sldRojo.Value;
            var Verde = sldVerde.Value;
            var Azul = sldAzul.Value;
            var Opacidad = sldOpacidad.Value;

            Color bgColor = new Color(Rojo, Verde, Azul, Opacidad);
            boxColor.BackgroundColor = bgColor;
            lbDisplay.Text = ColorHexa(bgColor);

        }

        private string ColorHexa(Color bgColor)
        {
            int rojo = (int)(bgColor.R * 255);
            int verde = (int)(bgColor.G * 255);
            int azul = (int)(bgColor.B * 255);
            int opacidad = (int)(bgColor.A * 255);

            return $"#{rojo:X2}{verde:X2}{azul:X2}{opacidad:X2}";
        }
    }
}
