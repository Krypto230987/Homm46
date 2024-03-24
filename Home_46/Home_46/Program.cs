using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = MakeTeaAsync();
            Task task2 = HeatDinnerAsync();
            Task task3 = TakeBathAsync();
            Task.WaitAll(task1, task2, task3);
            GetDressed();
            DriveToWork();
            Console.WriteLine("Общее затраченное время: {0} минут", totalTime);
            Console.ReadLine();
        }

        static int totalTime = 0;

        static async Task MakeTeaAsync()
        {
            await Task.Delay(100 * 5);
            totalTime += 5;
            Console.WriteLine("Поставил чайник на плиту: {0} минут", 5);
        }

        static async Task HeatDinnerAsync()
        {
            await Task.Delay(100 * 5);
            totalTime += 5;
            Console.WriteLine("Подогрел ужин: {0} минут", 5);
        }

        static async Task TakeBathAsync()
        {
            await Task.Delay(100 * 15);
            totalTime += 15;
            Console.WriteLine("Принял ванну: {0} минут", 15);
        }

        static void GetDressed()
        {
            Thread.Sleep(100 * 5);
            totalTime += 5;
            Console.WriteLine("Оделся: {0} минут", 5);
        }

        static void DriveToWork()
        {
            Thread.Sleep(100 * 55);
            totalTime += 55;
            Console.WriteLine("Ехал на работу: {0} минут", 55);
        }
    }
}