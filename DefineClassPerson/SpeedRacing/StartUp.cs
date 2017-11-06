using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    static void Main()
    {
        var count = int.Parse(Console.ReadLine());

        var cars = new List<Car>();
        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string model = input[0];
            double fuel = double.Parse(input[1]);
            double consumption = double.Parse(input[2]);

            if (!cars.Any(c => c.Model == model))
            {
                var newCar = new Car(model, fuel,consumption);
                cars.Add(newCar);
            }
        }
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var args = command.Split();
            string model = args[1];
            double distance = double.Parse(args[2]);

            var car = cars.Find(c => c.Model == model);
            var isMoved = car.Move(distance);

            if (!isMoved)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        foreach (var c in cars)
        {
            Console.WriteLine($"{c.Model} {c.Fuel:f2} {c.DistanceTravelled}");
        }
    }
}

