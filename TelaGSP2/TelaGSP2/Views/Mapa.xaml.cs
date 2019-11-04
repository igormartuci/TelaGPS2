using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelaGSP2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mapa : ContentPage
	{
		public Mapa ()
		{
			InitializeComponent ();

            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-23.4945044, -46.5909981), Distance.FromKilometers(1)));
            MapContainer.Children.Add(mapa);

		}
	}
}