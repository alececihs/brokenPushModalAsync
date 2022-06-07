using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnPushModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2());
        }

        private void btnHideAnimals_Clicked(object sender, EventArgs e)
        {
            AppShell appShell = Shell.Current as AppShell;
            appShell.SetAnimalsVisibility(false);
        }

        private void btnShowAnimals_Clicked(object sender, EventArgs e)
        {
            AppShell appShell = Shell.Current as AppShell;
            appShell.SetAnimalsVisibility(true);
        }
    }
}