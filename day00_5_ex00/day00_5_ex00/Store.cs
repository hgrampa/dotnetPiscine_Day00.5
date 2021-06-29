using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace day00_5_ex00
{
    public class Store
    {
        public Storage Storage { get; init; }
        public List<CashRegister> CashRegisters { get; init; }
        public bool IsOpen => Storage.IsEmpty;
        
        public Store(int storageCapacity, int сashRegistersCount)
        {
            Storage = new Storage(storageCapacity);
            if (сashRegistersCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(сashRegistersCount),
                    "сash registers count capacity must be grater than 0.");
            CashRegisters = new List<CashRegister>();
            for (int i = 0; i < сashRegistersCount; i++)
            {
                CashRegisters.Add(new CashRegister($"№{i}"));
            }
        }

        protected void AddCashRegister()
        {
            
        }
    }
}