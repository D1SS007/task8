using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {           
            int receptionTime = 10;
            int queueTime;
            int hoursInQueue;
            int minutesInQueue;
            int minutesInHour = 60;

            Console.WriteLine("Введите количество старушек ");          

            int amountOfPeople = Convert.ToInt32(Console.ReadLine());

            queueTime = receptionTime * amountOfPeople;

            hoursInQueue = queueTime / minutesInHour;
            minutesInQueue = queueTime  % minutesInHour;

            Console.WriteLine("Время в очереди: " + fullHours + " часов, " + minutes + " минут " );
        }
    }
}
