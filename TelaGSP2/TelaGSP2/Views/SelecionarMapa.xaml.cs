using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelaGSP2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelecionarMapa : ContentPage
	{
		public SelecionarMapa ()
		{
			InitializeComponent ();

		}
        public void onFormsMaps(object sender, EventArgs args)
        {
            App.Current.MainPage = new Mapa();
        }

        public void onFormsGoogleMaps(object sender, EventArgs args)
        {
            App.Current.MainPage = new Mapa2();
        }
    }
}