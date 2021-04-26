using System.ComponentModel;
using Xamarin.Forms;
using XFPrinter.ViewModels;

namespace XFPrinter.Views
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