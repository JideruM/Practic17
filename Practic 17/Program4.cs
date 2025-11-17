using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_17._4
{
    class Vector
    {
        //Массив чисел
        private double[] values;

        //Конструктор
        public Vector(params double[] elements)
        {
            values = new double[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                values[i] = elements[i];
            }
        }

        //Индексатор
        public double this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }

        public static double operator *(Vector v1, Vector v2)
        {
            double result = 0;
            for (int i = 0; i < v1.values.Length; i++)
            {
                result += v1.values[i] * v2.values[i];
            }
            return result;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ",values) + "]";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);

        }
    }
}
