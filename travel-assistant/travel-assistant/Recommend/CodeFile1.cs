//<Map:MapControl Name = "map"
//                MapServiceToken="cXGdl8cifNITj1Mr19x6~duXenVSSPmR3wdc9dTzJ3w~AnzNY0HVZBSQ46JyDGq1WOHty5XUceOul4NeTDS_SQ5IhhdujACEG9Ay27Odu5pV" />

//private async void click_Click(object sender, RoutedEventArgs e)
//{
//    // Set your current location.
//    var accessStatus = await Geolocator.RequestAccessAsync();
//    switch (accessStatus)
//    {
//        case GeolocationAccessStatus.Allowed:

//            // Get the current location.
//            Geolocator geolocator = new Geolocator();
//            Geoposition pos = await geolocator.GetGeopositionAsync();
//            Geopoint myLocation = pos.Coordinate.Point;

//            // Set the map location.
//            map.Center = myLocation;
//            map.ZoomLevel = 12;
//            map.LandmarksVisible = true;
//            break;

//        case GeolocationAccessStatus.Denied:
//            // Handle the case  if access to location is denied.
//            break;

//        case GeolocationAccessStatus.Unspecified:
//            // Handle the case if  an unspecified error occurs.
//            break;
//    }
//}