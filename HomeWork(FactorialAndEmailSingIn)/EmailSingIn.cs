using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_FactorialAndEmailSingIn_
{
   public class EmailSingIn
    {
        public static int EmailPasswordCheck(string email, int password)
        {
            string e = "huseynnj@code.edu.az";
            int p =  12345;

            if ( email == e && (password == p))
            {
                Console.WriteLine("True");

                return -1;
                
            }
          
            
            else
            {
                Console.WriteLine("Please Enter Correctly");

                return -1;
                
            }

           



        }
      







    }
















      
}
