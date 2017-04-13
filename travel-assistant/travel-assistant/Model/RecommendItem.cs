using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class RecommendItem
    {
        public string Name { get; set; }
        public MainCategory MC { get; set; }
        public SubCategory SC { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public string Ranking { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; } 
    }

    public enum MainCategory
    {
        Delicacy,
        Hostel,
        Entertainment,
        Attraction,
        Shopping
    }
    public enum SubCategory
    {

    }

    class RecommendItemManager
    {
        public static List<RecommendItem> GetItems()
        {
            var AllItem = new List<RecommendItem>();

            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/1.jpg", Name = "hahaha", MC = MainCategory.Delicacy }); 
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/2.jpg", Name = "xixixi" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/3.jpg", Name = "wawawa" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/4.jpg", Name = "wawawa" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/5.jpg", Name = "wawawa" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/6.jpg", Name = "wawawa" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/7.jpg", Name = "wawawa" });
            AllItem.Add(new RecommendItem { Image = "/Assets/Recommend/Hot/8.png", Name = "wawawa" });

            return AllItem;
        }
    }
}
