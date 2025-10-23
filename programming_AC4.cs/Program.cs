internal class Program

{

    private static void Main(string[] args)
    {
        /*ejercicio 1 */
        /*System.Console.Write("Enter first grade: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Enter second grade: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Enter third grade: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        double average = (grade1 + grade2 + grade3) / 3;
        System.Console.WriteLine($"Average: {average:F2}");

        if (average >= 5)
            Console.WriteLine("Student passed.");
        else
            Console.WriteLine("Student failed.");*/




        /* ejercicio 2 */

        /*int evnCount = 0;
        int oddCount = 0;
        int number;

        do
        {
            System.Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0) break;

            if (number % 2 == 0)
                evnCount++;
            else
                oddCount++;
        } while (true);

        System.Console.WriteLine($"Even numbers entered: {evnCount}");
        System.Console.WriteLine($"Odd numbers entered: {oddCount}");*/


        /* ejercicio 3 */

        /*bool continueCalculating = true;

        while (continueCalculating)
        {
            System.Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Select operation:");
            System.Console.WriteLine("1. Addition");
            System.Console.WriteLine("2. Subtraction");
            System.Console.WriteLine("3. Multiplication");
            System.Console.WriteLine("4. Division");
            System.Console.Write("Enter choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        System.Console.WriteLine("Error: Division by zero.");
                        validOperation = false;
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid operation choice.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
                System.Console.WriteLine($"Result: {result}");

            System.Console.Write("Do you want to perform another calculation? (y/n): ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "y")
                continueCalculating = false;
        }
        System.Console.WriteLine("Calculator exited.");*/



        // ejercicio 4 */

        /*string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
        while (true)
        {
            Console.Write("Enter DNI number: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            
            int remainder = dni % 23;
            char letter = letters[remainder];

            Console.WriteLine($"The letter for {dni} is {letter}");

            if (letter == 'A')
            {
                Console.WriteLine("You found a DNI with the letter A!");
                break;
            }
        }*/

        /*int lineas, numero, total;

        for( lineas = 1; lineas <= 4; lineas++)
        {
            total = 1;
            for( numero = 1; numero <= 5; numero++)
            {
                Console.WriteLine(numero)
            }
            Console.WriteLine();*/



        // ejercicio 5 */


        int height = 15;

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}



