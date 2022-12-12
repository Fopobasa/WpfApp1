using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Calc
    {
        public double StraightSkirt(double itemLength)
        {
                return itemLength*2+0.2;
        }
        public double Trousers(double waist, double hip, double itemLength)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108))
            {
                return itemLength + 0.2+0.5;
            }
            else
            {
                return itemLength + 0.5 + 0.7;
            }
        }
        public double StraightDress(double waist, double hip, double itemLength, double sleeveLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108)||(chest >= 86 && chest <= 102))
            {
                return itemLength*2+sleeveLength + 0.4;
            }
            else
            {
                return itemLength *4+sleeveLength + 0.4;
            }
        }
        public double FlaredSkirt(double itemLength)
        {
            return itemLength * 4 + 0.2;
        }

        public double FlaredDress(double itemLength, double sleeveLength)
        {
                return itemLength * 4 + sleeveLength + 0.4;
        }
 
        public double StraightSundress(double waist, double hip, double itemLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108) || (chest >= 86 && chest <= 102))
            {
                return itemLength + 0.3;
            }
            else
            {
                return itemLength * 2 + 0.3;
            }
        }
        public double FlaredSundress(double itemLength)
        {
                return itemLength * 2 + 0.2;
        }

        public double Blouse(double waist, double itemLength, double sleeveLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (chest >= 86 && chest <= 102))
            {
                return itemLength + sleeveLength+ 0.5;
            }
            else
            {
                return itemLength*2 + sleeveLength + 0.5;
            }
        }
        public double Jacket(double waist, double itemLength, double sleeveLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (chest >= 86 && chest <= 102))
            {
                return itemLength + sleeveLength + 0.4;
            }
            else
            {
                return itemLength * 3 + sleeveLength*2 + 0.6;
            }
        }
        public double Top(double itemLength)
        {
            return itemLength +0.2;
        }
        public double Jumpsuit(double waist, double hip, double itemLength, double sleeveLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108) || (chest >= 86 && chest <= 102))
            {
                return itemLength + sleeveLength + 0.4;
            }
            else
            {
                return itemLength * 4 + sleeveLength + 0.9;
            }
        }
        public double Vest(double waist, double itemLength, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (chest >= 86 && chest <= 102))
            {
                return itemLength*2 +  0.3;
            }
            else
            {
                return itemLength * 3 +  0.6;
            }
        }
        public double StraightCoat(double waist, double hip, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108) || (chest >= 86 && chest <= 102))
            {
                return 5.8;
            }
            else
            {
                return 6.4;
            }
        }
        public double FlaredCoat(double waist, double hip, double chest)
        {
            if ((waist >= 66 && waist <= 82) || (hip >= 92 && hip <= 108) || (chest >= 86 && chest <= 102))
            {
                return 6.5;
            }
            else
            {
                return 7.5;
            }
        }
    }
        
    
}
