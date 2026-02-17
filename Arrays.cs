using System;
using System.Reflection.Metadata.Ecma335;

public class Arrays
{
	public Arrays()
	{
        Console.WriteLine("Comienza la ejecución de la calse Arrays.  .  .");
	}

	public void arraysClass(string cadenas) {
        Console.WriteLine(cadenas);

	}

	public int arrayOpen() {
        String[,] multyArray = new String[3, 3]{
            {"A","B","C" },
            {"D","F","G" },
            {"H","I","J" }
        };



        String[][] arregloFlexible = new string[3][];

        arregloFlexible[0] = ["1", "2"];
        arregloFlexible[1] = ["3", "4", "5"];
        arregloFlexible[2] = ["6"];


        for (int i = 0; i < arregloFlexible.Length; i++)
        {

            Console.Write("[");

            for (int j = 0; j < arregloFlexible[i].Length; j++)
            {

                Console.Write($"{arregloFlexible[i][j]} ");
            }
            Console.Write("]");
            Console.WriteLine();

        }
        ;



        /* multyArray[0,0] = "1";
        multyArray[0,1] = "2";
        multyArray[0,2] = "2";
        // multyArray[0,2] = "3";
        // multyArray[0,3] = "4";

        multyArray[1, 0] = "1";
        multyArray[1, 1] = "2";
        multyArray[1, 2] = "2";

        multyArray[2, 0] = "1";
        multyArray[2, 1] = "2";
        multyArray[2, 2] = "2"; */



        // multyArray[1, 2] = "3";
        // multyArray[1, 3] = "4";

        Console.WriteLine(multyArray);
        // multyArray =  { "IBM", "LENOVO", "TOSHIBA" ,  "MARCA1", "MARCA2", "MARCA3"};

        String[,] cadenas = { { "IBM", "LENOVO", "TOSHIBA" }, { "MARCA1", "MARCA2", "MARCA3" } };

        foreach (string cadena in cadenas)
        {
            Console.WriteLine(cadena);
        }
        return 1;
    }
}
