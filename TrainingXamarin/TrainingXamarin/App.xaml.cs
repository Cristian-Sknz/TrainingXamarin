
using TrainingXamarin.Services;
using Xamarin.Forms;

namespace TrainingXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockHomeService>();
            MainPage = new AppShell();
        }
    }
}
