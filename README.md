#Note: The above code is a simple implementation of the Singleton design pattern in C#.  

#Applicability
	
	Use the Singleton pattern when a class in your program should have just a single instance available to all clients; for example, a single database object shared by different parts of the program.

    The Singleton pattern disables all other means of creating objects of a class except for the special creation method.This method either creates a new object or returns an existing one if it has already been created.

    Use the Singleton pattern when you need stricter control over global variables.

    Unlike global variables, the Singleton pattern guarantees that there’s just one instance of a class. Nothing, except for the Singleton class itself, can replace the cached instance.

#All implementations of the Singleton have these two steps in common:

    Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
    Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field.All following calls to this method return the cached object.

#The above implementation is not thread-safe. In a multithreaded environment, two threads can call the GetInstance method at the same time, creating two instances of the Singleton class. To make it thread-safe, you can use locking or other synchronization techniques.

#How to Implement

	Add a private static field to the class for storing the singleton instance.

    Declare a public static creation method for getting the singleton instance.

    Implement “lazy initialization” inside the static method.It should create a new object on its first call and put it into the static field.The method should always return that instance on all subsequent calls.

    Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.

    Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.

#Common Use Cases:

    The singleton design pattern ensures a class has only one instance and provides a global point of access to it.
    1.Logging System
    2.Database Connection
    3.Config Manager
    4.Cache Manager
    
    There are four well known ways that we can implement singleton pattern in c#
    1.Classic Singleton(also known as lazy initialization singleton)-Not Thread Safe
    2.Thread Safe Singleton(also known as double check locking singleton)
    3.Lazy Generic Singleton
    4.Static Initialization Singleton