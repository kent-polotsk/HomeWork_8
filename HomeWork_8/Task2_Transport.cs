using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    internal abstract class Transport
    {
        protected Engine engine = new Engine();
        public string Type { get; set; }
        public string Moving { get; set; }
        protected string TransportClass { get; set; }

        public abstract void Move();
        public abstract void Stop();
    }

    internal class Engine
    {
        public int CylinderCount;
        protected string IsRunning;
        internal string FuelType;
        
        public Engine() 
        {
            CylinderCount = 4;
            IsRunning = "остановлен";
            FuelType = "Бензин";
        }
        public Engine(string fuelType,int cylinderCount)
        {
            CylinderCount = cylinderCount;
            IsRunning = "остановлен";
            FuelType = fuelType;
        }
        public void Start(string transport, string trClass)
        {
            if (IsRunning == "запущен") Console.WriteLine("Двигатель уже запущен");
            else
            {
                IsRunning = "запущен";
                Console.WriteLine($"{CylinderCount}-цилиндровый двигатель {transport} {trClass} {IsRunning}, для работы потребляет {FuelType}");
            }
        }
        public void Stop(string transport, string trClass)
        {
            if (IsRunning == "остановлен") Console.WriteLine("Двигатель уже остановлен");
            else
            {
                IsRunning = "остановлен";
                Console.WriteLine($"Двигатель {transport} {trClass} {IsRunning}");
            }

        }
    }

    internal class Car : Transport
    {
        public const string MoveType = "едет по дороге";
        

        internal Car() 
        {
            TransportClass = "автомобиль";
            Type = "Легковой";
            engine.CylinderCount = 4;
            engine.FuelType = "Бензин";
        }
        internal Car(int count)
        {
            TransportClass = "автомобиль";
            Type = "Легковой";
            engine.CylinderCount = count;
            engine.FuelType = "Бензин";
        }
        internal Car(string type, int count, string fuelType)
        {
            TransportClass = "автомобиль";
            Type = type;
            engine.CylinderCount = count;
            engine.FuelType = fuelType;
        }

        public override void Move()
        {
            if (Moving == "движется") Console.WriteLine($"{Type} {TransportClass} УЖЕ движется");
            else
            {
                engine.Start(Type, TransportClass);
                Moving = "движется";
                Console.WriteLine($"{Type} {TransportClass} {MoveType}");
            }

        }
        public override void Stop()
        {
            if (Moving == "не движется") Console.WriteLine($"{Type} {TransportClass} УЖЕ не движется");
            else
            {
                Console.WriteLine($"{Type} {TransportClass} останавливается");
                engine.Stop(Type, TransportClass);
                Moving = "не движется";
            }
        }
    }
    class Plane : Transport
    {
        public const string MoveType = "летит по воздуху";

        internal Plane()
        {
            TransportClass = "самолет";
            Type = "Пассажирский";
            engine.CylinderCount = 4;
            engine.FuelType = "Бензин";
        }
        internal Plane(int count)
        {
            TransportClass = "самолет";
            Type = "Пассажирский";
            engine.CylinderCount = count;
            engine.FuelType = "Бензин";
        }
        internal Plane(string type, int count, string fuelType)
        {
            TransportClass = "самолет";
            Type = type;
            engine.CylinderCount = count;
            engine.FuelType = fuelType;
        }

        public override void Move()
        {
            if (Moving == "движется") Console.WriteLine($"{Type} {TransportClass} УЖЕ движется");
            else
            {
                engine.Start(Type, TransportClass);
                Moving = "движется";
                Console.WriteLine($"Самолет выхдит на взлетно-посадочную полосу.");
                Console.WriteLine($"Самолет взлетает и набирает высоту.");
                Console.WriteLine($"{Type} {TransportClass} {MoveType}");
            }

        }
        public override void Stop()
        {
            if (Moving == "не движется") Console.WriteLine($"{Type} {TransportClass} УЖЕ не движется");
            else
            {
                Console.WriteLine($"{Type} {TransportClass} замедляется и снижается.");
                Console.WriteLine($"Самолет приземляется и тормозит на взлетно-посадочной полосе.");
                engine.Stop(Type, TransportClass);
                Moving = "не движется";
            }
        }
    }
}
