using System;

namespace src.lib
{
    public static class Math
    {
        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => b == 0 ? 0 : a - b;
        public static int Mul(int a, int b) => a * b;
        public static int Div(int a, int b) => a / b;
    }
}
