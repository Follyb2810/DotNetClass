namespace BaseClass
{
    public class Base
    {
        public void BasePublic()
        {
            System.Console.WriteLine("This is BasePublic");
        }

        private void BasePrivate()
        {
            System.Console.WriteLine("This is BasePrivate");
        }

        internal void BaseInternal()
        {
            System.Console.WriteLine("This is BaseInternal");
        }

        protected void BaseProtected()
        {
            System.Console.WriteLine("This is BaseProtected");
        }

        static int BaseStatic(int a, int b)
        {
            System.Console.WriteLine("This is BaseStatic");
            int c = a + b;
            System.Console.WriteLine(c);
            return c;
        }

        public void CallPrivate()
        {
            BasePrivate();
        }
        public void CallBaseStatic(int a, int b)
        {
            //! Can call it here since it's within the same class
            // BaseStatic(a,b);
            int result = Base.BaseStatic(10, 20);
            System.Console.WriteLine("Result from BaseStatic: " + result);
        }
    }

    public class AssemblyDerivedBase : Base
    {
        public void CallBasePublic()
        {
            BasePublic();
        }

        internal void CallBaseInternal()
        {
            BaseInternal(); // Accessible because it's within the same assembly
        }

        public void CallBaseProtected()
        {
            BaseProtected(); // Accessible because it's in a derived class
        }

        public void CallBasePrivate()
        {
            CallPrivate(); // Works because CallPrivate() is public and inside Base
        }

        public void CallBaseState(int a, int b)
        {
            CallBaseStatic(a, b);
        }
    }
}
