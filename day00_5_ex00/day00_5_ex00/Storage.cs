using System;
using System.Collections.Generic;

namespace day00_5_ex00
{
    public class Storage
    {
        public int MaxCapacity { get; init; }
        public int Capacity { get; protected set; }
        public bool IsEmpty => Capacity == 0;

        public Storage(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity),"Storage capacity must be grater than 0.");
            Capacity = capacity;
            MaxCapacity = capacity;
        }

        public override string ToString() => $"Storage [{Capacity.ToString()}/{MaxCapacity.ToString()}]";

        public void Withdrawal(int amount)
        {
            // Useless check in current architecture (Store do this)
            // var giveAmount = amount > Capacity ? Capacity : amount;
            Capacity -= amount;
        }
    }
}