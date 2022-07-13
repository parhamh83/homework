//برنامه ای نویسید که معدل 10 دانشجو را بگیرد و بالاترین معدل مشروط را چاپ کند

int big=0;
for (int i = 0; i <5; i++)
{System.Console.WriteLine("please Enter your number");
   int num1=int.Parse(Console.ReadLine());
  System.Console.WriteLine("please Enter your number");
    int num2=int.Parse(Console.ReadLine());

 if (num1<10 && num2<10)
 {
    big=Math.Max(num1,num2);
 }
}
System.Console.WriteLine(big);