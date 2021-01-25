using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BugPage : ContentPage
    {
        public BugPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await Task.Delay(1000);
            image.HeightRequest = 300;
            base.OnAppearing();
        }
    }
}
