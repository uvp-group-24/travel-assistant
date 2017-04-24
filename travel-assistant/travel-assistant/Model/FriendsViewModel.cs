using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class Picture
    {
        public string ImageUri { get; set; }
        public string Title { get; set; }
        public string label1 { get; set; }
        public string label2 { get; set; }
        public string label3 { get; set; }
        public string label4 { get; set; }
    }

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
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/21.jpg", Title = "Amy", label1 = "I've always wanted to go to Zhao Mausoleum park!" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/1.jpg", Title = "Alice", label2 = "Someone has been to dalian tiger beach before ?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/2.jpg", Title = "Anne", label3 = "Xi 'an is really beautiful! Invite me and we'll go together" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/3.jpeg", Title = "Alex", label1 = "Does anyone want to go to Hunnan Shopping mall?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/4.jpg", Title = "Betty", label2 = "Friends have been to Hansheng, interested?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/5.jpg", Title = "Bob", label4 = "I've always wanted to go to Zhao Mausoleum park!" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/10.jpg", Title = "Danny", label3 = "Someone has been to dalian tiger beach before ?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/9.jpeg", Title = "Diana", label4 = "Xi 'an is really beautiful! Invite me and we'll go together" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/6.jpeg", Title = "Diego", label3 = "Xi 'an is really beautiful! Invite me and we'll go together" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/7.jpg", Title = "Frank", label3 = "Does anyone want to go to Hunnan Shopping mall?"});
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/8.jpeg", Title = "Gary", label3 = "Does anyone want to go to Hunnan Shopping mall?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/9.jpeg", Title = "Gina", label3 = "Friends have been to Hansheng, interested?"});
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/10.jpg", Title = "Robert", label3 = "Zhao Mausoleum park? Wanna go?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/11.jpeg", Title = "Will", label3 = "Someone has been to dalian tiger beach before ?" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/12.jpeg", Title = "Tina", label3 = "I've always wanted to go to Zhao Mausoleum park!" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/31.jpg", Title = "张信民", label1 = "正在闭关修炼" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/32.jpg", Title = "程思雨", label2 = "好好上自习不出去玩" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/33.jpg", Title = "韩宇", label3 = "寝室开party ing~~" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/35.gif", Title = "杨迪", label4 = "吃啥带我一个" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/35.jpg", Title = "吴伯庸", label1 = "1928轰趴管走起啊" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/36.jpg", Title = "王一超", label2 = "浑南附近游乐园不错哦" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/37.jpg", Title = "陈婧", label3 = "吃啥都行，记得叫我" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/38.jpg", Title = "陈宇颖", label4 = "默默关注着你们" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/39.jpg", Title = "任卓", label4 = "拒绝邀请ing" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/40.jpg", Title = "杨尹豪", label3 = "如果唱歌，记得叫我" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/41.jpg", Title = "李思特", label2 = "去游泳啊2333" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/42.jpg", Title = "黄梅雪", label1 = "吃得好睡得香" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/43.jpg", Title = "赵思洋", label4 = "吃得好睡得香" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/44.jpg", Title = "郭宇", label1 = "减肥ing 不接受邀请" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/45.jpg", Title = "张旭静", label2 = "三顾冒菜馆不错~"});
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/46.jpg", Title = "程竹", label1 = "去吃多嘴肉蟹煲啊" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/8.jpeg", Title = "Kate", label3 = "Go and have fun~~~lalala" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/15.jpg", Title = "Otto", label4 = "Free on weekends~~" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/14.jpeg", Title = "Lisa", label3 = "Any ideas where to hang out near here?"});
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/13.jpeg", Title = "Victor", label3 = "Hansheng is a good place to grab some food~" });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/19.jpg", Title = "Xena", label3 = "Does anyone want to go to Hunnan Shopping mall ? " });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/17.jpeg", Title = "1Hans", label1 = "Does anyone want to go to Hunnan Shopping mall ? " });
            picturesList.Add(new Picture { ImageUri = "/Assets/Friends/17.jpeg", Title = "Kim", label3 = "San Gu Mao cai is good restaurant" });



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
