using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            FieldInfo[] instanceFields = typeof(TestClass)
                .GetFields(
                         BindingFlags.NonPublic |
                         BindingFlags.Instance);
            FieldInfo[] staticFields = typeof(TestClass)
                .GetFields(
                     BindingFlags.NonPublic |
                     BindingFlags.Static);

            foreach (var field in instanceFields)
            {
                field.SetValue(test, 10);
                Console.WriteLine(field + ":" + field.GetValue(test));
            }

            foreach (var field in staticFields)
            {
                Console.Write(field + ":");
                Console.WriteLine(field.GetValue(null));
            }
        }
    }
}
