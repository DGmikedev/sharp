using System;

public class CondicionalFor
{
	public CondicionalFor()
	{
        Console.WriteLine("Condicional FOR activado...");
	}

	public void condicionalFor(string texto) {

		if (texto.Length <= 0) {
            Console.WriteLine("Ingresa un nombre valido");
		}if (texto.Length >= 1 && texto.Length <= 20)
		{
			Console.WriteLine($"Tu nombre es :{texto}");
		}
		if (texto.Length > 20)
		{
            Console.WriteLine($"Tu nombre es demasiado largo {texto.Length} caracteres!");
		}
		else
		{
			Console.WriteLine("Saliendo . . .");
		}

	}
}
