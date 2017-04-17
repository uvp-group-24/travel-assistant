using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    class FriendsViewModel
    {
        public ObservableCollection<AlphaKeyGroup<Picture>> AllPictures { get; set; }

        public FriendsViewModel()
        {
            AllPictures = new ObservableCollection<AlphaKeyGroup<Picture>>();
            LoadData();
        }

        // Source = "Assets/1.png";

        public void LoadData()
        {
            List<Picture> picturesList = new List<Picture>();
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/21.jpg", Title = "Amy", label = "want or have to go:", label1 = "Zhangjiajie", label2 = "Dalian" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/1.jpg", Title = "Alice", label = "want or have to go:", label2 = "Dali", label4 = "Taishan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/2.jpg", Title = "Anne", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/3.jpeg", Title = "Alex", label = "want or have to go:", label1 = "Shenyang", label3 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/4.jpg", Title = "Betty", label = "want or have to go:", label2 = "Jiuzhaigou", label3 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/5.jpg", Title = "Bob", label = "want or have to go:", label4 = "Fanghuangshan", label2 = "Xizang" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/10.jpg", Title = "Danny", label = "want or have to go:", label3 = "Jiuzhaigou", label4 = "Tianjin" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/9.jpeg", Title = "Diana", label = "want or have to go:", label4 = "Taishan", label1 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/6.jpeg", Title = "Diego", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/7.jpg", Title = "Frank", label = "want or have to go:", label3 = "Dali", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/8.jpeg", Title = "Gary", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/9.jpeg", Title = "Gina", label = "want or have to go:", label3 = "Xizang", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/10.jpg", Title = "Robert", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/11.jpeg", Title = "Will", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Hangzhou" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/12.jpeg", Title = "Tina", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/31.jpg", Title = "张信民", label = "want or have to go:", label1 = "Dalian", label4 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/32.jpg", Title = "程思雨", label = "want or have to go:", label2 = "Shenyang", label3 = "Dandong" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/33.jpg", Title = "韩宇", label = "want or have to go:", label3 = "Shenyang", label2 = "Cangzhou" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/35.gif", Title = "杨迪", label = "want or have to go:", label4 = "Hengshan", label1 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/35.jpg", Title = "吴伯庸", label = "want or have to go:", label1 = "Dalian", label4 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/36.jpg", Title = "王一超", label = "want or have to go:", label2 = "Tianjin", label3 = "shanghai" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/37.jpg", Title = "陈婧", label = "want or have to go:", label3 = "Shenyang", label2 = "" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/38.jpg", Title = "陈宇颖", label = "want or have to go:", label4 = "Shenyang", label1 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/39.jpg", Title = "任卓", label = "want or have to go:", label4 = "Guiyang", label1 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/40.jpg", Title = "杨尹豪", label = "want or have to go:", label3 = "Shenyang", label2 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/41.jpg", Title = "李思特", label = "want or have to go:", label2 = "Hangzhou", label3 = "Chengde" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/42.jpg", Title = "黄梅雪", label = "want or have to go:", label1 = "Shenyang", label4 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/43.jpg", Title = "赵思洋", label = "want or have to go:", label4 = "Shenyang", label3 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/44.jpg", Title = "郭宇", label = "want or have to go:", label1 = "Shenyang", label2 = "Nanjing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/45.jpg", Title = "张旭静", label = "want or have to go:", label2 = "Shenyang", label3 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/46.jpg", Title = "程竹", label = "want or have to go:", label1 = "Shenyang", label4 = "Beijing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/8.jpeg", Title = "Kate", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/15.jpg", Title = "Otto", label = "want or have to go:", label4 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/14.jpeg", Title = "Lisa", label = "want or have to go:", label3 = "Jiuzhaigou", label1 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/13.jpeg", Title = "Victor", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/19.jpg", Title = "Xena", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/17.jpeg", Title = "1Hans", label = "want or have to go:", label1 = "Zhangjiajie", label2 = "Dalian" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/17.jpeg", Title = "Kim", label = "want or have to go:", label3 = "Jiuzhaigou", label2 = "Shaoshan" });



            //按拼音分组
            List<AlphaKeyGroup<Picture>> groupData = AlphaKeyGroup<Picture>.CreateGroups(
                picturesList, (Picture s) => s.Title, true);

            foreach (var item in groupData)
            {
                AllPictures.Add(item);
            }

        }
    }
}
