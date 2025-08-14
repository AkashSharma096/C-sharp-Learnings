namespace ChildNamespaceExample
{
    class Program
    {
        static void Main()
        {
            ParentNamespace.ChildNamespace.Class1 class1 = new ParentNamespace.ChildNamespace.Class1();
            class1.Method1();
        }
    }
}