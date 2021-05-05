using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aqumulate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            InitializeComponent();
        }

        private void openAppShell(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}