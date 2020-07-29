using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Program
    {        
        static void Main()
        { 
            
            Train[] trainlist = 
            {
                new Train ("Москва", "Воронеж", "15", new DateTime(2020,6,21,21,20,0), new DateTime(2020,6,22,5,10,0)),
                new Train ("Москва", "Воронеж", "12", new DateTime(2020,6,21,17,00,0), new DateTime(2020,6,21,21,15,0)),
                new Train ("Москва", "Белгород", "14", new DateTime(2020,6,21,10,40,0), new DateTime(2020,6,21,18,20,0)),
                new Train ("Москва", "Казань", "13", new DateTime(2020,6,21,18,30,0), new DateTime(2020,6,22,14,00,0)),
                new Train ("Москва", "Архангельск", "11", new DateTime(2020,6,21,7,00,0), new DateTime(2020,6,23,10,15,0))
            }; 

           
            foreach(var el in trainlist) System.Console.WriteLine(el);
            Console.WriteLine();
            while(true)
            {
                Console.WriteLine("Выберите операцию :"
                                    + "\n1 - Поиск по номеру поезда."
                                    + "\n2 - Сортировать по городам прибытия."
                                    + "\n3 - Сортировать по номерам поезда."
                                   );
            
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {   
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.Write("Введите номер поезда : ");
                        string readline = Console.ReadLine();
                        Console.WriteLine( Train.ShowInformation(readline,trainlist)?? "Поезда с таким номером не существует.");
                        Console.WriteLine("Нажмите <Enter> чтобы продолжить.");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Train. SortTrainByEndPlace(trainlist);
                        Console.WriteLine("Нажмите <Enter> чтобы продолжить.");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Array.Sort(trainlist);
                        foreach (var el in trainlist) System.Console.WriteLine(el);
                        Console.WriteLine("Нажмите <Enter> чтобы продолжить.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Повторите попытку.");
                        Console.WriteLine("Нажмите <Enter> чтобы продолжить.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    
                } 
            }
        }
    }
}

