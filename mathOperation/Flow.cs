namespace FlowCondition.md
{
    using System;

    public class Flow
    {
        // protected internal: accessible to derived classes and instances within the same assembly
        // protected: accessible only to derived classes
        // internal: accessible to any instance within the same assembly
        // private: accessible only within the containing class
        // static: not accessible through instance; can be accessed through the class itself

        internal void FlowFunc()
        {
            System.Console.WriteLine(1234);
        }

        // Example of a protected method
        protected void ProtectedFunc()
        {
            System.Console.WriteLine("This is a protected method.");
        }

        // Example of a private method
        private void PrivateFunc()
        {
            System.Console.WriteLine("This is a private method.");
        }

        // Example of a static method
        public static void StaticFunc()
        {
            System.Console.WriteLine("This is a static method.");
        }
    }
}