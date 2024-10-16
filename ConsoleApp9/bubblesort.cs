using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    //public delegate bool sortfunc<T1>(T1 a, T1 b);
    public delegate bool logicfunc<in T>(T x);
    class bubblesort/*<T>*/
    {

        //public static void bubllsort( T[] array,sortfunc<T> sortfunc)
        //{
        //    if(array != null)
        //    {
        //        for(int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0;j < array.Length-i-1; j++)
        //            {
        //                if (sortfunc(array[j], array[j + 1]))
        //                swap( ref array[j], ref array[j+1]);
        //            }
        //        }
        //    }
        //}

        //public static void swap <T2>(ref T2 x,ref T2 y)
        //{
        //   T2 temp=x;
        //    x=y;
        //    y=temp;
        //}
        public static List<T> getelmentbyallpramters<T>( List<T> elment,logicfunc<T> logicfunc)
        {
            List<T> result = new List<T>();
            if(elment != null)
            {
                for(int i = 0; i < elment.Count; i++)
                {
                    if (logicfunc(elment[i])==true)
                    result.Add(elment[i]);
                }
            }

            return result;
        }

    }
    //    class comparefuncton
    //    {
    //        public static bool funcgrt( int x, int y)
    //        {
    //            return x < y;
    //        }
    //        public static bool funcless( int x,  int y)
    //        {
    //            return x > y;
    //        }
    //        public static bool funcgrtstring(string x, string y)
    //        {
    //            return x?.Length < y?.Length;
    //        }
    //        public static bool funclessstring(string x, string y)
    //        {
    //            return x?.Length > y?.Length;
    //        }
    //    }

    class logicfunction
    {
        public static bool elmentodd(int number) { return number % 2 == 0; }
        public static bool elmenteven(int number) { return number % 2 == 1; }
        public static bool getelmentlfour(string name) { return name.Length > 4; }
    }
}
