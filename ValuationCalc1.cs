using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessValuationCalculator
{
    class ValuationCalc1
    {
        public double investment;
        public double percent;
        public double valuation;

        public ValuationCalc1(){
            investment = 0;
            percent = 0;
            valuation =0;
        }

        public ValuationCalc1(double a, double b, double c){
            investment = a;
            percent = b;
            if(percent <1){
                percent = b*100;
            } else {
                percent = b;
            }
            valuation =c;
        }
        public double calcVal(){
            valuation = (100/percent)*investment;
            return valuation;
        }
        public double calcPerc(){
            percent = investment/valuation*100;
            return percent;
        }
        public double calcInv(){
            investment = percent*valuation/100;
            return investment;
        }


    }
}