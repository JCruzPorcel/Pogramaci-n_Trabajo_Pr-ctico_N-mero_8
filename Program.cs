using System;

//Hecho en Visual Studio 2022.
//Por: Perez Porcel Juan Cruz.

internal class Program
{
    private static void Main()
    {
        Console.Clear();

        byte selectedOption;

        Console.WriteLine("Ingrese el número de actividad:\n\nActividades:\n1.Días Array\n2.Días Invertidos\n3.Almacenar Números\n4.Años Array\n5.Años Faltantes\n6.Buscar en Array\n");
        Console.Write("Actividad: "); selectedOption = byte.Parse(Console.ReadLine());

        ActivitiesMenu(selectedOption);
    }

    private static void ActivitiesMenu(byte selectedOption)
    {
        Console.Clear();

        switch (selectedOption)
        {
            case 1:
                Console.Clear();
                Activity_One();
                break;

            case 2:
                Console.Clear();
                Activity_Two();
                break;

            case 3:
                Console.Clear();
                Activity_Three();
                break;

            case 4:
                Console.Clear();
                Activity_Four();
                break;

            case 5:
                Console.Clear();
                Activity_Five();
                break;

            case 6:
                Console.Clear();
                Activity_Six();
                break;

            default:
                Console.Clear();

                Console.WriteLine("Número de actividad no encontrado.");

                Console.WriteLine("\nPulse una tacla para continuar...");
                Console.ReadKey();
                Main();
                break;
        }
    }

    private static void Activity_One()
    {
        string[] weekdays = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        for (int i = 0; i < weekdays.Length; i++)
        {
            Console.WriteLine(weekdays[i] + ".");
        }

        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main(); ;
    }

    private static void Activity_Two()
    {
        string[] weekdays = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        for (int i = weekdays.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(weekdays[i] + ".");
        }

        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main();
    }

    private static void Activity_Three()
    {
        decimal[] m_userNumbers = new decimal[6];
        decimal m_average = 0;
        decimal m_amount = 0;
        int m_add = 0;

        for (int i = 0; i < m_userNumbers.Length; i++)
        {
            Console.WriteLine("Ingrese 6 números, números actuales: {0}.", i);
            m_userNumbers[i] = decimal.Parse(Console.ReadLine());
            m_amount += m_userNumbers[i];
            m_add++;
            Console.Clear();
        }

        m_average = m_amount / m_add;

        Console.WriteLine("El promedio de los números ingresados es de: {0}.", m_average);

        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main();
    }

    private static void Activity_Four()
    {
        short[] months = new short[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        short userMonthNumber = 0;


        Console.Write("Ingrese el número de mes: ");

        userMonthNumber = short.Parse(Console.ReadLine());
        userMonthNumber--;

        while (userMonthNumber < 0 || userMonthNumber > 11)
        {
            Console.Clear();

            Console.WriteLine("El número de mes no existe.");

            Console.WriteLine("Ingrese otro número de mes.");
            userMonthNumber = short.Parse(Console.ReadLine());
            userMonthNumber--;
        }

        Console.WriteLine("El mes {0} tiene {1} días.", userMonthNumber + 1, months[userMonthNumber]);

        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main();
    }

    private static void Activity_Five()
    {
        short[] months = new short[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        short userMonthNumber = 0;
        short userDayNumber = 0;
        int missingDay = 0;


        Console.Write("Ingrese el número de mes: ");

        userMonthNumber = short.Parse(Console.ReadLine());
        userMonthNumber--;

        while (userMonthNumber < 0 || userMonthNumber > 11)
        {
            Console.Clear();

            Console.WriteLine("El número de mes no existe.\n");

            Console.Write("Ingrese otro número de mes: ");

            userMonthNumber = short.Parse(Console.ReadLine());
            userMonthNumber--;
        }


        Console.Write("Ingrese el número de día: ");

        userDayNumber = short.Parse(Console.ReadLine());

        while (userDayNumber > months[userMonthNumber] || userDayNumber < 0)
        {
            Console.Clear();

            Console.WriteLine("El día ingresado no corresponde a la cantidad de días del mes.\n");

            Console.Write("Ingrese otro número de día: ");
            userDayNumber = short.Parse(Console.ReadLine());
        }

        for (int i = userMonthNumber; i < months.Length; i++)
        {
            missingDay += months[i];
        }
        missingDay -= userDayNumber;

        Console.Clear();

        Console.WriteLine("Quedan {0} días para terminar el año.", missingDay);

        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main();
    }

    private static void Activity_Six()
    {
        bool onArray = false;
        int numberToFind = 0;

        Console.Write("Ingrese un número para buscar en la lista: ");
        numberToFind = Int32.Parse(Console.ReadLine());

        onArray = NumberInArray(numberToFind);

        Console.WriteLine(onArray ? "\nEl número que ingreso se encuentra en la lista." : "\nEl número que ingreso no se encuentra en la lista");


        Console.WriteLine("\nPulse una tacla para continuar...");
        Console.ReadKey();
        Main();
    }

    private static bool NumberInArray(int number)
    {
        int[] arrayNumbers = new int[10] { 67, 71, 50, 139, 26, 1998, 24, 5, 8, 28 };
        bool numberFound = false;


        for (int i = 0; i< arrayNumbers.Length; i++)
        {
            if(number == arrayNumbers[i])
            {
                numberFound = true;
            }
        }

        return numberFound;
    }
}