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
    public partial class DashboardView : ContentPage
    {
        public DashboardView()
        {
            DevExpress.XamarinForms.Charts.Initializer.Init();
            DevExpress.XamarinForms.CollectionView.Initializer.Init();
            InitializeComponent();
        }
    }
}