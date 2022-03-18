using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {           
            int receptionTime = 10;
            int queueTime;
            int fullHours;
            int minutes;

            Console.WriteLine("Введите количество старушек ");          

            int amountOfPeople = Convert.ToInt32(Console.ReadLine());

            queueTime = receptionTime * amountOfPeople;

            fullHours = queueTime / 60;
            minutes = queueTime  % 60;

            Console.WriteLine("Время в очереди: " + fullHours + " часов, " + minutes + " минут " );
        }
    }
}
