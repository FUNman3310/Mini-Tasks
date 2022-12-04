using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task2
{
    public class CustomList<T>
    {

        public T[] values = new T[0];

        public void Add(T value)
        {
            Array.Resize(ref values, values.Length+1);
            values[^1] = value;
        }

        public void Clean()
        {
            T[] newValues = new T[0];
            values = newValues;
        }

        public int FindIndexOf(T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (value==values[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool  Equals (this T value1,T value2)
        {
            if (value1 == value2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
 
    }
}
