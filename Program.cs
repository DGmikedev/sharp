// using System.Formats.Asn1;


internal class Program
{
    private static void Main(string[] args)
    {

//      Tipo         nombbre     asignacion     valor
        int          numero         =           0;
        double       doble          =           0.0;
        bool         buleano        =           false;
        char         caracter       =           '?';
        string       cadenaDeLetras =           "Cadena de Letras";
        const double CONSTANTE      =           3.1416;

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


    }
}