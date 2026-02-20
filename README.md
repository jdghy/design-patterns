# Strategy Design Pattern

The Strategy Design Pattern is a behavioral pattern that defines a family of interchangeable algorithms and encapsulates each one in its own class. This allows you to switch between different behaviors at runtime without modifying the code that uses them.

Key Components

Strategy Interface: Defines the signature common to all supported algorithms.

Concrete Strategies: Implement the actual algorithms using the strategy interface.

Context: Maintains a reference to a strategy object and delegates the task to it.

Strategy vs. State Pattern

While they look structurally similar, their intent differs:

Strategy is about choosing how to perform a specific task (e.g., sorting algorithms or payment methods). The client usually picks the strategy.

State is about an object's behavior changing automatically based on its internal state. Transitions are often handled internally by the state objects themselves.
