using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class CommentModel
    {
        public string Comment { get; set; }
        
        public static ObservableCollection<CommentModel> Comments = new ObservableCollection<CommentModel>();
    }
}
