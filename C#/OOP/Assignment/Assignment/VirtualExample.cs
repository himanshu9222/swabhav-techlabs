using System;

    class Program
    {
        static void Main(string[] args)
        {
            double distance, hour, fuel = 0.0;
            Console.WriteLine("Enter the Distance");
            distance = Double.Parse(Console.ReadLine());
            Console.WriteLine(distance);
            
            Console.WriteLine("Enter the Hours");
            hour = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Fuel");
            fuel = Double.Parse(Console.ReadLine());
            
            Car objCar = new Car(distance, hour, fuel);
            Vehicle objVeh = objCar;
            
            objCar.Average();
            objVeh.Average();
            objCar.Speed();
            objVeh.Speed();
            Console.Read();
        }
    }

