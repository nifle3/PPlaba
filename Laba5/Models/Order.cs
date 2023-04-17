using System.Diagnostics.CodeAnalysis;

namespace Laba5.Models
{
    public class Order
    {
        public int OrderId { set; get; }
        public int PhoneId { set; get; }
        public Phone Phone { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
        public string Adress { get; set; }
        public int TotalPrice { set; get; }
        public Status OrderStatus { set; get; }
    }

    public enum Status
    {
        Success, Transport, Return, Error, Accepted, Delivered
    }
}
