using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class Photo
    {
        public string ImageUri2 { get; set; }
        public string Description { get; set; }
    }
    //List ObservableCollection

    public class PhotoViewModel
    {
        public static ObservableCollection<Photo> GetPhotos()
        {
            var Photos = new ObservableCollection<Photo>();

            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M1.jpg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M2.jpg", Description = "222" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M3.jpg", Description = "333" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M4.jpg", Description = "444" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M5.jpg", Description = "555" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M6.jpg", Description = "666" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M7.jpg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M8.jpg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Moments/M9.jpg", Description = "111" });

            return Photos;
        }
    }
}
