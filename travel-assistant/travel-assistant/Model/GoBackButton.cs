//<Button Name = "Goback"
//        Background="MediumBlue"
//        Foreground="White"
//        Content=";"
//        FontFamily="Segoe MDL2 Assets"
//        FontSize="36"
//        BorderThickness="3"
//        BorderBrush="Black"
//        RelativePanel.AlignLeftWithPanel="True"
//        Click="Goback_Click" />

//private void Goback_Click(object sender, RoutedEventArgs e)
//{
//    if (Frame.CanGoBack) Frame.GoBack();
//}

//返回键只能置于二级Page的标题栏，不能置于一级Page
//二级Page不能置于一级Page的子Frame中，应与一级Page同在一个Frame中，即承载一级Page的Frame（mainframe）
//一级Page跳到二级Page的方法：在一级Page的cs文件中使用Frame.Navigate(typeof(...))