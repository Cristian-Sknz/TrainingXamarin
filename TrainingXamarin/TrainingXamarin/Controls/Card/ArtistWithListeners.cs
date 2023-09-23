using Xamarin.Forms;

namespace TrainingXamarin.Controls.Card
{
    public class ArtistWithListeners: StackLayout
    {

        public static readonly BindableProperty SourceProperty = 
            BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(ArtistWithListeners));
        public static readonly BindableProperty ArtistProperty =
            BindableProperty.Create(nameof(Artist), typeof(string), typeof(ArtistWithListeners));
        public static readonly BindableProperty ListenersProperty =
            BindableProperty.Create(nameof(Listeners), typeof(string), typeof(ArtistWithListeners));
        
        public ImageSource Source
        {
            get => (ImageSource) GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }
        public string Artist
        {
            get => (string) GetValue(ArtistProperty);
            set => SetValue(ArtistProperty, value);
        }
        public string Listeners
        {
            get => (string) GetValue(ListenersProperty);
            set => SetValue(ListenersProperty, $"{value} monthly listeners");
        }
            
        public ArtistWithListeners()
        {
            Orientation = StackOrientation.Horizontal;
            Frame frame = CreateBindableFrame(80);
            StackLayout label = CreateBindableLabelGroup();
            
            Children.Add(frame);
            Children.Add(label);
        }


        private Frame CreateBindableFrame(int size)
        {
            return new Frame
            {
                WidthRequest = size,
                Padding = 0,
                CornerRadius = 100,
                Content = CreateBindableImage(size)
            };
        }

        private Image CreateBindableImage(int size)
        {
            var image = new Image { HeightRequest = size, Aspect = Aspect.AspectFit };
            image.SetBinding(Image.SourceProperty, new Binding(nameof(Source), source: this));
            return image;
        }

        private StackLayout CreateBindableLabelGroup()
        {
            var artist = new Label { TextColor = Color.White, FontSize = 20, FontAttributes = FontAttributes.Bold };
            var listeners = new Label { TextColor = Color.White, FontSize = 16, FormattedText = CreateBindableListenersSpan() };
            artist.SetBinding(Label.TextProperty, new Binding(nameof(Artist), source: this ));
            
            return new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(3, 0, 0, 0),
                Spacing = -5,
                Children = { artist, listeners }
            };
        }

        private FormattedString CreateBindableListenersSpan()
        {
            var numbers = new Span();
            var text = new Span { Text = " monthly listeners"};
            
            numbers.SetBinding(Span.TextProperty, new Binding(nameof(Listeners), source: this ));
            
            return new FormattedString { Spans = { numbers, text } };
        }
    }
}