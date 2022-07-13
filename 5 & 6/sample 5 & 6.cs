//برنامه ای بنویسید که 10 معدل از دانشجو بگیرد و میانگین نمزات بالای 15 را حساب کند

int sum=0;
int number2=0;
int final=0;
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("please Enter your number") ;
    int num=int.Parse(Console.ReadLine());
    
    if ( num>=15 )
    {
    sum=sum+num;
    number2++;
    final=sum/number2;
    }
}System.Console.WriteLine(final);