using System;

namespace _11_mod_parm_ref_out
{
    class Calculator
    {
        public static void Triple(ref int x){
            x = x * 3;
            
        }
        public static void Triple(int origin, out int result){
            result = origin * 3;
            
        }
    }
}
