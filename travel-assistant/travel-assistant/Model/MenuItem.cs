using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public MenuCategory Category { get; set; }
    }

    public enum MenuCategory
    {
        Recommend,
        Friends,
        Moments,
        Me,
        Settings
    }

    class MenuItemManager
    {
        public static List<MenuItem> GetMenuItems()
        {
            var AllMenuItem = new List<MenuItem>();

            AllMenuItem.Add(new MenuItem { Name = "recommend_item", Icon = "\uE734", Category = MenuCategory.Recommend }); 
            AllMenuItem.Add(new MenuItem { Name = "friends_item", Icon = "\uE716", Category = MenuCategory.Friends });
            AllMenuItem.Add(new MenuItem { Name = "moments_item", Icon = "\uE722", Category = MenuCategory.Moments });
            AllMenuItem.Add(new MenuItem { Name = "me_item", Icon = "\uE13D", Category = MenuCategory.Me });
            AllMenuItem.Add(new MenuItem { Name = "settings_item", Icon = "\uE713", Category = MenuCategory.Settings });

            return AllMenuItem;
        }
    }
}
