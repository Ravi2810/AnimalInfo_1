using System;
using System.IO;
using System.Reflection;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnimalInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetailsPage : ContentPage
    {
        public AnimalViewModel animalViewModel;
        public AnimalDetailsPage(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("AnimalInfo.AnimalData.data.json");
            using (var reader = new StreamReader(stream))
            {
                var text = reader.ReadToEnd();
                animalViewModel = JsonConvert.DeserializeObject<List<AnimalViewModel>>(text)
                        .Where(x => x.Name == name)
                        .FirstOrDefault();
            }
            InitializeComponent();
            BindingContext = animalViewModel;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
