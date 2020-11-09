/**
 * Lab1.cs
 * Author: Jacques Zwielich
 * Module: 9
 * Homework: 9 Project 1
 * Problem Statement: Practice inheritance
 * Alborithm:
 * 1. Create a parent class called Vehicle
 * 2. Create instance variables in the parent class vehicle, manufacturer, cylinders and an owner who is a person object
 * 3. create getters and setters for all of these instance variables
 * 4. Create a child class of vehicle called Trucl
 * 5. Truck adds load capacity and towing capacity member variables 
 * 6. We create getters and setters for these as well
 * 7. Create a constructor that takes all parameters
 * 8. Create an Equals and a to string method
 * 9. Create a person class
 * 10. This only has an instance variable of name and getters and setters for it
 * 11. Person also has equals and to string methods
 * 12. Finally we create a demo showing off all of the functionality of the above classes.
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
