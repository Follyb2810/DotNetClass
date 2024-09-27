using System;
using BaseClass;
using Separate;

public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(12345);

        AssemblyDerivedBase assemblyDerivedBase = new AssemblyDerivedBase();

        // Works because AssemblyDerivedBase and Base are in the same assembly
        // assemblyDerivedBase.CallBaseInternal();

        // Uncommenting the following will NOT cause compile-time errors due to the structure:
        // assemblyDerivedBase.CallBaseProtected();  // Works because it's in a derived class
        // assemblyDerivedBase.CallPrivate();        // Works because CallPrivate() is public within Base
        // assemblyDerivedBase.CallBaseState(10, 11);        // Works because CallPrivate() is public within Base

        //! Base Static Call Example
        // Base.BaseStatic(10, 11);  // Works because it's a public static method

        //! calling SeparateAssembly
        SeparateAssembly separateAssembly = new SeparateAssembly();
        separateAssembly.SeparateAssemblyPublic(); // Works fine

        // Uncommenting the following will cause compile-time errors:
        separateAssembly.SeparateAssemblyInternal();   // Causes an error if `Separate` is in a different assembly
        separateAssembly.SeparateAssemblyProtected();  // Causes an error because it's not in the class hierarchy
        separateAssembly.SeparateAssemblyPrivate();    // Causes an error because it's private in `Base`

        System.Console.WriteLine(123457);
    }
}