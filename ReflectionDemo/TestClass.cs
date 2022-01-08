using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    public class TestClass
    {
        private int A;//
        protected int B;//
        public int C;

        public static int D;
        protected static int E;//
        private static int F;//

        public TestClass()
        {
            A = 1;
            B = 2;
            C = 3;
        }

        static TestClass()
        {
            D = 5;
            E = 6;
            F = 7;
        }
    }
}
