﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionH
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                a = 10;
                b = 0;
                c = a / b;
                throw new OverflowException("Manual");
                Console.WriteLine("lkkkdgfjusygdjs");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }           
            
        }
    }
}
