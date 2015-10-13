using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using hpproj3.Resources;
using Windows.Devices.Geolocation;

namespace hpproj3
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public System.Device.Location.GeoCoordinate MyAdrress = new System.Device.Location.GeoCoordinate();
        public MainPage()
        {
            InitializeComponent();
            
           
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await FillAdress();
            this.gMap.SetView(MyAdrress, ZoomLevel);
        }
        private async System.Threading.Tasks.Task FillAdress()
        {
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                     maximumAge: TimeSpan.FromMinutes(5),
                     timeout: TimeSpan.FromSeconds(10)
                    );

                //With this 2 lines of code, the app is able to write on a Text Label the Latitude and the Longitude, given by {{Icode|geoposition}}
                MyAdrress.Latitude = geoposition.Coordinate.Latitude;
                MyAdrress.Longitude = geoposition.Coordinate.Longitude;
            }
            //If an error is catch 2 are the main causes: the first is that you forgot to include ID_CAP_LOCATION in your app manifest. 
            //The second is that the user doesn't turned on the Location Services
            catch (Exception ex)
            {
                //exception
            }

        }
        
        public double ZoomLevel
        {
            get { return (double)GetValue(ZoomLevelProperty); }
            set { SetValue(ZoomLevelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ZoomLevel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ZoomLevelProperty =
            DependencyProperty.Register("ZoomLevel", typeof(double), typeof(MainPage), new PropertyMetadata(16.0));
        private void gMap_LoadingError(object sender, Microsoft.Phone.Controls.Maps.LoadingErrorEventArgs e)
        {

        }

        private void gMap_MapResolved(object sender, EventArgs e)
        {

        }

        private void gMap_MapPan(object sender, Microsoft.Phone.Controls.Maps.MapDragEventArgs e)
        {

        }

        private void gMap_MapZoom(object sender, Microsoft.Phone.Controls.Maps.MapZoomEventArgs e)
        {

        }

        private void Map_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void gMap_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
    }
}