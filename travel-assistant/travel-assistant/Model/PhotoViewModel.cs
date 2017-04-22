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

            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/8.jpeg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/9.jpeg", Description = "222" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/9.jpeg", Description = "333" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/9.jpeg", Description = "444" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/9.jpeg", Description = "555" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/9.jpeg", Description = "666" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/8.jpeg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/8.jpeg", Description = "111" });
            Photos.Add(new Photo { ImageUri2 = "/Assets/Friends/8.jpeg", Description = "111" });

            return Photos;
        }
    }
}
