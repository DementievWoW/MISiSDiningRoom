using MISiSDiningRoom.Interfacese;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MISiSDiningRoom.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderPage : ContentPage
	{

		public OrderPage ()
		{
			InitializeComponent();
	

        }

        private void CarouselViewPositionChanged(object sender, PositionChangedEventArgs e)
        {
			var carousel=sender as CarouselView;
			var views = carousel.VisibleViews;
			if (views.Count > 0)
			{
				foreach (var view in views)
				{
					var img = view.FindByName<Image>("MenuImg");
					ViewExtensions.CancelAnimations(img);
					Task.Run(async () => await img.RelRotateTo(360, 5000, Easing.BounceOut));
				}
			}
        }

        private void PlayAudio(object sender, EventArgs e)
        {
            string sound = ((Button)sender).BindingContext as string;
            DependencyService.Get<IAudio>().PlayAudioFile(sound);
        }
    }
}