using System;
using System.Collections.Generic;
using System.Linq;

namespace day00_5_ex00
{
    public static class CustomerExtensions
    {
        public static void ChooseCashRegisterWithLeastCustomers(this Customer customer,
            IEnumerable<CashRegister> cashRegisters)
        {
            var chosenRegister = (CashRegister)null;
            var minCount = int.MaxValue;
            
            foreach (var cr in cashRegisters)
            {
                var currentCount = cr.GetCustomerCount();
                if (currentCount <= minCount)
                {
                    minCount = currentCount;
                    chosenRegister = cr;
                }
            }

            if (chosenRegister != null)
                chosenRegister.AddCustomerToQueue(customer);
        }
        
        public static void ChooseCashRegisterWithLeastGoods(this Customer customer,
            IEnumerable<CashRegister> cashRegisters)
        {
            
        }

    }
}