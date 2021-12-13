using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I3());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I4());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I5());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I6());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I7());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new I8());
        }
    }
}