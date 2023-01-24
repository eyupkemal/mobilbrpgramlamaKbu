using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Gokhan_Yeletaysi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sonuc : ContentPage
    {
        public sonuc()
        {

            InitializeComponent();
            int dogru;
            int yanlis;

            dogru = Globals.LabelGlobal3 + Globals.LabelGlobal5;
            yanlis = 2 - (Globals.LabelGlobal3 + Globals.LabelGlobal5);
            sayiLabel.Text = $"1.Sorunun Cevabı: {Globals.LabelGlobal1}";
            takimLabel.Text = $"2.Sorunun Cevabı: {Globals.LabelGlobal2}";

           doruLabel.Text = $"Toplam Doğru Cevaplarınız {dogru}/2";
            yanlisLabel.Text = $"Toplam Yanlış Cevaplarınız {yanlis}/2";
        }

    }
}