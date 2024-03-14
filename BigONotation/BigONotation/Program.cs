
int num = 3571;
bool result=false;

int step = 0;

for (int i = 2; i*i < num; i++)
{
    step++;
    if (num%i==0)
    {
       result=true;
        break;
    }
    
}

if (result)
{
    Console.WriteLine("Eded murekkeb");
}
else
{
    Console.WriteLine("Eded sadedir");
}

Console.WriteLine(step);
