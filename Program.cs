using System;

namespace VehicleProject
{
    
    public class Vehicle
    {
        
        protected int speed;

        
        public Vehicle(int speed)
        {
            this.speed = speed;
        }

        
        public void Start()
        {
            Console.WriteLine($"Авто посинає їхати швидкість: {speed} км/год.");
        }
    }

    
    public class Car : Vehicle
    {
        
        public Car(int speed) : base(speed)
        {
        }

        
        public new void Start()
        {
            Console.WriteLine($"Автомобіль стартує з швидкістю: {speed} км/год.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle genericVehicle = new Vehicle(40);
            Console.WriteLine("--- Виклик методу для Vehicle ---");
            genericVehicle.Start();

            
            Car myCar = new Car(100);
            Console.WriteLine("\n--- Виклик методу для Car (через посилання типу Car) ---");
            myCar.Start();

            
            Vehicle carAsVehicle = new Car(120);
            Console.WriteLine("\n--- Виклик методу через посилання типу Vehicle на об'єкт Car ---");
            carAsVehicle.Start();
        }
    }
}