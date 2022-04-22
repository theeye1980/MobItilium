using MobItilium.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobItilium.Views
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