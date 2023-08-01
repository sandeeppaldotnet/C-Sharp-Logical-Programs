using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Logical_Programs
{
    public class Swapping_Program_in_C__with_Examples
    {
        int num1=100,num2=200;
        int temp = 0;
       
        public void swap()
        {
            Console.WriteLine($"Before Swapping : {num1}, {num2}");
            temp = num1;    
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swapping : {num1}, {num2}");
            Console.ReadLine();
        }
           
    }
}
