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
        public string UserID { get; set; } //用户ID
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
}
