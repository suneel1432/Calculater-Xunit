// See https://aka.ms/new-console-template for more information
using Calculater;

Console.WriteLine("Hello, World!");

MyCalculation objMyCal = new MyCalculation();
int answer = objMyCal.Add(3, 5);  //Add(3,5);
Console.WriteLine("Addition=" + answer);

int subs = objMyCal.Sub(5, 3);  //Sub(5,3);
Console.WriteLine("Subscription =" + subs);

int multi = objMyCal.Mullti(3, 5);  //Mullti(3,5);
Console.WriteLine("Multiplication=" + multi);