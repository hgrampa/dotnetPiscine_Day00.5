using System;

namespace day00_5_ex00
{
    public class Customer
    {
        private const int _minRequestGoodsCount = 1;

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
        
        /// <summary>
        ///  Set CartCount with random value between "_minRequestGoodsCount" "maxOfferGoodsCount".
        /// If offer lower than min request - set CartCount with _minRequestGoodsCount
        /// </summary>
        /// <param name="maxOfferGoodsCount">
        /// The maximum value offered by the store that can be added to the cart
        /// </param>
        /// <returns>
        /// The number of products that have been chosen
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// max offer can't be negative
        /// </exception>
        public int FillCart(int maxOfferGoodsCount)
        {
            switch (maxOfferGoodsCount)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException(nameof(maxOfferGoodsCount),"max offer can't be negative");
                case < _minRequestGoodsCount:
                    CartCount = maxOfferGoodsCount;
                    break;
                default:
                {
                    var rng = new Random();
                    CartCount = rng.Next(_minRequestGoodsCount, maxOfferGoodsCount);
                    break;
                }
            }
            return CartCount;
        }
    }
}