using System;
using System.Collections.Generic;
using System.Linq;

namespace day00_5_ex00
{
    public class CashRegister
    {
        public string Lable { get; init; }
        private Queue<Customer> CustomerQueue { get; set; }

        public CashRegister(string lable)
        {
            Lable = lable ?? throw new ArgumentNullException(nameof(lable));
        }

        protected bool Equals(CashRegister other)
        {
            return Lable == other.Lable;
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CashRegister) obj);
        }

        public override int GetHashCode()
        {
            return (Lable != null ? Lable.GetHashCode() : 0);
        }

        public override string ToString() => Lable;


        public static bool operator ==(CashRegister left, CashRegister right) => Equals(left, right);
        public static bool operator !=(CashRegister left, CashRegister right) => !Equals(left, right);
        
        
        public int GetGoodsCount()
        {
            return CustomerQueue.Sum(customer => customer.CartCount);
        }

        public int GetCustomerCount() => CustomerQueue.Count;

        public void AddCustomerToQueue(Customer customer)
        {
            if (CustomerQueue.Contains(customer))
                throw new ArgumentException("Customer already in queue");
            CustomerQueue.Enqueue(customer);
        }

        public void ServeNextCustomer()
        {
            if (CustomerQueue.Count > 0)
                CustomerQueue.Dequeue();
        }
        
    }
}