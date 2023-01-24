using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Gokhan_Yeletaysi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicRadioButtonsPage : ContentPage
    {
       
        public ICommand NavigateCommand { get; private set; }
        public BasicRadioButtonsPage()
        {
            InitializeComponent();
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
        void SayiCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;


            if (Convert.ToString(button.Content) == "75")
            {
                sayiLabel.Text = $"Doğru";
                Globals.LabelGlobal1 = $"Doğru";
                Globals.LabelGlobal3 = 1;
              

            }
            else
            {
                sayiLabel.Text = $"Yanlış";
                Globals.LabelGlobal1 = $"Yanlış";
               
                Globals.LabelGlobal3 = 0;
               

            }
            

        }

        void TakimCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;

            if (Convert.ToString(button.Content) == "Galatasaray")
            {
                takimLabel.Text = $"Doğru:";
                Globals.LabelGlobal2 = $"Doğru";
                Globals.LabelGlobal5 = 1;
                Globals.LabelGlobal6 = 0;
            }
            else
            {
                takimLabel.Text = $"Yanlış:";
                Globals.LabelGlobal2 = $"Yanlış";
                Globals.LabelGlobal5 = 0;
                Globals.LabelGlobal6 = 1;
            }
        }
    
    }
}





