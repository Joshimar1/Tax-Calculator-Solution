using System;

namespace Tax_Calculator
{
    class Program
    {
        public decimal FederalTaxes(decimal moneyMade)
        {
            decimal fedTaxesOwed = 0;
            if (moneyMade <= 9875)
            {
                fedTaxesOwed = moneyMade * 0.10M;
            }
            else if (moneyMade >= 9876 && moneyMade <= 40125)
            {
                fedTaxesOwed = 987.50M + ((moneyMade - 9875) * 0.12M);
            }
            else if (moneyMade >= 40126 && moneyMade <= 85525)
            {
                fedTaxesOwed = 4617.50M + ((moneyMade - 40125) * 0.22M);
            }
            else if (moneyMade >= 85526 && moneyMade <= 163300)
            {
                fedTaxesOwed = 14605.50M + ((moneyMade - 85525) * 0.24M);
            }
            else if (moneyMade >= 163301 && moneyMade <= 207350)
            {
                fedTaxesOwed = 33271.50M + ((moneyMade - 163300) * 0.32M);
            }
            else if (moneyMade >= 207351 && moneyMade <= 518400)
            {
                fedTaxesOwed = 47367.50M + ((moneyMade - 207350) * 0.35M);
            }
            else  // Over $518,400
            {
                fedTaxesOwed = 156235M + ((moneyMade - 518400) * 0.37M);
            }
            return fedTaxesOwed;
        }


        public decimal StateTaxes(decimal moneyMade)
        {
            decimal stateTaxesOwed = 0;
            stateTaxesOwed = moneyMade * 0.0525M;
            return stateTaxesOwed;
        }

        public void TaxInfo(decimal moneyMade)
        {
            decimal totalMoneyMade = moneyMade;
            decimal totalTaxesToPay = (FederalTaxes(moneyMade) + StateTaxes(moneyMade));
            decimal profit = moneyMade - totalTaxesToPay;

            Console.WriteLine($"Total money made: {moneyMade}");
            Console.WriteLine($"Federal taxes owed: {FederalTaxes(moneyMade)}");
            Console.WriteLine($"State taxes owed: {StateTaxes(moneyMade)}");
            Console.WriteLine($"Total taxes owed: {(FederalTaxes(moneyMade) + StateTaxes(moneyMade))}");
            Console.WriteLine($"Total profit made: {profit}");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            Program function = new Program();

            decimal amountMade = 10000M;
            function.TaxInfo(amountMade);

            decimal amountToCompare = 20000;
            function.TaxInfo(amountToCompare);

            decimal amountToCompare2 = 30000;
            function.TaxInfo(amountToCompare2);

            decimal amountToCompare3 = 40000M;
            function.TaxInfo(amountToCompare3);

            decimal amountToCompare4 = 50000M;
            function.TaxInfo(amountToCompare4);

            decimal amountToCompare5 = 75000M;
            function.TaxInfo(amountToCompare5);

            decimal amountToCompare6 = 100000M;
            function.TaxInfo(amountToCompare6);

            decimal amountToCompare7 = 125000M;
            function.TaxInfo(amountToCompare7);

            decimal amountToCompare8 = 150000M;
            function.TaxInfo(amountToCompare8);

            decimal amountToCompare9 = 200000M;
            function.TaxInfo(amountToCompare9);

            decimal amountToCompare10 = 250000M;
            function.TaxInfo(amountToCompare10);

            Console.ReadLine();
        }



        //decimal totalMoneyMade = 155704M;
        //decimal totalMoneyMadeToCompare = totalMoneyMade * 2;
        //decimal totalTaxesToPay = (function.FederalTaxes(totalMoneyMade) + function.StateTaxes(totalMoneyMade));
        //decimal profit = totalMoneyMade - totalTaxesToPay;
        //decimal totalTaxesToPayToCompare = (function.FederalTaxes(totalMoneyMadeToCompare) + function.StateTaxes(totalMoneyMadeToCompare));
        //decimal profitToCompare = totalMoneyMadeToCompare - totalTaxesToPayToCompare;


        //Console.WriteLine($"Total money made: {totalMoneyMade}");
        //    Console.WriteLine($"Federal taxes owed: {function.FederalTaxes(totalMoneyMade)}");
        //    Console.WriteLine($"State taxes owed: {function.StateTaxes(totalMoneyMade)}");
        //    Console.WriteLine($"Total taxes owed: {totalTaxesToPay}");
        //    Console.WriteLine($"Total profit made: {profit}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Total money made: {totalMoneyMadeToCompare}");
        //    Console.WriteLine($"Federal taxes owed: {function.FederalTaxes(totalMoneyMadeToCompare)}");
        //    Console.WriteLine($"State taxes owed: {function.StateTaxes(totalMoneyMadeToCompare)}");
        //    Console.WriteLine($"Total taxes owed: {totalTaxesToPayToCompare}");
        //    Console.WriteLine($"Total profit made: {profitToCompare}");
    }
}
