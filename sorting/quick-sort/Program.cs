using System;

// implement quick sort

namespace quick_sort
{
    public class Program
    {
        public static int partition(int[] arr, int low, int high)
        {
            //we choose Last index of arr as our PIVOT
           // int pivot = arr[arr.Length - 1];
            //or
            int pivot = arr[high];

            //Pupose of i? It keeps count of ele which are smaller than pivot. Hence, 'i' will be used to create 'n' space in array
            //to accomodate samller eles than pivot
            int i;
            //lets assume initaillay we don't have aby ele smaller than pivot, sp
            i = low - 1;

            //::::::::::::: SWAPPING CODE :::::::::::::::::::::::::::
            //now, let's travese array will start from low and loop till high. *Note: we have already taken high index as our pivot,
            //so don't loop on index high. Do (high -1)
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    //now swap two elem
                    //swap arr[j] with idex of i
                    int temp = arr[i];
                     arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            //create space for pivot using i as well now pivot to be swapped. any ele greater than pivot should be swapped
            i++;
            int tempswap = arr[i];
            arr[i] = pivot;
            arr[high] = tempswap;
            return i;
        }
        /// <summary>
        /// This function implement Quick sort and it's an recursive function
        /// it accepts array, it's starting index (low) and end index(high)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QuickSort(int[] arr, int low, int high)
        {
            //* IMPORTANT CONDITION (low < high) quick sort| low should always be less then high otherwise no sort
            if(low< high)
            {
                // 1. find a pivot | create a function for that
                // it is callled 'partition', it is a stepni function for quick sort which does it's work of partioning arr using pivot
                // last ele is our pivot. All ele smaller tan pivot is in left side and greator is in right side
                int pivotIndex = partition(arr, low, high);

                //*************** RECURSION IS HERE *******************
                // 2. you have to sort elements now with reference to pivot
                //LEFT SIDE sorting | ele smaller than pivot
                QuickSort(arr, low, pivotIndex-1);
                //RIGHT SIDE sorting | ele larger than pivot
                QuickSort(arr,pivotIndex+1, high);
            }

        }
        public static void Main(string[] args)
        {
            int[] arr = {6,3,9,5,2,8 };
            //length of array
            int n = arr.Length;

            QuickSort(arr,0,n-1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
