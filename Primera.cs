using System;

public class Primera
{
	public void primeras10Clases() {
        //      Tipo         nombbre     asignacion     valor
        int numero = 0;
        double doble = 0.0;
        bool buleano = false;
        char caracter = '?';
        string cadenaDeLetras = "Cadena de Letras";
        const double CONSTANTE = 3.1416;

        double convertido = Convert.ToDouble(numero);
        char convertido2 = Convert.ToChar(numero);

        Console.WriteLine("La variable numero         es del tipo: " + numero.GetType());
        Console.WriteLine("La variable doble          es del tipo: " + doble.GetType());
        Console.WriteLine("La variable buleano        es del tipo: " + buleano.GetType());
        Console.WriteLine("La variable caracter       es del tipo: " + caracter.GetType());
        Console.WriteLine("La variable cadenaDeLetras es del tipo: " + cadenaDeLetras.GetType());
        Console.WriteLine("La variable CONSTANTE      es del tipo: " + CONSTANTE.GetType());
        Console.WriteLine("La variable convertido     es del tipo: " + convertido.GetType());
        Console.WriteLine("La variable convertido2    es del tipo: " + convertido2.GetType());
        Console.WriteLine($"La variable numero         es del tipo: {numero}");

        /*
            \a  Bell alert       \'  Single quolation mark
            \b  Backspace        \"  Double quolation mark
            \f  Form feed        \\  Back Slash
            \n  New line         \?  Lietral cuestion mark
            \r  Carriage return  \v  Vertical Tab
            \t  Horizontal Tab
        */

        Console.Write("Impresion de una linea");
        Console.Write("-Otra Impresion de una linea\n");

        const string texto = "Este texto inicia con una \a Alerta!! pero será borrado \f \r \t\t y ahora estoy en el \v \"incio\"";
        Console.WriteLine(texto);

        String interpolado = $"Esta variable fue inerpolada en un string con valor: {numero}";
        Console.WriteLine(interpolado);

        // casteo

        double pi = 3.1416;
        int year = 2026;
        string numbLetra = "45";

        Console.WriteLine(Convert.ToInt32(pi));
        Console.WriteLine(Convert.ToDouble(year) + 0.2);
        Console.WriteLine(Convert.ToInt32(numbLetra) + 10);
        Console.WriteLine(Convert.ToString(pi) + " Es el valor de pi");


        //input de data por teclado
        Console.Write("Ingrese el nombre del pais: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa la super ficie del pais: ");
        double superficie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El nombre del pais es: {nombre}");
        Console.WriteLine($"Y su superficie {Convert.ToString(superficie)}");

        // Carateres aritmeticos

        int numero_a_operar = 10;
        Console.WriteLine("El valor de la variable a operar es 10");
        Console.WriteLine($" Operador += 20 =  {numero_a_operar += 20}");
        Console.WriteLine($" Operador /= 2  =  {numero_a_operar /= 2}");
        Console.WriteLine($" Operador *= 3  =  {numero_a_operar *= 3}");
        Console.WriteLine($" ++Operador        {++numero_a_operar}");
        Console.WriteLine($" --Operador        {--numero_a_operar}");

        // Class Math

        double valor_matematico = Math.Pow(25, 2); //  Potenciación

        Console.WriteLine($" Potenciación                   Math.Pow(25,2) = 25^2 {valor_matematico}");
        Console.WriteLine($" Absoluto                       Math.Abs(-500) = {Math.Abs(-500)}");
        Console.WriteLine($" Redondeo con 4 decimales       Math.Round(2.36981,4) = {Math.Round(2.36981, 4)}");
        Console.WriteLine($" Redondeo a la alza             Math.Ceiling(2.35981) = {Math.Ceiling(2.35981)}");
        Console.WriteLine($" Redondeo a la baja             Math.Floor(2.35981) = {Math.Floor(2.35981)}");
        Console.WriteLine($" Retorna el Maximo de 2 numeros Math.Max(10,100) = {Math.Max(10, 100)}");
        Console.WriteLine($" Retorna el Menor  de 2 numeros Math.Min(10,100) = {Math.Min(10, 100)}");
        Console.WriteLine($" Raiz cuadrada                  Math.Sqrt(9) = {Math.Sqrt(9)}");

        // Numeros pseudoaleatorio

        // es una clase, que puede arrojar 2 tipos de numeros enteros(int) o flotantes(double)

        Random random_numero = new Random();  // se instancia un objeto de la clse random

        // Numero aleatorio entero
        int aleatorio_entero = random_numero.Next(1, 500);

        // Numero aleatorio doble
        double aleatorio_double = random_numero.NextDouble();

        Console.WriteLine($"Se generan dos tipos de numeros aleatorios (Entero y Double)\nNumero entero aleatorio: {aleatorio_entero}\nNumero aleatorio double: {aleatorio_double}");


        Console.Write("Ingresa el valor del cateto A: ");

        Console.ForegroundColor = ConsoleColor.Yellow;

        double catetoa = Convert.ToDouble(Console.ReadLine());

        Console.ResetColor();

        Console.Write("Ingresa el valor del cateto B: ");

        Console.ForegroundColor = ConsoleColor.Yellow;

        double catetob = Convert.ToDouble(Console.ReadLine());

        double hipotenusa = Math.Round(Math.Sqrt(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2)), 2);

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine($"El valor de la hipotenusa es: {hipotenusa}");

        Console.ResetColor();

        string[] miString = { };

        miString.Append("Hola");
        miString.Append(" ");
        miString.Append("Mundo");

        foreach (string cadena in miString)
        {
            Console.WriteLine(cadena);
        }

        Console.ReadKey();
    }
}
