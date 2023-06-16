using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{ 
    public class FindMax<T>
    {
        public T value1, value2, value3;
        public FindMax(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T MaximumUsingGenerics<T>(T value1, T value2, T value3) where T : IComparable
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0 ||

                value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) > 0 ||

                value1.CompareTo(value2) > 0 && value1.CompareTo(value3) >= 0)
            {
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0 ||

                 value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) > 0 ||

                 value2.CompareTo(value1) > 0 && value2.CompareTo(value3) >= 0)
            {
                return value2;
            }

            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0 ||

                 value3.CompareTo(value1) >= 0 && value3.CompareTo(value2) > 0 ||

                 value3.CompareTo(value1) > 0 && value3.CompareTo(value2) >= 0)
            {
                return value3;
            }

            return default;
        }
        //integer
        //public static int Maximum(int num1, int num2, int num3)
        //{
        //  if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||

        //        num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||

        //       num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
        //  {
        //       return num1;
        //  }
        //  if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||

        //     num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||

        //     num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
        //  {
        //        return num2;
        //  }

        //  if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||

        //      num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||

        //      num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
        //  {
        //       return num3;
        //  }

        //   return default(int);

        //}

        ////float
        //public static float Maximumfloat(float num1, float num2, float num3)
        //{
        //    if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||

        //        num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||

        //         num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
        //    {
        //        return num1;
        //    }
        //    if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||

        //       num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||

        //       num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
        //    {
        //        return num2;
        //    }

        //    if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||

        //       num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||

        //       num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
        //    {
        //        return num3;
        //    }

        //    return default(float);

        //}

        ////String

        //public static String MaximumString(String name1, String name2, String name3)
        //{
        //    if (name1.CompareTo(name2) > 0 && name1.CompareTo(name3) > 0 ||

        //        name1.CompareTo(name2) >= 0 && name1.CompareTo(name3) > 0 ||

        //        name1.CompareTo(name2) > 0 && name1.CompareTo(name3) >= 0)
        //    {
        //        return name1;
        //    }
        //    if (name2.CompareTo(name1) > 0 && name2.CompareTo(name3) > 0 ||

        //        name2.CompareTo(name1) >= 0 && name2.CompareTo(name3) > 0 ||

        //       name2.CompareTo(name1) > 0 && name2.CompareTo(name3) >= 0)
        //    {
        //        return name2;
        //    }

        //    if (name3.CompareTo(name1) > 0 && name3.CompareTo(name2) > 0 ||

        //       name3.CompareTo(name1) >= 0 && name3.CompareTo(name2) > 0 ||

        //        name3.CompareTo(name1) > 0 && name3.CompareTo(name2) >= 0)
        //    {
        //        return name3;
        //    }

        //    return default;


        //}

    }
}
