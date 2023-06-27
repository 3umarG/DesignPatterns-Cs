# Design Patterns in C#

This repository contains various types of design patterns implemented in C#. The design patterns are categorized into three main types: Creational, Structural, and Behavioral. Each category consists of several subtypes, providing a comprehensive collection of design patterns.

- [Creational Design Patterns](#creational-design-patterns)
- [Structural Design Patterns](#structural-design-patterns)
- [Behavioral Design Patterns](#behavioral-design-patterns)

## Creational Design Patterns

Creational design patterns focus on object creation mechanisms, providing flexible and reusable ways to create objects.

- [Singleton Pattern](#singleton-pattern)

...

## Structural Design Patterns

Structural design patterns focus on how objects and classes are composed to form larger structures and provide relationships between them.

...

## Behavioral Design Patterns

Behavioral design patterns focus on communication and interaction between objects, defining how they collaborate and distribute responsibilities.

...

## Singleton Pattern

The Singleton pattern ensures that only one instance of a class is created and provides a global point of access to that instance. It is important to consider thread safety when implementing the Singleton pattern in a multi-threaded environment.

### When to Use the Singleton Pattern

The Singleton pattern is used when you need to have a single instance of a class throughout your application, ensuring global access to that instance. Some common scenarios where the Singleton pattern can be useful include:

- Managing access to shared resources, such as a database connection or a thread pool.
- Maintaining a single configuration object that should be accessible from multiple parts of the application.
- Implementing logging or caching mechanisms that need to maintain a single state.

### Problem Solved by the Singleton Pattern

The Singleton pattern solves several problems, including:

- **Global Access**: It provides a single global point of access to the instance, making it easy to access and use throughout the application.
- **Instance Control**: It ensures that only one instance of the class is created, preventing multiple instances from being created accidentally or unnecessarily.
- **Resource Sharing**: It allows sharing resources and data across multiple parts of the application without the need for explicit passing or duplication.

### Thread Safety and Locks

In a multi-threaded scenario, multiple threads may attempt to access the Singleton instance simultaneously. This can lead to race conditions and potentially create multiple instances of the Singleton class. To ensure thread safety, you can use locks to synchronize access to the instance creation process.

One approach is to use a lock statement to acquire a lock on a shared object before creating the instance. This prevents multiple threads from simultaneously executing the creation code:

```csharp
public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
        }

        return instance;
    }
}
```
another approach to solve the multi-threading safety is The double-checked locking pattern .
It is a technique that aims to improve performance by minimizing the need for lock acquisition after the instance has been created.
It avoids acquiring the lock unnecessarily once the instance has already been created.

```csharp
public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }

        return instance;
    }
}
```
