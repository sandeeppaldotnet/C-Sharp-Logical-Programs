using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Logical_Programs
{
    public class Swapping_Program_in_C__with_Examples
    {
       
      
       
        /// <summary>
        /// Swapping with temp variable
        /// </summary>
        public void swap(int num1,int num2, out int onum1, out int onum2)
        {
            int temp = 0;
            Console.WriteLine($"Before Swapping : {num1}, {num2}");
            temp = num1;    
            num1 = num2;
            num2 = temp;
            onum1 = num1;
            onum2 = num2;
            Console.WriteLine($"After Swapping : {num1}, {num2}");
           
        }
           
        /// <summary>
        /// Swapping without third variable 
        /// </summary>
        public void Swapping_Without_Temp_Variable(int num1, int num2,out int onum1,out int onum2)
        {
            Console.WriteLine($"Before Swapping : {num1}, {num2}");
            num1 = num1 + num2;
            num2 = num1-num2;
            num1=num1- num2;
            onum1 = num1;
            onum2 = num2;
            Console.WriteLine($"Before Swapping : {num1}, {num2}");
            
        }
    }
}
