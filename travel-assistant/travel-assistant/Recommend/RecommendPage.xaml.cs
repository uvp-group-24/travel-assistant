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
using Windows.Devices.Geolocation;
using travel_assistant.Model;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Recommend
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class RecommendPage : Page
    {
        public static RecommendPage Current;
        private List<RecommendItem> RecommendItems;
        private ObservableCollection<RecommendItem> Suggestions = new ObservableCollection<RecommendItem>();
        private List<string> ComboBoxItems;
        public RecommendPage()
        {
            this.InitializeComponent();
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/background.jpg", UriKind.Absolute));
            MainGrid.Background = imageBrush;
            MainGrid.Background.Opacity = 0.5;
            SuggestionGrid.Background = imageBrush;
            SuggestionGrid.Background = imageBrush;
            RecommendItems = RecommendItemManager.GetItems().FindAll(r => r.IsRecommended == true);
            this.DataContext = RecommendItems;
            ComboBoxItems = GetComboBoxItems();
            NavigationCacheMode = NavigationCacheMode.Enabled;
            ContentFrame.Navigate(typeof(ContentPage));
            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> sections = new List<string>();
            foreach (HubSection section in HotHub.Sections)
            {
                if (section.Header != null)
                    sections.Add(section.Header.ToString());
            }
            ZoomedOutList.ItemsSource = sections;
            Delicacy_ComboBox_1.SelectedIndex = 0;
            Delicacy_ComboBox_2.SelectedIndex = 0;
            Current = this;
        }

        private List<string> GetComboBoxItems()
        {
            var ComboBoxItems = new List<string>();
            ComboBoxItems.Add("Default");
            ComboBoxItems.Add("Distance : Near to Far");
            ComboBoxItems.Add("Ranking : High to Low");
            ComboBoxItems.Add("Avg-Price : High to Low");
            ComboBoxItems.Add("Avg-Price : Low to High");
            return ComboBoxItems;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ItemWidth.Width = WidthFit.GetWidth(ActualWidth, 600, 300);
            PageWidth.Width = ActualWidth;
        }

        private void Recommend_Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContentInfo.Pivot_Item = Recommend_Pivot.SelectedIndex;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_ComboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContentInfo.ComboBox_1 = Delicacy_ComboBox_1.SelectedIndex;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_ComboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContentInfo.ComboBox_2 = Delicacy_ComboBox_2.SelectedIndex;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_CheckBox_1_Checked(object sender, RoutedEventArgs e)
        {
            ContentInfo.IsRecommended = true;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_CheckBox_1_Unchecked(object sender, RoutedEventArgs e)
        {
            ContentInfo.IsRecommended = false;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_CheckBox_2_Checked(object sender, RoutedEventArgs e)
        {
            ContentInfo.IsCoupon = true;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void Delicacy_CheckBox_2_Unchecked(object sender, RoutedEventArgs e)
        {
            ContentInfo.IsCoupon = false;
            ContentInfo.GetFilteredItems();
            //ContentFrame.Navigate(typeof(ContentPage));
        }

        private void SearchASB_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            splitview.IsPaneOpen = true;
            GoBackButton.Visibility = Visibility.Visible;
        }

        private void SearchASB_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var filteredItems = RecommendItemManager.GetItems().FindAll(p => p.Name.Contains(sender.Text)).ToList();
            var filterednames = filteredItems.Select(p => p.Name).ToList();
            Suggestions.Clear();
            filteredItems.ForEach(p => Suggestions.Add(p));
            sender.ItemsSource = filterednames;
        }

        private void Delicacy_GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = (RecommendItem)e.ClickedItem;
            Frame.Navigate(typeof(ItemDetailPage), item);
        }

        private void HotHub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            var section = (HubSection)e.Section;
            switch (section.Name)
            {
                case "Delicacy": Recommend_Pivot.SelectedIndex = 1; break;
                case "Hostel": Recommend_Pivot.SelectedIndex = 2; break;
                case "Entertainment": Recommend_Pivot.SelectedIndex = 3; break;
                case "Attraction": Recommend_Pivot.SelectedIndex = 4; break;
                case "Shopping": Recommend_Pivot.SelectedIndex = 5; break;
            }
        }

        private void splitview_PaneClosed(SplitView sender, object args)
        {
            GoBackButton.Visibility = Visibility.Collapsed;
        }
    }
}
