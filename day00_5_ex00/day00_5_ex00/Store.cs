using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace day00_5_ex00
{
    public class Store
    {
        private readonly int _cartCapacity;
        
        public Storage Storage { get; init; }
        public List<CashRegister> CashRegisters { get; init; }
        public bool IsOpen => Storage.IsEmpty;
        
        public Store(int storageCapacity, int cashRegistersCount, int cartCapacity = 7)
        {
            Storage = new Storage(storageCapacity);
            if (cashRegistersCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(cashRegistersCount),
                    "сash registers count capacity must be grater than 0.");
            CashRegisters = new List<CashRegister>();
            for (var i = 0; i < cashRegistersCount; i++)
            {
                CashRegisters.Add(new CashRegister($"№{i}"));
            }

            _cartCapacity = cartCapacity;
        }
        
        
        public void FillCustomerCart(Customer customer)
        {
            if (Storage.IsEmpty)
                return;
            var offerGoodsCount = Storage.Capacity < _cartCapacity ? Storage.Capacity : _cartCapacity;
            Storage.Withdrawal(customer.FillCart(offerGoodsCount));
        }
    }
}