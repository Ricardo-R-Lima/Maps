using Microsoft.Maui.Maps;

namespace PamMaps
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var location = new Location(-23.51972583281358, -46.596305026525684);
            var mapsSpan = new MapSpan(location, 0.01, 0.01);
               map.MoveToRegion(mapsSpan);
        }

      
    }

}
