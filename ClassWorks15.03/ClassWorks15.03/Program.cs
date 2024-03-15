
//int[] nums = { 2, 100, 4, 34, 1,56, 13 };
//int max = 0;
//int min = 0;


//for (int i = 1; i < nums.Length; i++)
//{
//    if (nums[max] < nums[i])
//    {
//        max = i;
//    }
//    if (nums[min] > nums[i])
//    {
//        min = i;
//    }
//}

//nums[max] +=nums[min];
//nums[min] = nums[max] - nums[min];
//nums[max] = nums[max] - nums[min];

////int save = nums[max];
////nums[max] = nums[min];
////nums[min] = save;


//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//Console.WriteLine(nums);


//bool ard = true;
//int num = Convert.ToInt32(Console.ReadLine());
//int count = -1;


//for( int i = 1; ard; i *= 2)
//{ 
//    count++;
//    if (num == i)
//    {
//        Console.WriteLine(count);
//        ard = false;
//    }
//    else if (num < i)
//    {
//        if (num - i / 2 < i - num)
//        {
//            Console.WriteLine(count-1);
//            ard = false;
//        }
//        else
//        {
//            Console.WriteLine(count);
//            ard = false;
//        }
//    }
//}



int[] arr = { 23, 12, 50, 7, 49,1039 };
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 2; j*j <= arr[i]; j++)
    {
        if (arr[i]%j==0)
        {
            count++;
            break;
        }
    }
}

Console.WriteLine(count);