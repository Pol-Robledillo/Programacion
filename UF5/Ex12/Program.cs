using System;
using System.Collections;
namespace ActividadesUF5
{
    public class Ex11
    {
        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            nums.RemoveAll(x => x > 6);
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}