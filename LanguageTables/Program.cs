using System;
using System.Threading.Tasks;

namespace LanguageTables
{
    class Program
    {
        static async Task Main(string[] args)
        {
            char response;
            bool firstTime = true;
            while (true)
            {
                if (firstTime)
                {
                    Console.WriteLine("Select the language: ");
                    Console.WriteLine("1 - default ");
                    Console.WriteLine("2 - English ");
                    Console.WriteLine("3 - Telugu ");
                    Console.WriteLine("4 - Arabic ");
                    Console.WriteLine("5 - English as default ");
                    Console.WriteLine("6 - Save the language ");
                    Console.WriteLine("0 - to quit the application");
                    firstTime = false;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Select the langage or \"0\" to quit: ");
                response = Console.ReadKey().KeyChar;

                // terminating the while loop
                if (response == '0' || response == ' ')
                {
                    break;
                }
                switch (response)
                {
                    case '1':
                        await GetEmployee(null);
                        break;
                    case '2':
                        await GetEmployee("en");
                        break;
                    case '3':
                        await GetEmployee("te");
                        break;
                    case '4':
                        await GetEmployee("ar");
                        break;
                    case '5':
                        await GetEmployee("dx");
                        break;
                    case '6':
                        await SaveEmployee("dx");
                        break;
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static async Task GetEmployee(string culture)
        {
            using (FxRepository repository = new FxRepository(culture)) // using is used for disposing the context
            {
                EmployeeModel emp = await repository.GetEmployee();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Employee Name in default language: " + emp.Name);
                if(emp.Language != null)
                    Console.WriteLine("Employee Name in chosen language: " + emp.Language.Name);
            }
        }

        static async Task SaveEmployee(string culture)
        {
            using (FxRepository repository = new FxRepository(culture)) // using is used for disposing the context
            {
                EmployeeModel emp = await repository.GetEmployee();
                //emp.Description = DateTime.Now.ToLongTimeString();
                emp.Language.Name = DateTime.Now.ToShortTimeString();
                emp.Name = emp.Language.Name;
                await repository.SaveEmployee(emp);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Employee updated");
            }
        }
    }
}
