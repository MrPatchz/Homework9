/**
 * Lab1.cs
 * Author: Jacques Zwielich
 * Module: 9
 * Homework: 9 Project 1
 * Problem Statement: Define classes that inherit the same instance variable
 * Alborithm:
 * 1. Define Document parent object
 * 2. have a string text instance variable
 * 3. Create a setText variable to set the instance variable text
 * 4. ToString object that returns a string with the text
 * 5. Define 2 Email & Fileobject derived from the Document parent object
 * 6. Overload the tostring methods in each child class
 * 7. In the main we check and make sure that the subroutine works with 4 different test objects all refering to the various child classes.
**/
using System;
using System.Buffers;

namespace Project1
{
    class Vehicle
    {
        protected enum Manufacturer
        {
            name
        }
        protected int Cylinders;
        protected Person owner;
        //Setters
        public void setCylinders (int cylinder)
        {
            this.Cylinders = cylinder;
        }
        public void setOwner (Person owner)
        {
            this.owner = owner;
        }
        //Getters
        public int getCylinders()
        {
            return this.Cylinders;
        }
        public Person getOwner()
        {
            return this.owner;
        }
    }   

    class Truck : Vehicle
    {
        protected double loadCapacity;
        protected int towingCapacity;

        public Truck(int Cylinders, Person owner, double loadCapacity, int towingCapacity)
        {
            this.Cylinders = Cylinders;
            this.owner = owner;
            this.loadCapacity = loadCapacity;
            this.towingCapacity = towingCapacity;
        }

        public enum Manufacturer
        {
            Ford,
            Honda
        }
        //Setters
        public void setLoadCapacity(double capacity)
        {
            this.loadCapacity = capacity;
        }
        public void setTowingCapacity (int tow)
        {
            this.towingCapacity = tow;
        }
        // Getter
        public double getLoadCapacity()
        {
            return loadCapacity;
        }
        public int getTowingCapacity()
        {
            return towingCapacity;
        }

        public string toString()
        {
            return "Truck[" + this.owner.ToString() + "," +
                this.Cylinders + " cylinders," +
                this.loadCapacity + " load capacity, " +
                this.towingCapacity + " towing capacity, " +
                "]";
        }

        public bool Equals(Truck otherTruck)
        {
            return (this.toString() == otherTruck.toString());
        }

    }

    public class Person
    {
        private String name;
        public Person() { this.name = "Default"; }
        public Person(string theName) { this.name = theName; }
        public Person(Person obj) { this.name = obj.GetName(); }
        public string GetName() { return this.name; }
        public void SetName(string name) { this.name = name; }
        public string ToString() { return "Owner " + this.name;  }
        public bool Equals(Person obj) {
            return this.GetName() == obj.GetName();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("bill");
            Person jim = new Person("jim");


            Truck truck1 = new Truck(4, bill, 400.00, 60);
            Truck truck2 = new Truck(6, jim, 200.00, 30);
            Console.WriteLine(truck1.toString());
            Console.WriteLine(truck2.toString());
            Console.WriteLine("Are the two trucks identical and owned by the same person? " + truck1.Equals(truck2));
            truck2.setCylinders(4);
            truck2.setLoadCapacity(400.00);
            truck2.setTowingCapacity(60);
            truck2.setOwner(bill);
            Console.WriteLine(truck1.toString());
            Console.WriteLine(truck2.toString());
            Console.WriteLine("Are the two trucks identical and owned by the same person? " + truck1.Equals(truck2));

        }
    }

    
}
