using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelaGSP2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mapa2 : ContentPage
	{
		public Mapa2 ()
		{
			InitializeComponent ();

            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;
        }
	}
}