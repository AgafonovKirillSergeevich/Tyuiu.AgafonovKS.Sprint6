using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AgafonovKS.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (x!= 0)
                {
                    y = Math.Round(Math.Sin(x) + (Math.Cos(2*x) / 2) - 1.5 * x, 2);
                }
                else
                {

                    y = 0;
                }

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
