using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace fishy.Services
{
    public class LocationService
    {
        public static async Task<double> GetLatitude()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    return location.Latitude;
                }
                else
                    return 0;
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                Console.WriteLine("Feature not supported error: " + fnsEx);
                return 0;
            }
            catch (PermissionException pEx)
            {
                Console.WriteLine("Permission error: " + pEx);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
                return 0;
            }
        }

        public static async Task<double> GetLongitude()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    return location.Longitude;
                }
                else
                    return 0;
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                Console.WriteLine("Feature not supported error: " + fnsEx);
                return 0;
            }
            catch (PermissionException pEx)
            {
                Console.WriteLine("Permission error: " + pEx);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
                return 0;
            }
        }
    }
}
