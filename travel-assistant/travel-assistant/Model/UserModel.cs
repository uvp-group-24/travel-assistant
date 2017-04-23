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
        public string UserAccount { get; set; } //用户ID
        public string Name { get; set; } //姓名
        public string Sex { get; set; } //性别
        public string Nickname { get; set; } //昵称
        public string PhoneNumber { get; set; } //电话
        public string Email { get; set; } //Email
        public string AvatarPath { get; set; } //头像路径
        public float Wealth { get; set; } //账户余额
        public int Credits { get; set; } //积分
        public ObservableCollection<OrderModel> OrderModels { get; set; }
        public static UserModel User = new UserModel
        {
            UserAccount = "201704001",
            Name = "Bill Gates",
            Sex = "Male",
            Nickname = "Superman~",
            PhoneNumber = "18576768619",
            Email = "Site1997@neu.edu.cn",
            AvatarPath = "/Assets/Me/male-01.png",
            Wealth = 10000.00f,
            Credits = 200,
            OrderModels = OrderModel.GetItems()
        };
    }
}
