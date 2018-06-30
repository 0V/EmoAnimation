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
	public partial class EmoHeartBeat : ContentView
    {
		public EmoHeartBeat ()
		{
			InitializeComponent ();
		}


        async void Do_Clicked(object sender, EventArgs e)
        {
            ColorBox.Opacity = 1;
            ColorBox.ScaleTo(1.2, 400);
            await ColorBox.FadeTo(0, 400);
            ColorBox.Opacity = 0;
            ColorBox.Scale = 1;
        }
    }
}