# Singleton
- Singleton pattern is a software design pattern that restricts the instantiation of a class to one "single" instance

# When to use
If you have some resource that

(1) can only have a single instance, and

(2) you need to manage that single instance,

you need a singleton.
There aren't many examples. A log file is the big one. You don't want to just abandon a single log file. You want to flush, sync and close it properly.
This is an example of a single shared resource that has to be managed.

# Advantages of Singleton Design Pattern 
- It provides a single point of access to a particular instance, so it is easy to maintain.

# Disadvantages of Singleton Design Pattern
- They make unit testing very hard. They introduce global state to the application. The problem is that you cannot completely isolate classes dependent on singletons. 
  When you are trying to test such a class, you inevitably test the Singleton as well
- They are generally used as a global instance, why is that so bad? Because you hide the dependencies of your application in your code, instead of exposing them through the interfaces. 
  Making something global to avoid passing it around is a code smell.

# Singleton class vs. Static methods
The following compares Singleton class vs. Static methods,
- A Static Class cannot be extended whereas a singleton class can be extended.
- A Static Class cannot be initialized whereas a singleton class can be.
- A Static class is loaded automatically by the CLR when the program containing the class is loaded.
