using Singleton_NonThreadSafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_NonThreadSafe
{
    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.

    // EN : The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed class Singleton
    {
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() { }

        // The Singleton's instance is stored in a static field. There there are
        // multiple ways to initialize this field, all of them have various pros
        // and cons. In this example we'll show the simplest of these ways,
        // which, however, doesn't work really well in multithreaded program.
        private static Singleton? _instance;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void someBusinessLogic()
        {
            // ...
        }
    }


}

// Note: The above code is a simple implementation of the Singleton design pattern in C#.  

//Applicability
    //Use the Singleton pattern when a class in your program should have just a single instance available to all clients; for example, a single database object shared by different parts of the program.

    //The Singleton pattern disables all other means of creating objects of a class except for the special creation method.This method either creates a new object or returns an existing one if it has already been created.

    //Use the Singleton pattern when you need stricter control over global variables.

    //Unlike global variables, the Singleton pattern guarantees that there’s just one instance of a class. Nothing, except for the Singleton class itself, can replace the cached instance.

//All implementations of the Singleton have these two steps in common:

    //Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
    //Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field.All following calls to this method return the cached object.

// The above implementation is not thread-safe. In a multithreaded environment, two threads can call the GetInstance method at the same time, creating two instances of the Singleton class. To make it thread-safe, you can use locking or other synchronization techniques.

//How to Implement
    //Add a private static field to the class for storing the singleton instance.

    //Declare a public static creation method for getting the singleton instance.

    //Implement “lazy initialization” inside the static method.It should create a new object on its first call and put it into the static field.The method should always return that instance on all subsequent calls.

    //Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.

    //Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.

