using System;

namespace binary_search
{
    public class BinarySearch
    {
        /*
         * BINARY Search is implemented on a sorted array
         * Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering the whole array. 
         * If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half.
         * Otherwise, narrow it to the upper half. Repeatedly check until the value is found or the interval is empty. 
         * Best Time complexity is o(1)
         * worst Time complexity is:
         *  At Iteration 1, Length of array = n
         *  At Iteration 2, Length of array = n/2
         *  At Iteration 3, Length of array = (n/2)/2 = n/(2)^2 or n/4
         *  Therefore, after Iteration k, Length of array = n/2k
         *  Now, Length of array = n/2k = 1 ; => n = 2k ; Apply log function both sides then log2 (n) = k log2 2
         *  therefore, worst complexity s O(Log n)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            int toFind = 13;
            int result = -1;
            if(arr[0] < arr[arr.Length-1])
            {
                result = BinarySearchInAscendingOrder(arr, toFind);
                Console.WriteLine("Ascending order searching gives = "+result);
            }
            else if(arr[0] > arr[arr.Length-1])
            {
                result = BinarySearchInDescendingOrder(arr, toFind)
                Console.WriteLine("Ascending order searching gives = " + result);
            } else
            {
                Console.WriteLine("All elements of array are same!!");
            }
        }

        private static int BinarySearchInDescendingOrder(int[] arr, int target)
        {
            //1. Define start and end
            int start = 0;
            int end = arr.Length - 1;

            //2. traverse array until you don't reach the End
            while(start <= end)
            {
                //3. Find mid value
                int mid = start + (end - start) / 2; 

                //4. check if mid is greater, less or equal to mid
                if (target < arr[mid])
                {
                    //when target is small search in right side
                    start = mid + 1;
                } else if (target > arr[mid])
                {
                    // when target is large search in left side
                    end = mid - 1;
                } else
                {
                    // we found the element!! when mid and element is same
                    return arr[mid];
                }
            }

            return -1;
        }

        private static int BinarySearchInAscendingOrder(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            // check if array length
            if (arr.Length < 1)
            {
                return -1;
            }

            // traverse array untill until you are at last element
            while (start <= end)
            {
                //1. find the middle element (start + end)/2
                int mid = start + (end - start) / 2;

                // 2. check if tagert is greater of smaller then mid
                if ( target < arr[mid])
                {
                    // here, target is smaller then mid, so will keep breaking first half unitl mid is target
                    // set end to one element before mid 
                    end = mid - 1;
                    // start = 0, start will be zero only, no need to explicitly set it
                }
                else if (target > arr[mid])
                {
                    // set start to one element after mid
                    start = mid + 1;
                    //end = arr.Length - 1;
                }else {
                    // if mid is the target element, directly return from here
                    return arr[mid];
                }
            }

            //if nothing has returned in while loop means element doesn't exists
            return -1;
        }
    }
}
