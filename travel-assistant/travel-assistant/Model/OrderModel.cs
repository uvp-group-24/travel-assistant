using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    public class OrderModel
    {
        public string OrderName { get; set; }

        public static OrderModel CurSelected;
        public static ObservableCollection<OrderModel> OrderModels = new ObservableCollection<OrderModel>();
        
    }
}
