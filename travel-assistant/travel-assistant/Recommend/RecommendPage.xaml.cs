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
using Windows.Devices.Geolocation;
using travel_assistant.Model;
using System.Collections.ObjectModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Recommend
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class RecommendPage : Page
    {
        private List<RecommendItem> RecommendItems;
        private List<string> Suggestions;
        private List<string> ComboBoxItems;
        public RecommendPage()
        {
            this.InitializeComponent();
            RecommendItems = RecommendItemManager.GetItems().FindAll(r => r.IsRecommended == true);
            ComboBoxItems = GetComboBoxItems();
            ContentFrame.Navigate(typeof(ContentPage));
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
            width.Width = WidthFit.GetWidth(ActualWidth, 600, 300);
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

        }

        private void SearchASB_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

            Suggestions = RecommendItemManager.GetItems().FindAll(p => p.Name.Contains(sender.Text)).Select(p => p.Name).ToList();
            sender.ItemsSource = Suggestions;
        }
    }
}
