using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lottery.BusinessLogic
{
    internal class Player
    {
        public decimal InitialCapital { get; internal set; }
        public decimal RubbelLosPrice { get; internal set; }
        public decimal LottoLosPrice { get; internal set; }

        public void AdjustPrices(decimal newRubbelLosprice, decimal newLotteryLosprice)
        {

        }

        public void UpdateCapital(decimal amount)
        {

        }
    }
}
