# Visitor Design Pattern


The Visitor Design Pattern is a behavioral pattern that lets you separate algorithms or new operations from the object structures on which they operate. It is unique because it allows you to add new functions to a class hierarchy without modifying the existing classes.

Core Concept: Double Dispatch

C# normally uses Single Dispatch, where the method called depends only on the runtime type of the object. The Visitor pattern enables Double Dispatch, ensuring the correct method is executed based on the runtime types of both the visitor and the element it is visiting.

When to Use

Complex Object Structures: When you need to perform an operation over an entire tree of objects (like a compiler's Abstract Syntax Tree).

Stable Hierarchy: When the element classes (Residential, Commercial) rarely change, but you frequently add new operations (Reports, Audits, Analytics).

Separation of Concerns: To keep business logic out of your data-focused classes.













