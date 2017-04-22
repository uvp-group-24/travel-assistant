using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class Invitation
    {
        public HashSet<string> invitees { get; set; }
    }

    public class InvitationManager
    {
        public static List<Invitation> Init()
        {
            return new List<Invitation>();
        }
    }
}
