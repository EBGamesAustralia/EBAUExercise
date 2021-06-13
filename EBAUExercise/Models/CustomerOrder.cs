using System;

namespace EBAUExercise.Models
{
    public class CustomerOrder
    {
        private int pCustomerID = -1;
        private int pOrderID = -1;
        private decimal pOrderTotal = -1;
        private DateTime pOrderDate;
        
        public CustomerOrder(int customerId, int orderId, decimal orderTotal, DateTime orderDate)
        {
            pCustomerID = customerId;
            pOrderID = orderId;
            pOrderTotal = orderTotal;
            pOrderDate = orderDate;
        }

        public int CustomerId
        {
            get {return pCustomerID;}
        }
        public int OrderId
        {
            get {return pOrderID;}
        }
        public decimal OrderTotal
        {
            get {return pOrderTotal;}
        }
        public DateTime OrderDate
        {
            get {return pOrderDate;}
        }
    }
}