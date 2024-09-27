// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // Declare variable and assign it as null.
// FooBar fooBar = null;

// // Dereference variable by calling ToString.
// // This will throw a NullReferenceException.
// _ = fooBar.ToString();

// // The FooBar type definition.
// record FooBar(int Id, string Name);
// #nullable enable

// using System.Collections.Generic;

// var fooList = new List<FooBar>
// {
//     new(Id: 1, Name: "Foo"),
//     new(Id: 2, Name: "Bar")
// };

// FooBar fooBar = fooList.Find(f => f.Name == "Bar")!;

// // The FooBar type definition for example.
// record FooBar(int Id, string Name);
List<FooBar>? fooList = FooListFactory.GetFooList();

// Declare variable and assign it as null.
FooBar fooBar = fooList.Find(f => f.Name == "Bar")!; // generates warning

static class FooListFactory
{
    public static List<FooBar>? GetFooList() =>
        new List<FooBar>
        {
            new(Id: 1, Name: "Foo"),
            new(Id: 2, Name: "Bar")
        };
}

// The FooBar type definition for example.
record FooBar(int Id, string Name);
