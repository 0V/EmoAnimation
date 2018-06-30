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
    public partial class EmoColorFade : ContentView
    {
        public EmoColorFade()
        {
            InitializeComponent();
        }
        async void Do_Clicked(object sender, EventArgs e)
        {
            // https://www.materialui.co/colors
            var colors = new List<Color>()
            {
                Color.FromHex("f44336"),
                Color.FromHex("E91E63"),
                Color.FromHex("9C27B0"),
                Color.FromHex("673AB7"),
                Color.FromHex("3F51B5"),
                Color.FromHex("2196F3"),
                Color.FromHex("03A9F4"),
                Color.FromHex("00BCD4"),
                Color.FromHex("009688"),
                Color.FromHex("4CAF50"),
                Color.FromHex("8BC34A"),
                Color.FromHex("CDDC39"),
                Color.FromHex("FFEB3B"),
                Color.FromHex("FFC107"),
                Color.FromHex("FF9800"),
                Color.FromHex("FF5722"),
            };
            
            for (int i = 0; i < colors.Count; i++)
            {
                await ColorBox.ColorTo(colors[i],colors[(i+1) % colors.Count], c => ColorBox.BackgroundColor = c, 50);
            }
        }
    }
}