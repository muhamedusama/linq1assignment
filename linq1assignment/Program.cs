using linq1demo;
using static linq1demo.ListGenerator;
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

            #region Linq syntax
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #region fluent syntax
            // 1) fluent syntax


            //// 1.1 static method
            //var odd = Enumerable.Where(numbers, n => n % 2 == 1);
            //foreach (int n in odd)
            //    Console.WriteLine(n);

            //// 1.2 extension method [recommended]
            //var odds = numbers.Where(n => n % 2 == 1);
            //foreach (int n in odds)
            //    Console.WriteLine(n);
            #endregion

            #region Query syntax
            // 2)Query syntax
            // like sql server style
            //var oddnumbers=from n in numbers
            //               where n%2==1
            //               select n;
            //foreach(var n in oddnumbers) 
            //    Console.WriteLine(n);
            #endregion
            #endregion

            #region Linq execution ways
            #region defered execution
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Where(n => n % 2 == 1);
            //numbers.AddRange([11, 12, 13, 14, 15]);

            //foreach (var n in result)
            //    Console.WriteLine(n);
            #endregion

            #region immediate execution
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Where(n => n % 2 == 1).ToList();

            //numbers.AddRange([11, 12, 13, 14, 15]);

            //foreach (var n in result)
            //    Console.WriteLine(n);
            #endregion
            #endregion

            #region filteration (restrication) operator - where 
            //var result = ProductList.Where(n => n.UnitsInStock == 0);
            //result=from p in ProductList
            //       where p.UnitsInStock == 0
            //       select p;
            //var result = ProductList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");

            //result= from p in ProductList
            //        where p.UnitsInStock == 0 && p.Category=="Meat/Poultry"
            //        select p;

            //indexed where 
            //var result = ProductList.Where()
            //foreach (var unit in result) 
            //    Console.WriteLine(unit);
            #endregion


        }
    }
}
