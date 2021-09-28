using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Memo.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://github.com/IvanXablin/Memo");
        }
    }
}