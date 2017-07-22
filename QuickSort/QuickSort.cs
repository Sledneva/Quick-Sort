using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        public static int[] Parse(string input)
        {
            string[] arr = input.Split(' ', ',', '.');
            int[] num = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                num[i] = int.Parse(arr[i]);
            return num;
        }
      
        public static int QuickSort1(int[] mas, int l, int r, ref int counter)
        {
            int temp;
            int x = mas[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных 
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle 
            while (i <= j)
            {
                while (mas[i] < x) i++;
                while (mas[j] > x) j--;

                if (i <= j)
                {
                    temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    i++;
                    j--;
                }
                counter++;
            }
            if (i < r)
            {
                QuickSort1(mas, i, r, ref counter);
                counter++;
            }


            if (l < j)
            {
                QuickSort1(mas, l, j, ref counter);
                counter++;
            }
            return counter++;
        }
        //public static int quickSort2(int[] mas, int l, int r, int counter)
        //{
        //    int temp;
        //    counter = 0;
        //    int x = mas[l + (r - l) / 2];
        //    //запись эквивалентна (l+r)/2, 
        //    //но не вызввает переполнения на больших данных 
        //    int i = l;
        //    int j = r;
        //    //код в while обычно выносят в процедуру particle 
        //    while (i <= j)
        //    {
        //        while (mas[i] < x) i++;
        //        while (mas[j] > x) j--;

        //        if (i <= j)
        //        {
        //            counter++;
        //            temp = mas[i];
        //            mas[i] = mas[j];
        //            mas[j] = temp;
        //            i++;
        //            j--;
        //        }
        //        counter4++;
        //    }
        //    if (i < r)
        //    {
        //        quickSort2(mas, i, r, counter);
        //        counter4++;
        //    }

        //    if (l < j)
        //    {
        //        quickSort2(mas, l, j, counter);
        //        counter4++;
        //    }
        //    return counter4;
        //}
    }
}
