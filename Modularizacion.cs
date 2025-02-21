using System;

bool salir = false;
while (!salir)
{
    Console.WriteLine("Menú de Opciones:");
    Console.WriteLine("1. Calculadora Basica");
    Console.WriteLine("2. Validacion de Contraseña");
    Console.WriteLine("3. Numeros Primos");
    Console.WriteLine("4. Sumar Numeros Pares");
    Console.WriteLine("5. Convertir Temperatura");
    Console.WriteLine("6. Contar Vocales");
    Console.WriteLine("7. Calcular Factorial");
    Console.WriteLine("8. Juego De Adivinar");
    Console.WriteLine("9. Paso Por Referencia");
    Console.WriteLine("10. Tablas De Multiplicar");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opción: ");
    string op = Console.ReadLine();

    switch (op)
    {
        case "1":
            CalcBasica();
            break;
        case "2":
            ValContra();
            break;
        case "3":
            PrimNums();
            break;
        case "4":
            SumNumsPares();
            break;
        case "5":
            ConvTemp();
            break;
        case "6":
            ContVocales();
            break;
        case "7":
            CalcFactorial();
            break;
        case "8":
            JuegoAdiv();
            break;
        case "9":
            PasoRef();
            break;
        case "10":
            TabMultiplicar();
            break;
        case "0":
            salir = true;
            break;
        default:
            Console.WriteLine("Opcion invalida, ingrese un numero del 1 al 10 para elegir una opcion");
            break;




    int CalcBasica()
    {
        Console.Write("Primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double n1))
        {
            Console.WriteLine("Entrada no válida.");
            return 0;
        }

        Console.Write("Segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double n2))
        {
            Console.WriteLine("Entrada no válida.");
            return 0;
        }

        Console.WriteLine("Operación: 1. Suma ");
        Console.WriteLine("Operación: 2. Resta ");
        Console.WriteLine("Operación: 3. Multiplicación");
        Console.WriteLine("Operación: 4. División");
        string op = Console.ReadLine();

        double resultado = 0;
        switch (op)
        {
            case "1":
                resultado = n1 + n2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "2":
                resultado = n1 - n2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "3":
                resultado = n1 * n2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "4":
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }

        return (int)resultado;
    }

    string ValContra()
    {
        string pass;
        do
        {
            Console.Write("Contraseña: ");
            pass = Console.ReadLine();
        } while (pass != "1234");
        Console.WriteLine("Acceso concedido.");
        return pass;
    }

    bool PrimNums()
    {
        Console.Write("Número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = EsPrimo(num);
        if (esPrimo)
        {
            Console.WriteLine($"{num} es primo.");
        }
        else
        {
            Console.WriteLine($"{num} no es primo.");
        }
        return esPrimo;
    }

            bool EsPrimo(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }


            int SumNumsPares()
    {
        int sum = 0;
        int num;

        Console.Write("Ingrese un numero (0 para terminar el bucle): ");
        while (int.TryParse(Console.ReadLine(), out num) && num != 0)
        {
            if (num % 2 == 0)
                sum += num;

            Console.Write("Ingrese un numero (0 para terminar): ");
        }

        Console.WriteLine($"Suma de números pares: {sum}");
        return sum;
    }

    double ConvTemp()
    {
        Console.WriteLine("Conversión de Temp: 1. Celsius a Fahrenheit ");
        Console.WriteLine("                    2. Fahrenheit a Celsius");
                string op = Console.ReadLine();
        double resultado = 0;

        if (op == "1")
        {
            Console.Write("Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            resultado = c * 9 / 5 + 32;
            Console.WriteLine($"Fahrenheit: {resultado}");
        }
        else if (op == "2")
        {
            Console.Write("Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            resultado = (f - 32) * 5 / 9;
            Console.WriteLine($"Celsius: {resultado}");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
        return resultado;
    }

    int ContVocales()
    {
        Console.Write("Frase: ");
        string phrase = Console.ReadLine();
        int count = 0;
        foreach (char c in phrase.ToLower())
        {
            if ("aeiou".Contains(c)) count++;
        }
        Console.WriteLine($"Número de vocales: {count}");
        return count;
    }

    long CalcFactorial()
    {
        Console.Write("Número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= num; i++) fact *= i;
        Console.WriteLine($"Factorial de {num} es: {fact}");
        return fact;
    }

    int JuegoAdiv()
    {
        Random random = new Random();
        int secretNum = random.Next(1, 101);
        int guess;
        do
        {
            Console.Write("Adivina el número (1-100): ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < secretNum) Console.WriteLine("Demasiado bajo.");
            else if (guess > secretNum) Console.WriteLine("Demasiado alto.");
        } while (guess != secretNum);
        Console.WriteLine("¡Correcto! Adivinaste el número.");
        return guess;
    }

    int PasoRef()
    {
        Console.Write("Primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Original: a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Intercambiados: a = {a}, b = {b}");
        return a;
    }

    void TabMultiplicar()
    {
        Console.Write("Número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
    }
}

