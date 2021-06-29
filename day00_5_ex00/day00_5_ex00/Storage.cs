using System;
using System.Collections.Generic;

namespace day00_5_ex00
{
    public class Storage
    {
        public int Capacity { get; init; }
        public List<string> Items { get; init; }
        public bool IsEmpty => Items.Count == 0;

        public Storage(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity),"Storage capacity must be grater than 0.");
            Capacity = capacity;
            Items = new List<string>();
        }
    }
}