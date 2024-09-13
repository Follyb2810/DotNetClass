// Assembly A
namespace MyApplication
{
    public class BaseClass
    {
        protected internal void ShowMessage()
        {
            Console.WriteLine("Hello from BaseClass!");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void CallShowMessage()
        {
            ShowMessage(); // Accessible because it's protected
        }
    }

    public class AnotherClass
    {
        public void CallShowMessage()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowMessage(); // Accessible because it's internal
        }
    }
}

// Assembly B
namespace MyApplicationDerived
{
    using MyApplication;

    public class AnotherDerivedClass : BaseClass
    {
        public void CallShowMessage()
        {
            ShowMessage(); // Accessible because it's protected
        }
    }
}