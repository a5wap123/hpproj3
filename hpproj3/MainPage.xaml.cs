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

namespace hpproj3
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
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
    }
}