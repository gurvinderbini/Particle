using System;
using Xamarin.Forms;

namespace Particle
{
	[Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
	public partial class ParticlePage : ContentPage
	{
		public ParticlePage()
		{
			InitializeComponent();

		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new Page2());
	    }
	}
}
