using EmoAnimations.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmoAnimations
{
    public partial class MainPage : ContentPage
    {
        List<View> childList;

        public MainPage()
        {
            InitializeComponent();

            childList = new List<View>();

        }


        async void EmoHeartBeat_Clicked(object sender, EventArgs e)
        {
            var element = new EmoHeartBeat();
            CreatNew(element);
        }

        async void EmoStampText_Clicked(object sender, EventArgs e)
        {
            var element = new EmoStampText();
            CreatNew(element);

        }

        async void EmoColorFade_Clicked(object sender, EventArgs e)
        {
            var element = new EmoColorFade();
            CreatNew(element);

        }

        /*        async void Cancel_Clicked(object sender, EventArgs e)
                {
                    ViewExtensions.CancelAnimations(AnimationArea);
                    foreach (var item in childList)
                    {
                        ViewExtensions.CancelAnimations(item);
                    }
                }
                */


        void CreatNew(View element)
        {
            RemoveAll();
            element.VerticalOptions = LayoutOptions.Center;
            AnimationArea.Children.Add(element);
            childList.Add(element);
        }

        void RemoveAll()
        {
            foreach (var item in childList)
            {
                AnimationArea.Children.Remove(item);
            }

            childList = new List<View>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
