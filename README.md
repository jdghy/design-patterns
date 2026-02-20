# Command Design Pattern

The Command Design Pattern is a behavioral pattern that turns a request into a standalone object. This transformation allows you to pass requests as arguments, queue them for later execution, or store them in a history for undo/redo operations.

Key Participants:

Command Interface: Declares a method (usually Execute()) for carrying out the action.

Concrete Command: Implements the interface and links the Receiver to a specific action.

Receiver: The class that contains the actual business logic to perform the work.

Invoker: The object that triggers the command's execution (e.g., a button or a remote control).
