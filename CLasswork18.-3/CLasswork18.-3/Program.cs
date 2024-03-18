namespace CLasswork18._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, 15, 20, 5, 7 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
              
                if (CheckNum(arr[i]))
                {
                    count++;
                }
            }


            Console.WriteLine(count);
        }

        public static bool CheckNum(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return true;
                }
            }
            return false;
            //if (num%2==0)
            //{
            //    return true;
            //}
            //return false;

        }

       
    }
}