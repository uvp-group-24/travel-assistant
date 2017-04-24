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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace travel_assistant.Me
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ShowInvitation : Page
    {
        public ShowInvitation()
        {
            this.InitializeComponent();
            InitInformation();
        }

        public void InitInformation()
        {
            InvitationModel.Invitations.Add(new InvitationModel
            {
                MeetDayTime = "2017/3/5",
                MeetHourTime = "8:00",
                ToWhere = "必胜客（浑南店）",
                Names = "李思特 杨尹豪",
                Message = "记得带钱啊~~"
            });
            InvitationModel.Invitations.Add(new InvitationModel
            {
                MeetDayTime = "2017/4/1",
                MeetHourTime = "10:00",
                ToWhere = "韩盛自助餐（浑南店）",
                Names = "任卓 陈婧",
                Message = "这次咱们一定得吃回来!!"
            });
            InvitationModel.Invitations.Add(new InvitationModel
            {
                MeetDayTime = "2017/4/12",
                MeetHourTime = "14:00",
                ToWhere = "NEU natatorium",
                Names = "Alex Bill Bob Kate",
                Message = "Rmemeber that's wensday~! Don't be late"
            });
            InvitationModel.Invitations.Add(new InvitationModel
            {
                MeetDayTime = "2017/4/15",
                MeetHourTime = "15:00",
                ToWhere = "Chessboard Hill",
                Names = "Site Fiona",
                Message = "Hanging out~~"
            });
            InvitationList.ItemsSource = InvitationModel.Invitations;
            
        }
    }
}
