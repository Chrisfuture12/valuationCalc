using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessValuationCalculator
{
    class ValuationCalc 
    {
        public static double getInput(string x){
            string input;
            Console.WriteLine("Please enter the "+x);
            input = Console.ReadLine();
            double inputP = double.Parse(input);
            return inputP;
        }
        public static string getType(){
            string inx;
            Console.WriteLine("Are you looking for valuation, percent, or investment?");
            inx = Console.ReadLine();
            return inx;
        }
        public static void display(string x){
            Console.WriteLine(x);
        }

        public static void Main(){
            string type = getType();
            double investment;
            double percent;
            double valuation;

            if(type == "valuation"){
                investment = getInput("investment amount");
                percent = getInput("percent amount");
                valuation = 0;
                ValuationCalc1 TheInvestment = new ValuationCalc1(investment,percent, valuation);
                valuation = TheInvestment.calcVal();
                display("The value is $"+valuation);
            } else if (type == "percent"){
                investment = getInput("investment amount");
                valuation = getInput("valuation amount");
                percent =0;
                ValuationCalc1 TheInvestment1 = new ValuationCalc1(investment,percent,valuation);
                percent = TheInvestment1.calcPerc();
                display("The percent owned is "+percent);
            } else if (type == "investment"){
                valuation = getInput("valuation amount");
                percent = getInput("percent amount");
                investment = 0;
                ValuationCalc1 TheInvestment2 = new ValuationCalc1(investment,percent,valuation);
                investment = TheInvestment2.calcInv();
                display("The investment amount is "+ investment);
            } else {
                Console.WriteLine("Error");
            }
            
        }
    }
}