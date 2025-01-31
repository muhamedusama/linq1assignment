namespace linq1assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region implicitly type local variable
            #region var
            var name = "usama";

            #endregion

            #region dynamic
            dynamic data;

            data = "Ahmed";
            data = 10.5;
            data = true;
            data = 5;

            dynamic employee = new { id = 10, name="Rawan", salary = 15000 };
            Console.WriteLine(employee.id);
            #endregion
            #endregion
        }
    }
}
