using System;

class Car : Vehicle
{
    public Car(double distance, double hour, double fuel)
        : base(distance, hour, fuel)
    {
    }
    public void Average()
    {
        double average = 0.0;
        average = distance / fuel;
        Console.WriteLine("Car Average is " + average);
    }

    public override void Speed()
    {
        double speed = 0.0;
        speed = distance / hour;
        Console.WriteLine("Car Speed is " + speed);
    }
}
