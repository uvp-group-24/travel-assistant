using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using travel_assistant.Model;
using System.Collections.ObjectModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Recommend
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ContentPage : Page
    {
        private ObservableCollection<RecommendItem> RecommendItems;
        public ContentPage()
        {
            this.InitializeComponent();
            RecommendItems = ContentInfo.RecommendItems;
            //RecommendItems = ChangeContent();
        }
        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            width.Width = WidthFit.GetWidth(ActualWidth, 600, 300);
        }
        //private List<RecommendItem> ChangeContent()
        //{
        //    var RecommendItems = new List<RecommendItem>();
        //    RecommendItems = ContentInfo.Instance.RecommendItems.FindAll(r => (int)r.MC == ContentInfo.Instance.Pivot_Item - 1);
        //    if (ContentInfo.Instance.ComboBox_1 != 0)
        //    {
        //        RecommendItems = RecommendItems.FindAll(r => (int)r.SC == ContentInfo.Instance.ComboBox_1 - 1);
        //    }
        //    if (ContentInfo.Instance.ComboBox_2 != 0)
        //    {
        //        switch (ContentInfo.Instance.ComboBox_2)
        //        {
        //            case 1:break;
        //            case 2:
        //                RecommendItems.Sort((r1, r2) => r2.Ranking.CompareTo(r1.Ranking));
        //                break;
        //            case 3:
        //                RecommendItems.Sort((r1, r2) => r2.Price.CompareTo(r1.Price));
        //                break;
        //            case 4:
        //                RecommendItems.Sort((r1, r2) => r1.Price.CompareTo(r2.Price));
        //                break;
        //        }
        //    }
        //    if (ContentInfo.Instance.IsRecommended)
        //    {
        //        RecommendItems = RecommendItems.FindAll(delegate (RecommendItem r) { return r.IsRecommended == true; });
        //    }
        //    if (ContentInfo.Instance.IsCoupon)
        //    {
        //        RecommendItems = RecommendItems.FindAll(delegate (RecommendItem r) { return r.Cp != null; });
        //    }
        //    return RecommendItems;
        //}
    }
    public static class ContentInfo
    {
        public static int Pivot_Item { get; set; }
        public static int ComboBox_1 { get; set; }
        public static int ComboBox_2 { get; set; }
        public static bool IsRecommended { get; set; }
        public static bool IsCoupon { get; set; }
        public static ObservableCollection<RecommendItem> RecommendItems { get; set; } = new ObservableCollection<RecommendItem>();
        public static void GetFilteredItems()
        {
            var filteredItems = RecommendItemManager.GetItems();

            filteredItems = filteredItems.FindAll(r => (int)r.MC == ContentInfo.Pivot_Item - 1);
            if (ContentInfo.ComboBox_1 != 0)
            {
                filteredItems = filteredItems.FindAll(r => (int)r.SC == ContentInfo.ComboBox_1 - 1);
            }
            if (ContentInfo.ComboBox_2 != 0)
            {
                switch (ContentInfo.ComboBox_2)
                {
                    case 1: break;
                    case 2:
                        filteredItems.Sort((r1, r2) => r2.Ranking.CompareTo(r1.Ranking));
                        break;
                    case 3:
                        filteredItems.Sort((r1, r2) => r2.Price.CompareTo(r1.Price));
                        break;
                    case 4:
                        filteredItems.Sort((r1, r2) => r1.Price.CompareTo(r2.Price));
                        break;
                }
            }
            if (ContentInfo.IsRecommended)
            {
                filteredItems = filteredItems.FindAll(delegate (RecommendItem r) { return r.IsRecommended == true; });
            }
            if (ContentInfo.IsCoupon)
            {
                filteredItems = filteredItems.FindAll(delegate (RecommendItem r) { return r.Cp != null; });
            }

            RecommendItems.Clear();
            filteredItems.ForEach(p => RecommendItems.Add(p));
        }
    }
}
