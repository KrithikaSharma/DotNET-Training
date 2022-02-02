using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24
{
    class Vehicle
    {
        //int engine = 0; //private
        public int engine = 0;
        public void Drive(string s)
        {
            Console.WriteLine("Message from base class {0}",s);
        }
    }

    class Car:Vehicle
    {
        //redeclaring a member or field in derived cls which is already declared in base cls 
        new int engine; // name hiding(field hiding)

        public Car(int eng)
        {
            engine = eng; //child cls
            base.engine = eng; //base cls-optional
        }

        public Car(int eng1,int eng2)
        {
            engine = eng1;
            base.engine = eng2;
        }

        public new void Drive(string str)
        {
            Console.WriteLine("Message from child(car) {0}: ",str);
            Console.WriteLine("Message of base(vehicle) from child(car): ",base.engine);
        }

        public void ShowEngineDetails()
        {
            Console.WriteLine("Engine value in the base class: {0}",base.engine);
            Console.WriteLine("Engine value in the child class: {0}",engine);
        }

    }
    class HidingDemo
    {
        static void Main()
        {
            Car car = new Car(2,5);
            car.ShowEngineDetails();
            car.Drive("Learning car driving hiding");

            Vehicle veh = new Vehicle();
            veh.Drive("Learning vehicle driving");
            Console.ReadLine();
        }
    }
}
