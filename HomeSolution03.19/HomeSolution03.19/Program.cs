namespace HomeSolution03._19
{
    internal class Program
    {
        static void Main()
        {
            #region HomeSolution
            //int[] nums = { 5, 3, 77, 12, 1 };

            //Console.WriteLine(Min(nums));

            /////////////////////////////////////////////////////////////////
            //Console.WriteLine("cevrenin sahesi=" + Area(2));
            //Console.WriteLine("duzbucaqlinin sahesi=" + Area(3, 5));
            //Console.WriteLine("duzbucaqli paralepipedin sahesi=" + Area(3, 5, 2));
            //Console.WriteLine("ucbucaqin daxiline cekilmis cevre=" + Area(3, 4, 5, 2));

            //Console.WriteLine(Area(5)); 
            #endregion

            //int num = 2;
            //Power(ref num, 3);

            //Console.WriteLine(num);

            int[] arr = { 1, 2, 3 };
            Resize(ref arr,20);
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
                  
        public static void Resize(ref int[] arr,int num)
        {
            int[] newArr = new int[arr.Length + 1];


            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = num;
            arr = newArr;
        }



        
        public static void Power(ref int num,int pow=2)
        {
            int multiple = num;

            for (int i = 1; i < pow; i++)
            {
                num *= multiple;
            }
           
        }

        #region Home methods
        public static int Area(int r)
        {
            int p = 3;
            int areaofcircle = p * r * r;
            return areaofcircle;
        }

        public static int Area(int a, int b)
        {
            int areaofduzbucaqli = a * b;
            return areaofduzbucaqli;
        }

        public static int Area(int a, int b, int c)
        {
            int area = 2 * (a * b + b * c + a * c);
            return area;
        }
        public static float Area(float a, float b, float c, float r)
        {
            float p = (a + b + c) / 2;
            float area = p * r;
            return (float)area;
        }
        ////////////////////////////////
        public static int Min(int[] arr)
        {


            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            return min;
        } 
        #endregion

    }
}
