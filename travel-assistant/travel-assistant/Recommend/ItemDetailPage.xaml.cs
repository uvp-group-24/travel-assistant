﻿using System;
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
using System.Collections.ObjectModel;
using travel_assistant.Model;
using System.ComponentModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Recommend
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ItemDetailPage : Page
    {
        public ItemDetailData data;
        public int Quantity { get; set; }
        public RecommendItem SelectedItem { get; set; }
        public ItemDetailPage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (SelectedItem.Cp == null)
            {
                CouponSection.ContentTemplate = EmptyBorder;
            }
            SetRankingStar();
            RankingNumber.Text = SelectedItem.Ranking.ToString("f");
            List<string> sections = new List<string>();
            foreach (HubSection section in DetailsHub.Sections)
            {
                if (section.Header != null)
                    sections.Add(section.Header.ToString());
            }
            ZoomedOutList.ItemsSource = sections;
            data = new ItemDetailData(SelectedItem.Cp);
            CouponSection.DataContext = data;
            CommentSection.DataContext = SelectedItem.Comments;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedItem = (RecommendItem)e.Parameter;
            DataContext = SelectedItem;
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

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            UserModel.User.OrderModels.Add(new OrderModel
            {
                OrderNumber = "2017424004",
                Image = SelectedItem.Images.image_1,
                ShopName = SelectedItem.Name,
                CouponName = SelectedItem.Cp.Name,
                Quantity = data.Quantity,
                Costs = SelectedItem.Cp.DiscountedPrice * Quantity,
                PurchaseDate = "2017-04-24",
                ExpireDate = "2017-04-27",
                Status = OrderModel.OrderStatus.Received,
            });
            data.SoldSum++;
        }

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            if (data.Quantity > 1) data.Quantity--;
        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            data.Quantity++;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }
    }

    public class ItemDetailData: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public float OriginalPrice { get; set; }
        public float DiscountedPrice { get; set; }
        private int soldsum;
        public int SoldSum {
            get
            {
                return soldsum;
            }
            set
            {
                soldsum = value;
                OnPropertyChanged("SoldSum");
            }
        }
        private int quantity;
        public int Quantity {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        private float totalcosts;
        public float Totalcosts
        {
            get
            {
                return totalcosts;
            }
            set
            {
                totalcosts = value;
                OnPropertyChanged("Totalcosts");
            }
        }
        public ItemDetailData(Coupon item)
        {
            if (item != null)
            {
                Name = item.Name;
                OriginalPrice = item.OriginalPrice;
                DiscountedPrice = item.DiscountedPrice;
                SoldSum = item.SoldSum;
                Quantity = 1;
                Totalcosts = item.DiscountedPrice;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
