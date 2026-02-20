# Template Method Pattern

The Template Method Pattern is a behavioral pattern that defines the skeleton of an algorithm in a base class but lets subclasses override specific steps without changing the algorithm's overall structure.

Key Concept

The base class acts as a "blueprint" with a Template Method (usually sealed) that calls a series of steps. Some steps are fixed, while others are "hooks" or abstract methods meant for customization
