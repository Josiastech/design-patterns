# Design Patterns in C#

## Singleton
Singleton is a creational design pattern that ensures that only one object of its type exists and provides a single point of access to it for any other code.

The pattern has practically the same pros and cons as global variables. Although they are very useful, they break the modularity of your code.

You cannot use a class that depends on the Singleton in another context. You will also have to take the Singleton class. Most of the time, this limitation appears during unit test creation.

## Prototype
Prototype is a creational design pattern that allows us to copy existing objects without the code depending on their classes.
