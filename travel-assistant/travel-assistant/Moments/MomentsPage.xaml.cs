using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using travel_assistant.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace travel_assistant.Moments
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MomentsPage : Page
    {
        private ObservableCollection<Photo> Photos;
        private Popup popup = new Popup();
        private static int LikeClick = 0;

        public MomentsPage()
        {
            this.InitializeComponent();
            Photos = PhotoViewModel.GetPhotos();
            this.DataContext = this;
            CommentList.ItemsSource = CommentModel.Comments;
            popup.RenderTransform = new TranslateTransform();
        }

        //var info1 = new CommonNavigationTransitionInfo(); // page flip
        //var info2 = new EntranceNavigationTransitionInfo(); // normal up.

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            popup.IsOpen = false;

            var tappedImage = e.OriginalSource as Image;
            tappedImage.Opacity = 1;
            tappedImage.Stretch = Stretch.UniformToFill;

            var Panel = new RelativePanel();
            var image = new Image { Source = tappedImage.Source };
            var closeButton = new Button { Content = "X", FontSize = 12 };
            closeButton.Click += CloseButton_Click;

            Panel.Children.Add(image);
            Panel.Children.Add(closeButton);
            popup.Child = Panel;
            popup.IsOpen = true;

            //获取被点击图片相对MainPage的坐标
            var position = tappedImage.TransformToVisual(this).TransformPoint(new Point());
            //获取MainPage的中心坐标
            var xCenter = ActualWidth / 2 - 200;
            var yCenter = ActualHeight / 2 - 200;

            var storyBoard = new Storyboard();
            var extendAnimation = new DoubleAnimation { Duration = new Duration(TimeSpan.FromSeconds(0.5)), From = 200, To = 400, EnableDependentAnimation = true };
            Storyboard.SetTarget(extendAnimation, image);
            Storyboard.SetTargetProperty(extendAnimation, "Width");
            Storyboard.SetTargetProperty(extendAnimation, "Height");

            var xAnimation = new DoubleAnimation { Duration = new Duration(TimeSpan.FromSeconds(0.5)), From = position.X, To = xCenter, EnableDependentAnimation = true };
            Storyboard.SetTarget(xAnimation, popup);
            Storyboard.SetTargetProperty(xAnimation, "(UIElement.RenderTransform).(TranslateTransform.X)");

            var yAnimation = new DoubleAnimation { Duration = new Duration(TimeSpan.FromSeconds(0.5)), From = position.Y, To = yCenter, EnableDependentAnimation = true };
            Storyboard.SetTarget(yAnimation, popup);
            Storyboard.SetTargetProperty(yAnimation, "(UIElement.RenderTransform).(TranslateTransform.Y)");

            storyBoard.Children.Add(extendAnimation);
            storyBoard.Children.Add(xAnimation);
            storyBoard.Children.Add(yAnimation);

            storyBoard.Begin();
            
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
        }

        private void CommentButton_Click(object sender, RoutedEventArgs e)
        {
            CommentModel.Comments.Add(new CommentModel { Comment = "Site Li : " + Comment.Text });
        }

        private void LikeButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            LikeClick++;
            if (LikeClick % 2 == 0) LikeTextBlock.Text = "\uE006";
            else LikeTextBlock.Text = "\uE00B";
        }
    }
}
