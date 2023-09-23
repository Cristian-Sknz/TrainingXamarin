using Xamarin.Forms;

namespace TrainingXamarin.Controls
{
    public class Topbar: StackLayout
    {
        public Topbar()
        {
            Margin = new Thickness(20, 0);
            Padding = new Thickness(0, 10);
            BackgroundColor = Color.Black;
            Orientation = StackOrientation.Horizontal;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            Children.Add(CreateIconButton("icon_search.xml"));
            Children.Add(CreateAppLogo());
            Children.Add(CreateIconButton("icon_setting.xml"));
        }
        
        private ImageButton CreateIconButton(ImageSource source) => new ImageButton
        {
            BackgroundColor = Color.Transparent,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Center,
            Source = source,
            HeightRequest = 40
        };
        
        private Image CreateAppLogo() => new Image
        {
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Center,
            Source = "icon_spotify_logo.xml",
            HeightRequest = 40
        };
    }
}