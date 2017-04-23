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
        public string OrderNumber { get; set; } //订单号
        public string Image { get; set; } //图片
        public string ShopName { get; set; } //店名
        public string CouponName { get; set; } //券名
        public int Quantity { get; set; } //购买数量
        public float Costs { get; set; } //付款金额
        public string PurchaseDate { get; set; } //购买日期
        public string ExpireDate { get; set; } //有效日期
        public OrderStatus Status { get; set; } //订单状态

        public enum OrderStatus
        {
            WaitForPayment,
            Paid,
            WaitForDelivery,
            Delivering,
            WaitForReception,
            Received,
            Consumed,
            Refund
        }
   
        public static ObservableCollection<OrderModel> GetItems()
        {
            var AllItem = new ObservableCollection<OrderModel>();

            AllItem.Add(new OrderModel
            {
                OrderNumber = "2017424001",
                Image = "/Assets/Recommend/Delicacy/muwukaotui/1.jpg",
                ShopName = "木屋烤羊腿二部(白塔堡店)",
                CouponName = "烤羊腿超值套餐188元",
                Quantity = 1,
                Costs = 188.00f,
                PurchaseDate = "2017-04-23",
                ExpireDate = "2017-04-26",
                Status = OrderStatus.Consumed
            });
            AllItem.Add(new OrderModel
            {
                OrderNumber = "2017424002",
                Image = "/Assets/Recommend/Delicacy/hansheng/1.jpg",
                ShopName = "韩盛·盛江山自助料理",
                CouponName = "午餐自助餐一位",
                Quantity = 2,
                Costs = 137.80f,
                PurchaseDate = "2017-04-23",
                ExpireDate = "2017-04-26",
                Status = OrderStatus.Paid
            });
            AllItem.Add(new OrderModel
            {
                OrderNumber = "2017424003",
                Image = "/Assets/Recommend/Delicacy/duozui/1.jpg",
                ShopName = "多嘴肉蟹煲(奥体万达店)",
                CouponName = "代金券1张",
                Quantity = 3,
                Costs = 276.00f,
                PurchaseDate = "2017-04-23",
                ExpireDate = "2017-04-26",
                Status = OrderStatus.Refund
            });
            return AllItem;
        }
    }
}
