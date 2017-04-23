using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class InvitationModel
    {
        public string MeetDayTime { get; set; }
        public string MeetHourTime { get; set; }
        public string ToWhere { get; set; }
        public string Names { get; set; }
        public string Message { get; set; }

        public static InvitationModel CurSelected;
        public static ObservableCollection<InvitationModel> Invitations = new ObservableCollection<InvitationModel>();
    }
}
