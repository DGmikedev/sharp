using System;

public class CadenasCaracteres

{
    public CadenasCaracteres() {
        Console.WriteLine("Cadenas de caracteres habilitado...");
    }
    public void cadenas() {

        Console.WriteLine("Se integran metodos de qinvlucran cadenas...");

        String cadena1 = new String("Cadena uno");
        string resto = cadena1.Remove(3);

        Console.WriteLine(cadena1);
        Console.WriteLine(resto);

        string cadena2 = new String("Cadena dos");
        cadena2 = cadena2.Replace("C", "X");

        cadena2 += " >texto concatenado<";
        Console.WriteLine(cadena2);


        string string3 = new String("cadena tres o cuatro | para convertir en array");
        string[] stringArray =  string3.Split("|");

        foreach (string cadena in stringArray) {
            Console.WriteLine(cadena);
        }





    }
}
