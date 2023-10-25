using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class CalcService
    {
        public int Add(int oneNum, int twoNum)
        {
            return oneNum + twoNum;
        }

        public int Subtract(int oneNum, int twoNum)
        {
            return oneNum - twoNum;
        }

        public int Multiply(int oneNum, int twoNum)
        {
            return oneNum * twoNum;
        }

        public int Divide(int oneNum, int twoNum)
        {
            if (twoNum != 0)
            {
                return oneNum / twoNum;
            }
            else
            {
                throw new ArgumentException("Не можна ділити на нуль!!");//сигналізуєте про те
                                                              //що один з аргументів вашого методу
                                                             //не вірний чи не відповідає очікуваному формату чи діапазону значень
            }
        }
    }

}
