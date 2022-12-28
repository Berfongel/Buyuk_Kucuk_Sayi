// See https://aka.ms/new-console-template for more information
double sayi1;
double sayi2;

Console.WriteLine("Birinci sayıyı giriniz :");
sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz :");
sayi2 = Convert.ToDouble(Console.ReadLine());

if (sayi1>sayi2) 
{
    Console.WriteLine("Büyük sayı : " + sayi1);
    Console.WriteLine("Küçük sayı : " + sayi2);
}
else if (sayi1 == sayi2)
{
    Console.WriteLine("Girilen sayılar eşittir. ");
}
else 
{
    Console.WriteLine("Büyük sayı : " + sayi2);
    Console.WriteLine("Küçük sayı : " + sayi1);
}