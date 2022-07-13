//برنامه ای بنویسید که عددی را از ورودی دریافت کند و مجموع یک تا عدد را حساب کند

int Number=0;
System.Console.WriteLine("Please Enter your Number");
int num=int.Parse(Console.ReadLine());

for (int i = 0; i <=num; i++)
{
    Number=Number+i;
    
}System.Console.WriteLine(Number);