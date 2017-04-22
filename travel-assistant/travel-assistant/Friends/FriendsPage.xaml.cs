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

namespace travel_assistant.Friends
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class FriendsPage : Page
    {
        private HashSet<String> MyFriends;
        //private Invitation MyInvitation;

        public FriendsPage()
        {
            this.InitializeComponent();
            MyFriends = new HashSet<string>();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contact = (Picture)e.ClickedItem;
            if (MyFriends.Contains(contact.Title))
                MyFriends.Remove(contact.Title);
            else MyFriends.Add(contact.Title);
            if (MyFriends.Count() > 0)
            {
                FriendsText.Text = "Invited: ";
                foreach (var names in MyFriends)
                    FriendsText.Text = FriendsText.Text + names + " ";
            }
            else
                FriendsText.Text = "";
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            if (MyFriends.Count() == 0)
            {
                FriendsText.Text = "Not a valid invitation";
            }
            else
            {
                InvitationView.IsPaneOpen = true;
                string PickedNames = "Invited : ";
                foreach (var names in MyFriends)
                    PickedNames = PickedNames + " " + names;
                InvitedNames.Text = PickedNames;
                FriendsText.Text = "";
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            Flyout pop = new Flyout();
            TextBlock ShowMsg = new TextBlock { FontSize = 36, Text = "Invitation Sended~" };
            pop.Content = ShowMsg;
            SendButton.Flyout = pop;

            InvitationModel.Invitations.Add(new InvitationModel
            {
                MeetTime = DayTime.DataContext.ToString() + HourTime.DataContext.ToString(),
                ToWhere = Location.Text,
                Names = InvitedNames.Text,
                Message = Msg.Text
            });
            MyFriends.Clear();
        }
    }
}
