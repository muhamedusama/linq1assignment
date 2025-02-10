using linq1assignment;
using static linq1assignment.ListGenerator;
namespace linq1assignmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restrication operator
            #region Q1
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((p, i) => p.Length < i);
            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Ordering operators
            #region Q1
            //var result = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Arr.OrderBy(p=>p,StringComparer.OrdinalIgnoreCase);
            //foreach (string str in Arr) 
            //    Console.WriteLine(str);

            #endregion

            #region Q3
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var reslt = Arr.OrderBy(x => x.Length).ThenBy(p => p, StringComparer.Ordinal);
            //foreach (var item in reslt) 
            //    Console.WriteLine(item);
            #endregion

            #region Q5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWordsByLength = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWordsByLength)
            //    Console.WriteLine(word);
            #endregion

            #region Q6

            //var sortedByCategoryAndPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in sortedByCategoryAndPrice)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWordsDesc = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWordsDesc) 
            //    Console.WriteLine(word);
            #endregion

            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var reversedDigits = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            //foreach (var item in reversedDigits) 
            //    Console.WriteLine(item);
            #endregion


            #endregion

            #region Transofrmation operators
            #region Q1
            //var productNames = ProductList.Select(p => p.ProductName);
            //foreach (var name in productNames)
            //    Console.WriteLine(name);
            #endregion

            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var wordVariants = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            //foreach (var word in wordVariants) 
            //    Console.WriteLine(word);
            #endregion

            #region Q3
            //var productInfo = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice });
            //foreach (var product in productInfo)
            //    Console.WriteLine(product);
            #endregion

            #region Q4
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var inPlaceCheck = arr.Select((num, index) => new { Number = num, InPlace = num == index });
            //foreach (var item in inPlaceCheck) 
            //    Console.WriteLine(item);

            #endregion

            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var numberPairs = from a in numbersA
            //                  from b in numbersB
            //                  where a < b
            //                  select $"{a} is less than {b}";
            //foreach (var item in numberPairs)
            //    Console.WriteLine(item);
            #endregion

            #region Q6
            //var lowValueOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            //foreach (var order in lowValueOrders) 
            //    Console.WriteLine(order);
            #endregion

            #region Q7
            //var ordersIn1998OrLater = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var order in ordersIn1998OrLater)
            //    Console.WriteLine(order);
            #endregion
            #endregion

        }
    }
}
