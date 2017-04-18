using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_assistant.Model;

namespace travel_assistant.Model
{
    class User
    {
        public string Name { get; set; } //姓名
        public double Wealth { get; set; } //账户余额
        public List<Order> OrderList { get; set; } //订单列表
    }
}
