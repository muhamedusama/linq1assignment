﻿using linq1demo;

namespace linq1assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region implicitly type local variable
            #region var
            // var name = "usama";

            #endregion

            #region dynamic
            //dynamic data;

            //data = "Ahmed";
            //data = 10.5;
            //data = true;
            //data = 5;

            //dynamic employee = new { id = 10, name="Rawan", salary = 15000 };
            //Console.WriteLine(employee.id);
            #endregion
            #endregion

            #region anonymous type
            //var employee = new { id = 10, name = "menna", salary = 8000 };
            //Console.WriteLine(employee.name);
            //var employee02 = new { id = 10, name = "menna", salary = 8000f };

            //var employee03 = employee02 with { id = 20 };
            //Console.WriteLine(employee03);
            #endregion

            #region Extension Method
            int number = 12345;
            int y = number.reverse();
            Console.WriteLine(y);
            #endregion
        }
    }
}
