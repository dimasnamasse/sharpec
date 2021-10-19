using System;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] nums = new int[4];
                Console.WriteLine(nums[5]);


            }
            catch
            {

                Console.WriteLine("Возникло исключение");
            }

            
              
        }
    }
}
