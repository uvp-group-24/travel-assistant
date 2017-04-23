using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace travel_assistant.Model
{
    public class RecommendItem
    {
        public string Name { get; set; } //名称
        public MainCategory MC { get; set; } //主类
        public SubCategory SC { get; set; } //次类
        public string PhoneNumber { get; set; } //电话
        public string Address { get; set; } //地址    
        //public string Location { get; set; } //定位
        public int Price { get; set; } //人均价格
        public bool IsRecommended { get; set; } //是否推荐
        public float Ranking { get; set; } //评分
        public Comment Comments{ get; set; } //评价
        public ImagePath Images { get; set; } //照片
        public Coupon Cp { get; set; } //优惠券
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
        D_Barbecue,
        D_Bread_Desserts,
        D_Buffet,
        D_Hot_pot,
        D_Seafood,
        D_Snacks_Fastfood,

        H_Chain_hotel,
        H_Youth_hostel,
        H_Serviced_apartment,
        H_Luxury_hotel,
        H_Homestay,

        E_KTV,
        E_Bar,
        E_Cinema,
        E_Cybercafe,
        E_Gym,
        E_Board_game,

        A_Park,
        A_Natural_scenery,
        A_Place_of_interest,
        A_Zoo_Aquarium,
        A_Temple,
        A_Museum,

        S_Supermarket_Store,
        S_Shopping_mall,
        S_Pharmacy,
        S_Bookstore,
        S_Clothing_store,
        S_Jewellers
    }
    public class Comment
    {
        public string comment_1 { get; set; }
        public string comment_2 { get; set; }
        public string comment_3 { get; set; }
    }
    public class ImagePath
    {
        public string image_1 { get; set; }
        public string image_2 { get; set; }
        public string image_3 { get; set; }
    }
    public class Coupon
    {
        public string Name { get; set; }
        public float OriginalPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public int SoldSum { get; set; }
    }
    class RecommendItemManager
    {
        public static void GetAllItems(ObservableCollection<RecommendItem> items)
        {
            var allItems = GetItems();
            items.Clear();
            allItems.ForEach(p => items.Add(p));
        }
        public static void GetItemsByName(ObservableCollection<RecommendItem> items, string name)
        {
            var allItems = GetItems();
            var filteredItems = allItems.FindAll(p => p.Name == name);
            items.Clear();
            filteredItems.ForEach(p => items.Add(p));
        }
        public static List<RecommendItem> GetItems()
        {
            var AllItem = new List<RecommendItem>();

            AllItem.Add(new RecommendItem
            {
                Name = "木屋烤羊腿二部(白塔堡店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Barbecue,
                PhoneNumber = "024-83752388",
                Address = "白塔堡106号18门(白塔茗居斜对面)",
                Price = 47,
                IsRecommended = true,
                Ranking = 8.3f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/muwukaotui/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/muwukaotui/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/muwukaotui/3.jpg"
                },
                Cp = new Coupon { Name = "烤羊腿超值套餐188元", OriginalPrice = 266.00f, DiscountedPrice = 188.00f, SoldSum = 10 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "全民嗨烤音乐串吧",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Barbecue,
                PhoneNumber = "024-81200210",
                Address = "红椿东路2甲107号1门郡原小石城(鼎汇丰旁)",
                Price = 59,
                IsRecommended = false,
                Ranking = 7.6f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/quanminhaikao/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/quanminhaikao/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/quanminhaikao/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "斗牛家烧烤(白塔店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Barbecue,
                PhoneNumber = "13889357720",
                Address = "白塔堡白塔街108号(白塔茗居西门对面)",
                Price = 64,
                IsRecommended = false,
                Ranking = 7.7f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/douniujia/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/douniujia/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/douniujia/3.jpg"
                },
                Cp = new Coupon { Name = "超值双人餐", OriginalPrice = 119.00f, DiscountedPrice = 69.00f, SoldSum = 101 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "波波'S蛋糕店(白塔店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Bread_Desserts,
                PhoneNumber = "024-66676060",
                Address = "白塔堡白塔街108号(白塔茗居西门对面)",
                Price = 26,
                IsRecommended = true,
                Ranking = 7.3f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/bobos/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/bobos/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/bobos/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "达洋猫面包屋",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Bread_Desserts,
                PhoneNumber = "13998896618",
                Address = "沈营大街上亿广场内",
                Price = 29,
                IsRecommended = false,
                Ranking = 7.7f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/dayangmao/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/dayangmao/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/dayangmao/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "米罗蒂奇蛋糕坊",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Bread_Desserts,
                PhoneNumber = "18524407479",
                Address = "创新路东北大学浑南校区食堂二楼",
                Price = 23,
                IsRecommended = false,
                Ranking = 7.2f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/miluodiqi/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/miluodiqi/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/miluodiqi/3.jpg"
                },
                Cp = new Coupon { Name = "华夫饼拿铁套餐1份", OriginalPrice = 27.00f, DiscountedPrice = 19.90f, SoldSum = 0 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "韩盛·盛江山自助料理",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Buffet,
                PhoneNumber = "024-31215159",
                Address = "营盘西街奥体万达广场3楼ONE街区",
                Price = 68,
                IsRecommended = true,
                Ranking = 9.1f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/hansheng/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/hansheng/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/hansheng/3.jpg"
                },
                Cp = new Coupon { Name = "午餐自助餐一位", OriginalPrice = 118.00f, DiscountedPrice = 68.90f, SoldSum = 2020 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "韩品味自助烤肉火锅(白塔店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Buffet,
                PhoneNumber = "13940441762",
                Address = "白塔堡全运路420号-1(白塔堡龙盛广场西侧100米)",
                Price = 40,
                IsRecommended = false,
                Ranking = 7.3f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/hanpinwei/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/hanpinwei/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/hanpinwei/3.jpg"
                },
                Cp = new Coupon { Name = "午晚通用自助烤肉火锅", OriginalPrice = 59.00f, DiscountedPrice = 42.90f, SoldSum = 466 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "28元自助火锅烤肉",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Buffet,
                PhoneNumber = "18204050058",
                Address = "沈营大街白塔堡188站点",
                Price = 26,
                IsRecommended = false,
                Ranking = 7.2f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/28yuan/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/28yuan/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/28yuan/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "鼎汇丰重庆老火锅(小石城店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Hot_pot,
                PhoneNumber = "024-83659178",
                Address = "红椿东路2甲-107号5门(沈营路和全运路交汇处)",
                Price = 109,
                IsRecommended = true,
                Ranking = 8.4f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/dinghuifeng/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/dinghuifeng/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/dinghuifeng/3.jpg"
                },
                Cp = new Coupon { Name = "晚市代金券1张", OriginalPrice = 100.00f, DiscountedPrice = 90.00f, SoldSum = 1161 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "吾爱铜火锅(白塔店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Hot_pot,
                PhoneNumber = "15702455866",
                Address = "白塔街333路白塔堡车站(龙盛家园门市)",
                Price = 54,
                IsRecommended = false,
                Ranking = 7.6f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/wuaitong/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/wuaitong/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/wuaitong/3.jpg"
                },
                Cp = new Coupon { Name = "4人餐", OriginalPrice = 246.00f, DiscountedPrice = 168.00f, SoldSum = 3 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "辛明堂洞年糕火锅(上亿广场店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Hot_pot,
                PhoneNumber = "18640498375",
                Address = "沈营大街587号60门白塔堡上亿广场南门外门市",
                Price = 43,
                IsRecommended = false,
                Ranking = 7.6f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/xinmingtangdong/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/xinmingtangdong/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/xinmingtangdong/3.jpg"
                },
                Cp = new Coupon { Name = "新派水煎牛锅套餐", OriginalPrice = 160.00f, DiscountedPrice = 99.00f, SoldSum = 23 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "多嘴肉蟹煲(奥体万达店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Seafood,
                PhoneNumber = "024-23608787",
                Address = "奥体万达广场3楼(沈阳奥体店)",
                Price = 70,
                IsRecommended = true,
                Ranking = 8.9f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/duozui/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/duozui/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/duozui/3.jpg"
                },
                Cp = new Coupon { Name = "代金券1张", OriginalPrice = 100.00f, DiscountedPrice = 92.00f, SoldSum = 24350 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "五丫五小私厨海鲜串吧",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Seafood,
                PhoneNumber = "024-82398699",
                Address = "长白南路246甲",
                Price = 54,
                IsRecommended = false,
                Ranking = 8.2f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/wuyawu/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/wuyawu/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/wuyawu/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "嗨鲜逸族",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Seafood,
                PhoneNumber = "024-66778845",
                Address = "爱家丽都北门(御药堂西侧50米)",
                Price = 70,
                IsRecommended = false,
                Ranking = 8.5f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/haixianyizu/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/haixianyizu/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/haixianyizu/3.jpg"
                },
                Cp = new Coupon { Name = "精美双人餐", OriginalPrice = 184.00f, DiscountedPrice = 138.00f, SoldSum = 19 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "三顾冒菜",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Snacks_Fastfood,
                PhoneNumber = "13066705538",
                Address = "白塔街106号1门",
                Price = 28,
                IsRecommended = true,
                Ranking = 8.1f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/sangumaocai/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/sangumaocai/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/sangumaocai/3.jpg"
                },
                Cp = new Coupon { Name = "代金券1张", OriginalPrice = 48.00f, DiscountedPrice = 42.90f, SoldSum = 110 }
            });
            AllItem.Add(new RecommendItem
            {
                Name = "吉祥馄饨(白塔店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Snacks_Fastfood,
                PhoneNumber = "024-31892368",
                Address = "白塔铺塔东路3号5门(白塔名居正门斜对面)",
                Price = 13,
                IsRecommended = false,
                Ranking = 7.3f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/jixianghuntun/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/jixianghuntun/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/jixianghuntun/3.jpg"
                },
                Cp = null
            });
            AllItem.Add(new RecommendItem
            {
                Name = "肯德基(白塔堡店)",
                MC = MainCategory.Delicacy,
                SC = SubCategory.D_Snacks_Fastfood,
                PhoneNumber = "024-31920995",
                Address = "白塔堡沈营大街587号上亿广场一层(白塔堡)",
                Price = 25,
                IsRecommended = false,
                Ranking = 7.4f,
                Comments = new Comment { comment_1 = "Delicious~", comment_2 = "Tasty!", comment_3 = "Yummy~~~" },
                Images = new ImagePath
                {
                    image_1 = "/Assets/Recommend/Delicacy/KFC/1.jpg",
                    image_2 = "/Assets/Recommend/Delicacy/KFC/2.jpg",
                    image_3 = "/Assets/Recommend/Delicacy/KFC/3.jpg"
                },
                Cp = new Coupon { Name = "香辣鸡腿堡1份", OriginalPrice = 16.5f, DiscountedPrice = 14.85f, SoldSum = 8213 }
            });

            return AllItem;
        }
    }
}
