using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingXamarin.ViewModels;

namespace TrainingXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _homeViewModel;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = _homeViewModel = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            _homeViewModel.RefreshPopularArtist();
            _homeViewModel.RefreshTodayHits();
            _homeViewModel.RefreshArtistsList();
        }
    }
}