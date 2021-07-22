using System.ComponentModel;
using Xamarin.Forms;
using Xamfin.ViewModels;

namespace Xamfin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
