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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimalDetailsPage((sender as Button).Text));
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GOL());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GRY());
        }


        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GTF());
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HF());
        }

        private void Button_Clicked_17(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MF());
        }

        private void Button_Clicked_18(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MIE());
        }

        private void Button_Clicked_21(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PDF());
        }

        private void Button_Clicked_22(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PF());
        }

        private void Button_Clicked_23(object sender, EventArgs e)
        {
            Navigation.PushAsync(new S());
        }

        private void Button_Clicked_24(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ST());
        }

        private void Button_Clicked_25(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TS());
        }

        private void Button_Clicked_26(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PF());
        }

        private void Button_Clicked_27(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WF());
        }

        private void Button_Clicked_28(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WT());
        }
    }
}