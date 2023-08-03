# Design Patterns in C#

## Description
Welcome to the Design Patterns in C# repository! This repository provides a comprehensive collection of design patterns implemented in C#. Whether you are a beginner learning about design patterns or an experienced developer looking for practical examples, this repository has got you covered.

The repository is organized into three main types of design patterns: Creational, Structural, and Behavioral. Each category contains various subtypes, allowing you to explore a wide range of design patterns and their applications.

In the Creational Design Patterns section, you'll find patterns such as Singleton, Prototype, Builder, Factory Method, and Abstract Factory. These patterns focus on object creation mechanisms, providing flexible and reusable ways to create objects based on different scenarios and requirements.

The Structural Design Patterns section covers patterns like Proxy, Adapter, Decorator, Composite, and Bridge. These patterns address the composition and structure of objects, allowing you to create complex structures and establish relationships between them.

The Behavioral Design Patterns section explores patterns such as Observer, Strategy, Command, Template Method, and State. These patterns focus on defining the interaction and communication between objects, enabling you to design flexible and maintainable systems.

Each design pattern comes with a detailed explanation, including when to use it, the problem it solves, and a code example to demonstrate its implementation. The code examples are carefully crafted to provide a clear understanding of how the patterns can be applied in real-world scenarios.

Whether you are looking to enhance your software design skills, improve code quality, or simply expand your knowledge of design patterns, this repository is a valuable resource. Feel free to explore, learn, and apply these design patterns to your own projects.

We encourage you to contribute to the repository by adding more design patterns or providing improvements to the existing ones. Your contributions can help make this repository a go-to reference for developers seeking practical examples of design patterns in C#.

Happy coding and enjoy exploring the world of design patterns!


This repository contains various types of design patterns implemented in C#. The design patterns are categorized into three main types: Creational, Structural, and Behavioral. Each category consists of several subtypes, providing a comprehensive collection of design patterns.

- [Creational Design Patterns](#creational-design-patterns)
- [Structural Design Patterns](#structural-design-patterns)
- [Behavioral Design Patterns](#behavioral-design-patterns)

## Creational Design Patterns

Creational design patterns focus on object creation mechanisms, providing flexible and reusable ways to create objects.

- [Singleton Pattern](#singleton-pattern)
- [Prototype Pattern](#prototype-pattern)
- [Builder Pattern](#builder-pattern)
- [Factory Method Pattern](#factory-method-pattern)
- [Abstract Factory Pattern](#abstract-factory-pattern)

...

## Structural Design Patterns

Structural design patterns focus on how objects and classes are composed to form larger structures and provide relationships between them.

- [Proxy Pattern](#proxy-pattern)
- [Adapter Pattern](#adapter-pattern)
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

## Builder Pattern

The Builder pattern separates the construction of an object from its representation, allowing the same construction process to create different representations.

#### When to Use the Builder Pattern

The Builder pattern is useful in the following scenarios:

- When the creation of complex objects requires step-by-step initialization or involves multiple optional parameters.
- When you want to create different representations of an object using the same construction process.
- When you want to improve readability and maintainability by providing a clear and fluent interface for object construction.

#### Problem Solved by the Builder Pattern

The Builder pattern solves several problems, including:

- **Complex Object Construction**: It provides a way to construct complex objects step by step, allowing the client code to control the construction process.
- **Flexible Object Creation**: It enables the creation of different representations of an object using the same construction process, providing flexibility and reusability.
- **Readability and Maintainability**: It improves the readability and maintainability of code by separating the construction logic from the client code and providing a clear and fluent interface for object construction.

#### Code Example

Here's an example of how the Builder pattern can be implemented in C#:

```csharp
public class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }
    public string PartC { get; set; }
}

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

public class ConcreteBuilder : IBuilder
{
    private Product product;

    public ConcreteBuilder()
    {
        product = new Product();
    }

    public void BuildPartA()
    {
        product.PartA = "Part A";
    }

    public void BuildPartB()
    {
        product.PartB = "Part B";
    }

    public void BuildPartC()
    {
        product.PartC = "Part C";
    }

    public Product GetResult()
    {
        return product;
    }
}

public class Director
{
    private IBuilder builder;

    public Director(IBuilder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}

// Usage
var builder = new ConcreteBuilder();
var director = new Director(builder);

director.Construct();
var product = builder.GetResult();
```


## Factory Method Pattern

The Factory Method pattern provides an interface for creating objects, but allows subclasses to decide which class to instantiate.

#### When to Use the Factory Method Pattern

The Factory Method pattern is useful in the following scenarios:

- When a class can't anticipate the type of objects it needs to create.
- When a class wants its subclasses to be responsible for object creation.
- When a class delegates object creation to one or more helper subclasses.

#### Problem Solved by the Factory Method Pattern

The Factory Method pattern solves several problems, including:

- **Flexible Object Creation**: It provides a way to create objects without specifying the exact class of the object being created.
- **Decoupling Object Creation**: It decouples the client code from the specific classes of objects being created, promoting flexibility and maintainability.
- **Code Extensibility**: It allows for easy extension of the object creation process by introducing new subclasses.

#### Code Example

Here's an example of how the Factory Method pattern can be implemented in C#:

```csharp
public interface IProduct
{
    string Operation();
}

public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "ConcreteProductA";
    }
}

public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "ConcreteProductB";
    }
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();
        return "Creator: " + product.Operation();
    }
}

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

// Usage
var creatorA = new ConcreteCreatorA();
var productA = creatorA.SomeOperation(); // Output: "Creator: ConcreteProductA"

var creatorB = new ConcreteCreatorB();
var productB = creatorB.SomeOperation(); // Output: "Creator: ConcreteProductB"
```

## Abstract Factory Pattern

The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

#### When to Use the Abstract Factory Pattern

The Abstract Factory pattern is useful in the following scenarios:

- When a system should be independent of how its products are created, composed, and represented.
- When a system should be configured with multiple families of products.
- When a family of related product objects is designed to be used together and you need to enforce this constraint.

#### Problem Solved by the Abstract Factory Pattern

The Abstract Factory pattern solves several problems, including:

- **Encapsulation of Object Creation**: It encapsulates the object creation logic within the factory, providing a clear interface for creating products.
- **Flexibility and Scalability**: It allows for the addition of new product families without modifying the existing code, promoting flexibility and scalability.
- **Consistency of Created Objects**: It ensures that the created objects are compatible and belong to the same family, enforcing consistency within the system.

#### Code Example

Here's an example of how the Abstract Factory pattern can be implemented in C#:

```csharp
public interface IProductA
{
    string OperationA();
}

public interface IProductB
{
    string OperationB();
}

public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}

public class ConcreteProductA1 : IProductA
{
    public string OperationA()
    {
        return "ConcreteProductA1";
    }
}

public class ConcreteProductA2 : IProductA
{
    public string OperationA()
    {
        return "ConcreteProductA2";
    }
}

public class ConcreteProductB1 : IProductB
{
    public string OperationB()
    {
        return "ConcreteProductB1";
    }
}

public class ConcreteProductB2 : IProductB
{
    public string OperationB()
    {
        return "ConcreteProductB2";
    }
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

// Usage
var factory1 = new ConcreteFactory1();
var productA1 = factory1.CreateProductA();
var productB1 = factory1.CreateProductB();

var factory2 = new ConcreteFactory2();
var productA2 = factory2.CreateProductA();
var productB2 = factory2.CreateProductB();

```

## Structural Design Patterns

Structural design patterns focus on how objects and classes are composed to form larger structures and provide relationships between them.

### Proxy Pattern

The Proxy pattern provides a surrogate or placeholder for another object to control access to it.

#### When to Use the Proxy Pattern

The Proxy pattern is useful in the following scenarios:

- When you want to add an additional layer of indirection and control over accessing an object.
- When you want to provide a simplified interface to a complex or resource-intensive object.
- When you want to control access to an object based on certain conditions or permissions.

#### Problem Solved by the Proxy Pattern

The Proxy pattern solves several problems, including:

- **Access Control**: It allows for controlled access to an object by providing a surrogate.
- **Resource Management**: It helps in managing and conserving system resources by deferring object creation or initialization until necessary.
- **Simplified Interface**: It provides a simpler and more focused interface to a complex or resource-intensive object.
- **Caching** : It provides a mechanism to do caching after you finish the Service or finishing it.
- **Logging** : In cases you want to use logging your outputs you can do it with the proxy without needing you to do it manually.
- **Lazy Initialization** : It allows you to use only one instance for your service if it needs heavy initialization object or complex configuration.

#### Code Example

Here's an example of how the Proxy pattern can be implemented in C#:

```csharp
public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling request.");
    }
}

public class Proxy : ISubject
{
    private RealSubject realSubject;

    public void Request()
    {
        if (realSubject == null)
        {
            Console.WriteLine("Proxy: Creating RealSubject.");
            realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy: Forwarding request to RealSubject.");
        realSubject.Request();
    }
}

// Usage
var proxy = new Proxy();
proxy.Request();

```

### Adapter Pattern

The Adapter pattern allows objects with incompatible interfaces to work together by providing a wrapper that converts one interface into another.

#### When to Use the Adapter Pattern

The Adapter pattern is useful in the following scenarios:

- When you want to use an existing class that doesn't have the interface you need.
- When you want to create a reusable class that interacts with multiple existing classes with different interfaces.
- When you want to decouple the client code from the specifics of multiple third-party libraries.

#### Problem Solved by the Adapter Pattern

The Adapter pattern solves several problems, including:

- **Interface Incompatibility**: It allows objects with incompatible interfaces to work together by providing a common interface.
- **Reusability**: It enables the reuse of existing classes that may not have the desired interface.
- **Client-Centric Design**: It decouples the client code from the specific interfaces of multiple third-party classes, making the client code more maintainable.

#### Code Example

Here's an example of how the Adapter pattern can be implemented in C#:

```csharp
public interface ITarget
{
    string GetRequest();
}

public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request.";
    }
}

public class Adapter : ITarget
{
    private readonly Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    // in most cases the Client/Target and Adaptee/Service or 3-rd part library will be Incompatible , this is so trivial example
    public string GetRequest()
    {
        return $"This is '{adaptee.GetSpecificRequest()}'";
    }
}

// Usage
var adaptee = new Adaptee();
var adapter = new Adapter(adaptee);
var result = adapter.GetRequest(); // Output: "This is 'Specific request.'"
```
