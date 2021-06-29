using System;

namespace day00_5_ex00
{
    public class Customer
    {
        public string Name { get; init; }
        public int Id { get; init; }
        public int CartCount { get; protected set; }

        public Customer(string name, int id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = id;
            CartCount = 0;
        }

        
        protected bool Equals(Customer other)
        {
            return Name == other.Name
                   && Id == other.Id;
        }

        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Id);
        }

        public override string ToString() => $"{Name}[{Id.ToString()}] has {CartCount.ToString()} goods in cart";
        

        public static bool operator ==(Customer left, Customer right) => Equals(left, right);
        public static bool operator !=(Customer left, Customer right) => !Equals(left, right);


        public void FillCart(int maxCapacity)
        {
            if (maxCapacity < 0)
                throw new ArgumentOutOfRangeException(nameof(maxCapacity),"maxCapacity can't be negative");
            var rng = new Random();
            CartCount = rng.Next(0, maxCapacity);
        }
    }
}