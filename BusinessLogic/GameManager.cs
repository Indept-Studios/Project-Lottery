using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lottery.BusinessLogic
{
    internal class GameManager
    {
        private decimal capital;
        private int totalRubbelLoseSold;
        private int totalLottoLoseSold;
        private decimal jackpot;
        private Player player;

        private int currentDay;
        private bool dayInPrgogress;
        private Random random;

        public List<string> eventlog;

        public GameManager(Player player)
        {
            this.player = player;
            this.capital = player.InitialCapital;
            this.totalRubbelLoseSold = 0;
            this.totalLottoLoseSold = 0;
            this.jackpot = 1000;

            this.currentDay = 1;
            this.dayInPrgogress = false;
            this.random = new Random();
            this.eventlog = new List<string>();
        }


        public void StartDay()
        {
            if (!dayInPrgogress)
            {
                dayInPrgogress = true;
                LogEvent($"Day {currentDay} started.");
            }
        }

        public void EndDay()
        {
            if (dayInPrgogress)
            {
                LogEvent($"Day {currentDay} ended.");
            }
        }

        private void ProcessRubbelLosSale()
        {
            totalLottoLoseSold++;
            decimal losPrice = player.RubbelLosPrice;

            bool isWinner = random.Next(100) < 1;
            if (isWinner)
            {
                decimal winAmount = random.Next(50, 500);
                capital -= winAmount;
                LogEvent($"Rubbel-Los win! {winAmount} € cashed out.");
            }
            else
            {
                capital += losPrice;
                LogEvent($"Rubbel-Los sold for {losPrice} €.");
            }
        }

        public void ProcessLottoLosSale(int[] chosenNumbers)
        {
            totalLottoLoseSold++;
            decimal losPrice = player.LottoLosPrice;
            capital += losPrice;
            jackpot += losPrice * 0.5m;
            LogEvent($"Lotto-Los sold for {losPrice} €.");
        }

        private void DrawLottoNumbers()
        {
            int[] winningNumbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                winningNumbers[i] = random.Next(1, 50);
            }
            LogEvent($"The Lotto-Numbers are: {string.Join(", ", winningNumbers)}");
        }

        private void ProcessEvents()
        {
            int chance = random.Next(100);
            if (chance < 5)
            {
                LogEvent($"Burglary! 500€ stolen");
                capital -= 500;
            }
            else if (chance < 10)
            {
                LogEvent($"The Gambling Commission has imposed a 200€ fine.");
                capital -= 200;
            }
        }

        private void LogEvent(string message)
        {
            eventlog.Add(message);
            if (eventlog.Count > 3)
            {
                eventlog.RemoveAt(0);
            }
        }

        public decimal GetCapital()
        {
            return capital;
        }

        internal object GetDaySummary()
        {
            return null;
        }

        internal void SimulateTicketSales()
        {

        }
    }
}
