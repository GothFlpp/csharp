using System;

namespace _11_mod_parm
{
    class Calculator
    {
        public static int Sum(int n1, int n2){
            return (n1 + n2);
        }

        public static int Sum(int n1, int n2, int n3){
            return (n1 + n2 + n3);
        }

        public static int Sum(int n1, int n2, int n3, int n4){
            return (n1 + n2 + n3 + n4);
        }

        public static int Sum(params int[] n){
            int sum = 0;
            for (int ciclo = 0; ciclo < n.Length; ciclo++){
                sum += n[ciclo];
            }
            return sum;
        }
    }
}
