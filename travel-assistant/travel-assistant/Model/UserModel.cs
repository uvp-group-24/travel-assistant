using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_assistant.Model;
using System.Collections.ObjectModel;

namespace travel_assistant.Model
{
    class UserModel
    {
        public string UserID { get; set; } //用户ID
        public string Name { get; set; } //姓名
        public float Wealth { get; set; } //账户余额
        public ObservableCollection<OrderModel> OrderModels { get; set; }
        public static UserModel User = new UserModel
        {
            UserID = "2017001",
            Name = "Bill Yeung",
            Wealth = 1000.00f,
            OrderModels = OrderModel.GetItems()
        };
    }
}
