namespace Separate
{
    using BaseClass;

    public class SeparateAssembly : Base
    {
        public void SeparateAssemblyPublic()
        {
            BasePublic();  // Works because it's public
        }

        // This won't cause an error because it's in the same assembly, 
        // but in a real-world scenario where this namespace is moved to a different project, 
        // it would cause a compile-time error.
        internal void SeparateAssemblyInternal() { BaseInternal(); } 

        // Causes a compile-time error because SeparateAssembly is not in the class hierarchy.
        public void SeparateAssemblyProtected() { BaseProtected(); } 

        // Causes a compile-time error because SeparateAssembly cannot access private members of Base.
        public void SeparateAssemblyPrivate() { CallPrivate(); } 

        // public void SeparateAssemblyStatic(int a, int b)
        // {
        //     Base.BaseStatic(a, b);  // Works because it's public
        // }
    }
}
