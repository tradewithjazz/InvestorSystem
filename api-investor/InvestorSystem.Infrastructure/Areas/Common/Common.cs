using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestorSystem.Core.Areas.Common;
using InvestorSystem.Core.Areas.Common.DTOs;

namespace InvestorSystem.Infrastructure.Areas.Common
{
    public class Common : ICommon
    {
        public int GetInterestRateAsPerAmount(long amount,int role)
        {
            int interest = -1;
            if (role == (int)Enums.UserRole.Employee)
                interest = 5;
            else
            {
                switch (amount)
                {
                    case var exp when amount < 1000000:
                        interest = 3;
                        break;

                    case var exp when (amount >= 1000000 && amount <= 2500000):
                        interest = 4;
                        break;

                    case var exp when amount > 2500000:
                        interest = 0;  //special case, for 25L = 4% interest and  for remaining amount 5% interest rate
                        break;
                }
            }
            return Convert.ToInt32(interest);

        }      

    }
}
