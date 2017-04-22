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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Recommend
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ItemDetailPage : Page
    {
        public RecommendItem SelectedItem { get; set; }
        public string haha { get; set; }
        public ItemDetailPage()
        {
            this.InitializeComponent();
            haha = "haha";
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SetRankingStar();
            RankingNumber.Text = SelectedItem.Ranking.ToString("f");
            List<string> sections = new List<string>();
            foreach (HubSection section in DetailsHub.Sections)
            {
                if (section.Header != null)
                    sections.Add(section.Header.ToString());
            }
            ZoomedOutList.ItemsSource = sections;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedItem = (RecommendItem)e.Parameter;
        }
        private void SetRankingStar()
        {
            var ranking = (double)SelectedItem.Ranking;
            if (ranking > 0) Halfstar_1.Visibility = Visibility.Visible;
            if (ranking > 1) Fullstar_1.Visibility = Visibility.Visible;
            if (ranking > 2) Halfstar_2.Visibility = Visibility.Visible;
            if (ranking > 3) Fullstar_2.Visibility = Visibility.Visible;
            if (ranking > 4) Halfstar_3.Visibility = Visibility.Visible;
            if (ranking > 5) Fullstar_3.Visibility = Visibility.Visible;
            if (ranking > 6) Halfstar_4.Visibility = Visibility.Visible;
            if (ranking > 7) Fullstar_4.Visibility = Visibility.Visible;
            if (ranking > 8) Halfstar_5.Visibility = Visibility.Visible;
            if (ranking > 9 && ranking <= 10) Fullstar_5.Visibility = Visibility.Visible;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.Current.MainFrame.CanGoBack) MainPage.Current.MainFrame.GoBack();
        }
    }
}
