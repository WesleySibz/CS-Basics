using System;

namespace Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A class is a blueprint for the object. 
            Before we create an object, we first need to define the class.
            We can think of the class as a sketch (prototype) of a house. 
            It contains all the details about the floors, doors, windows, etc. 
            Based on these descriptions we build the house. House is the object.
            Since many houses can be made from the same description,
            we can create many objects from a class.

            Create a class in C#:
            We can create a class in Java using the class keyword. 
            For example:
            class ClassName {
            // fields 
            // methods
            }
             */

        }
    }
    class Bicycle
    {

        // state or field
        private int gear = 5;

        // behavior or method
        public void braking()
        {
           Console.WriteLine("Working of Braking");
        }
        /*
         In the above example, we have created a class named Bicycle.
        It contains a field named gear and a method named braking().
        Here, Bicycle is a prototype. 
        Now, we can create any number of bicycles using the prototype. 
        And, all the bicycles will share the fields and methods of the prototype.

        An object is called an instance of a class.
        For example, suppose Bicycle is a class then MountainBicycle,
        SportsBicycle, TouringBicycle, etc can be considered as objects of the class.

        className object = new className();
        
        // for Bicycle class
        Bicycle sportsBicycle = new Bicycle();
        
        Bicycle touringBicycle = new Bicycle();

        We have used the new keyword along with the constructor of the class 
        to create an object. Constructors are similar to methods and have the 
        same name as the class. For example, Bicycle() is the constructor of 
        the Bicycle class. To learn more, visit Java Constructors.
        Here, sportsBicycle and touringBicycle are the names of objects. 
        We can use them to access fields and methods of the class.
        As you can see, we have created two objects of the class. 
        We can create multiple objects of a single class in C#.

        We can use the name of objects along with the . 
        operator to access members of a class. For example:

        class Bicycle {

          // field of class
          int gear = 5;

          // method of class
          void braking() {
            ...
          }
        }

        // create object
        Bicycle sportsBicycle = new Bicycle();

        // access field and method
        sportsBicycle.gear;
        sportsBicycle.braking();

        Here, we have created an object of Bicycle named sportsBicycle. 
        We then use the object to access the field and method of the class.
        sportsBicycle.gear - access the field gear
        sportsBicycle.braking() - access the method braking()
         */

    }

}
