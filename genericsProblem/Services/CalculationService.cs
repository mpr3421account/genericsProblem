using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsProblem.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable//método com o tipo T genérico precisa ser comparável (IComparable Interface)
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
                {
                for (int i = 1; i < list.Count; i++)

                    if (list[i].CompareTo(max) > 0)//operação genérica tipo T utilizando a interface IComparable
                    {
                        max = list[i];
                    }
            }
            return max;
        }
    }
}

