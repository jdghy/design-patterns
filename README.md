# Flyweight Design Pattern


The Flyweight Design Pattern is a structural pattern used to minimize memory usage by sharing common data across a large number of similar objects. Instead of storing identical data in every instance, you move it into a single shared object.

When to Use

When your application requires a vast quantity of objects.

When RAM consumption is a critical bottleneck.

When objects can be clearly split into intrinsic and extrinsic states. 

Real-World Idiom: String Interning

In .NET, the Common Language Runtime (CLR) uses the Flyweight pattern for String Interning. If you have two identical constant strings, they both point to the same reference in the "intern pool" to save memory











