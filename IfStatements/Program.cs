using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string myMoney = Console.ReadLine();
            string moneyToSpend = Console.ReadLine();

            decimal money = decimal.Parse(myMoney);
            decimal toSpend = decimal.Parse(moneyToSpend);

            decimal leftMoney = money - toSpend;

            bool iHaveMoneyToBuyProduct = leftMoney > 0;
            bool iDontHaveMoney = leftMoney <= 0;
            bool noMoneyLeft = leftMoney == 0;

            if (iHaveMoneyToBuyProduct)
            {
                Console.WriteLine("I can buy this product.");
                Console.WriteLine("Money left: " + leftMoney);
            } 
            else if (!iHaveMoneyToBuyProduct)
            {
                Console.WriteLine("I don't have money.. moving forward.");
            }

            if (iDontHaveMoney)
            {
                Console.WriteLine("I don't have money to buy this product.");
                Console.WriteLine("Money to buy this product: " + (leftMoney * -1));
            }

            if(noMoneyLeft)
            {
                Console.WriteLine("No money left.");
            }

            int test = 1;

            switch (test)
            {
                case 1: Console.WriteLine("Case 1"); break;
                case 2: Console.WriteLine("Case 2"); break;
            }
            //    true/false          true/false
            if(test == 1 || test % 2 == 0)
            {
                Console.WriteLine("Case 1");
            } 
            else if(test == 2)
            {
                Console.WriteLine("Case 2");
            }


            // && - and
            // || - or


        }
    }
}
