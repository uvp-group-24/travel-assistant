using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_assistant.Model
{
    class Order
    {
        public string OrderNumber { get; set; } //订单号
        public string ShopName { get; set; } //店名
        public string CouponName { get; set; } //券名
        public int Quantity { get; set; } //购买数量
        public double Costs { get; set; } //付款金额
        public string PurchaseDate { get; set; } //购买日期
        public OrderState State { get; set; } //订单状态
    }
    public enum OrderState
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
    class OrderManager
    {
        public static List<Order> GetItems()
        {
            var AllItem = new List<Order>();

            AllItem.Add(new Order
            {
                OrderNumber = "2017424001",
                ShopName = "木屋烤羊腿二部(白塔堡店)",
                CouponName = "烤羊腿超值套餐188元",
                Quantity = 1,
                Costs = 188.00,
                PurchaseDate = "2017.4.24",
                State = OrderState.Consumed
            });
            AllItem.Add(new Order
            {
                OrderNumber = "2017424002",
                ShopName = "韩盛·盛江山自助料理",
                CouponName = "午餐自助餐一位",
                Quantity = 2,
                Costs = 137.80,
                PurchaseDate = "2017.4.24",
                State = OrderState.Paid
            });
            AllItem.Add(new Order
            {
                OrderNumber = "2017424003",
                ShopName = "多嘴肉蟹煲(奥体万达店)",
                CouponName = "代金券1张",
                Quantity = 3,
                Costs = 276.00,
                PurchaseDate = "2017.4.24",
                State = OrderState.Refund
            });

            return AllItem;
        }
    }
}
