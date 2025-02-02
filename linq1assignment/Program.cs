using linq1demo;

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
            //int number = 12345;
            //int y = number.reverse();
            //Console.WriteLine(y);
            #endregion

            #region what is Linq
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var odds = numbers.Where(n => n % 2 == 1);

            //numbers.AddRange([10, 11, 12, 13, 14, 15]);

            //foreach (int odd in odds)
            //    Console.WriteLine(odd);
            #endregion

        }
    }
}
