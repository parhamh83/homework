  //برنامه ای بنویسید که عدد را از ورودی دریافت کند و تعداد ارقام آن را چاپ کند

System.Console.WriteLine("Please Enter your Number");
string num=Console.ReadLine();
int number=int.Parse(num);

if (number<0)
{int manfi=num.Length;
  manfi--;
  System.Console.WriteLine(manfi);
}
else
{
   System.Console.WriteLine(num.Length);
}