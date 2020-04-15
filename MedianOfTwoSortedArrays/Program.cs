using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            void MedianOfTwoSortedArrays(int[] a, int[] b)
            {
                int[] mergeArray = new int[a.Length + b.Length];
                int i = 0, j = 0, k = 0;

                while (i < a.Length && j < b.Length)
                {
                    if (a[i] <= b[j])
                    {
                        mergeArray[k] = a[i];
                        i++;
                    }
                    else
                    {
                        mergeArray[k] = b[j];
                        j++;
                    }
                    k++;
                }

                while (i < a.Length)
                {
                    mergeArray[k] = a[i];
                    i++;
                    k++;
                }

                while (j < b.Length)
                {
                    mergeArray[k] = b[j];
                    j++;
                    k++;
                }

                var medianIndex = (mergeArray.Length - 1) / 2;
                Console.WriteLine(mergeArray[medianIndex]);
                Console.ReadKey();

            }
            
            int[] a_Array = { 2, 5, 9 };
            int[] b_Array = { 4, 8, 10, 12 };
            MedianOfTwoSortedArrays(a_Array, b_Array);

        }

        //CAMBIO HECHO PARA VER SI SE ACTUALIZA EN GITHUB
        //SEGUNDO CAMBIO PARA VER SI SE ACTUALIZA EN GITHUB

        // muestra los elementos del array en diferentes lineas.
        //foreach (var item in a_Array)
        //{
        //    Console.WriteLine(item);
        //}

        //MUESTRA LOS ELEMENTOS DEL ARRAY EN LA MISMA LINEA SEPARADOS POR COMA.
        //Console.WriteLine(string.Join(", ", a_Array));
    }
}
