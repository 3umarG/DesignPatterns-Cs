# Design Patterns in C#

This repository contains various types of design patterns implemented in C#. The design patterns are categorized into three main types: Creational, Structural, and Behavioral. Each category consists of several subtypes, providing a comprehensive collection of design patterns.

- [Creational Design Patterns](#creational-design-patterns)
- [Structural Design Patterns](#structural-design-patterns)
- [Behavioral Design Patterns](#behavioral-design-patterns)

## Creational Design Patterns

Creational design patterns focus on object creation mechanisms, providing flexible and reusable ways to create objects.

- [Singleton Pattern](#singleton-pattern)
- [Prototype Pattern](#prototype-pattern)

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
## Prototype Pattern

The Prototype pattern allows you to create new objects by cloning existing objects. It provides a way to create objects based on an existing instance, thereby avoiding the need for explicitly creating objects from scratch.

### When to Use the Prototype Pattern

The Prototype pattern is useful in the following scenarios:

- When creating new objects is resource-intensive or time-consuming, and you want to avoid the overhead of creating objects from scratch.
- When you need to create multiple variations of an object and want to avoid the complexity of subclassing.
- When you want to isolate the client code from the concrete classes of objects it works with, by working with interfaces or abstract classes.

### Problem Solved by the Prototype Pattern

The Prototype pattern solves several problems, including:

- **Creating Objects**: It provides an alternative way to create new objects by cloning existing objects, reducing the need for complex object creation logic.
- **Variations and Configurations**: It allows you to create multiple variations or configurations of objects by modifying a base prototype, avoiding the need for subclassing.
- **Isolating Client Code**: It decouples the client code from the concrete classes of objects it works with, promoting flexibility and maintainability.

### Deep Clone vs. Shallow Clone

When cloning objects using the Prototype pattern, there are two main approaches: deep clone and shallow clone. The choice between the two depends on the requirements and characteristics of the objects being cloned.

- **Deep Clone**: In a deep clone, not only the object itself is cloned, but all the objects referenced by that object are recursively cloned as well. This results in creating completely independent copies of the original object and its referenced objects.

``` csharp
public abstract class Prototype
{
    public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
    public override Prototype Clone()
    {
        // Perform a deep clone
        return new ConcretePrototype();
    }
}

```

- **Shallow Clone**: In a shallow clone, only the object itself is cloned, but the objects referenced by that object are not cloned. Instead, the references to those objects are copied, resulting in multiple objects referring to the same underlying object.

``` csharp
public abstract class Prototype
{
    public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
    public override Prototype Clone()
    {
        // Perform a shallow clone
        return (Prototype)this.MemberwiseClone();
    }
}

```

The choice between deep clone and shallow clone depends on the specific requirements and considerations of your application. If you need independent copies of all objects, including referenced objects, deep clone is suitable. However, if you want multiple objects to share the same referenced objects, shallow clone can be used.
