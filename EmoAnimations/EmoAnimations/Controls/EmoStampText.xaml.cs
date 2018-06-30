using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmoAnimations.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmoStampText : ContentView
	{
		public EmoStampText ()
		{
			InitializeComponent ();
        }

        async void Do_Clicked(object sender, EventArgs e)
        {
            OverlayText.IsVisible = true;
            OverlayText.Scale = 2;
            OverlayText.FadeTo(1, 200);
            ContentText.Opacity = 0.6;
            StampedCard.BackgroundColor = Color.FromHex("F32196");
            OverlayText.ScaleTo(1, 300, Easing.BounceOut);
        }

        async void Reload_Clicked(object sender, EventArgs e)
        {
            OverlayText.Opacity = 0;
            OverlayText.IsVisible = false;
            ContentText.Opacity = 0;
            await StampedCard.ScaleTo(0, 150, Easing.CubicInOut);
            // TodayCard.BackgroundColor = Color.White;
            StampedCard.BackgroundColor = Color.FromHex("7C4DFF");
            await ContentText.FadeTo(1, 0);
            await StampedCard.ScaleTo(1, 150, Easing.CubicInOut);
        }
    }
}