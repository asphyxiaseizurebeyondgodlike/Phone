using System;
using System.Net.Sockets;

class Phone
{
    
    public string Model;
    public long Number;
    public double Weight;

    public void recieveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }
    public void getNumber(long number)
    {
        Console.WriteLine($"Номер звонящего {number}");
    }
    public Phone(string model, long number, double weight)
    {
        Model = model;
        Number = number;
        Weight = weight;
    }
    public Phone(string model, long number)
    {
        Model = model;
        Number = number;
    }
    public Phone()
    {
     
    }

    public void recieveCall(string name, long number)
    {

    }
    
    public void sendMessage(int len, int number)
    {
        Console.WriteLine($"Сообщение отправлено с номера {number}");
    }

}

class Program
{
    static void Main()
    {
        Phone Iphone = new Phone();
        Phone Xiaomi = new Phone();
        Phone Samsung = new Phone();

        Iphone.recieveCall("Гатс");
        Iphone.getNumber(89004769934);
        Console.WriteLine();

        Xiaomi.recieveCall("Киотака");
        Xiaomi.getNumber(89004769958);
        Console.WriteLine();

        Samsung.recieveCall("Юкино");
        Samsung.getNumber(89602691199);


    }

}