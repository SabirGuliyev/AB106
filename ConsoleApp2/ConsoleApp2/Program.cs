
//int num = 123;

//int first = num;
//int second = num;
//int temp = 0;
//int count=0;
//bool result = false;
//while (first!=0)
//{
//    temp = first % 10;
//    while (second!=0) //9  9   temp=9
//    {
//        if (temp==second%10)
//        {
//            count++;
//        }
//        second/=10;
//    }

//    if (count>1)
//    {
//        result = true;
//        break;
//    }
//    count=0;
//    first /= 10;
//    second = num;

//}


//if (result)
//{
//    Console.WriteLine("Tekrarlanir");
//}
//else
//{
//    Console.WriteLine("yoxdur");
//}





//int first = 12344;

//bool result = false;

//while (first != 0)
//{
//    int temp = first % 10;
//    int second = first / 10;
//    while (second != 0)
//    {
//        if (temp == second % 10)
//        {
//            result = true;
//            break;
//        }
//        second /= 10;
//    } 
//    first /= 10; 
//}


//if (result)
//{
//    Console.WriteLine("Tekrarlanir");
//}
//else
//{
//    Console.WriteLine("yoxdur");
//}


//1)
//for (int i = 1; i < 90; i++)
//{
//    if (i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}




int a = 40;
int b = 5;
if (a > b)
{
    a += b;
    b = a - b;
    a = a - b;

}

for (int i = a; i < b; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}


