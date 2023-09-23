using Xamarin.Forms;

namespace TrainingXamarin.Controls.Card
{
    public class ArtistTodayHit: StackLayout
    {

        public static readonly BindableProperty ArtistProperty = BindableProperty.Create(nameof(Artist), typeof(string),
            typeof(ArtistTodayHit));
        public static readonly BindableProperty AlbumProperty = BindableProperty.Create(nameof(Album), typeof(string),
            typeof(ArtistTodayHit));
        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(ImageSource),
            typeof(ArtistTodayHit));
        public static readonly BindableProperty ImageSizeProperty = BindableProperty.Create(nameof(ImageSize), typeof(int), 
            typeof(ArtistTodayHit), 136);
        
        public string Artist
        {
            get => (string)GetValue(ArtistProperty);
            set => SetValue(ArtistProperty, value);
        }
        public string Album 
        {
            get => (string)GetValue(AlbumProperty);
            set => SetValue(AlbumProperty, value);
        }
        public int ImageSize
        {
            get => (int)GetValue(ImageSizeProperty);
            set => SetValue(AlbumProperty, value);
        }
        public ImageSource Source
        {
            get => (ImageSource) GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }
        
        public ArtistTodayHit()
        {
            Frame frame = CreateBindableFrame();
            StackLayout group = CreateBindableLabelGroup();
            
            HorizontalOptions = LayoutOptions.Start;
            SetBinding(WidthRequestProperty, new Binding(nameof(ImageSize), source: this));
            
            Children.Add(frame);
            Children.Add(group);
        }

        private Frame CreateBindableFrame()
        {
            var frame = new Frame {
                Padding = 0,
                CornerRadius = 8,
                Content = CreateBindableImage()
            };
            frame.SetBinding(Frame.HeightRequestProperty, new Binding(nameof(ImageSize), source: this));
            return frame;
        }

        private Image CreateBindableImage()
        {
            var image = new Image
            {
                Aspect = Aspect.AspectFill,
                BackgroundColor = Color.FromHex("#aaa")
            };
            image.SetBinding(Image.SourceProperty, new Binding(nameof(Source), source: this));
            return image;
        }
        
        private StackLayout CreateBindableLabelGroup()
        {
            Label album = CreateLabel();
            Label artist = CreateLabel();

            album.FontSize = 15;
            album.FontAttributes = FontAttributes.Bold;
            
            artist.SetBinding(Label.TextProperty, new Binding(nameof(Artist), source: this));
            album.SetBinding(Label.TextProperty, new Binding(nameof(Album), source: this));

            return new StackLayout
            {
                Orientation = StackOrientation.Vertical, 
                Spacing = -5,
                Children = { album, artist }
            };
        }

        private Label CreateLabel() => new Label { LineBreakMode = LineBreakMode.TailTruncation, MaxLines = 1, TextColor = Color.White, FontSize = 13 };
    }
}