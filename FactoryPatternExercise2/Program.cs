namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool correctInput;
            do
            {
                correctInput = true;
                Console.WriteLine("What database do you want to use?");
                Console.WriteLine("list, sql, or mongo?");
                input = Console.ReadLine();

                if (input != "list" && input != "sql" && input != "mongo")
                {
                    correctInput = false;
                }
            } while (correctInput == false);

            IDataAccess database = DataAccessFactory.GetDataAccessType(input);

            var products = database.LoadData();
            database.SaveData();

            foreach ( var product in products )
            {
                Console.WriteLine($"Product is {product.Name}, which costs {product.Price} dollars.");
            }
        }
    }
}
