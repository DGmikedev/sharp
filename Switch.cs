using System;

public class Switch
{
	public Switch()
	{
        Console.WriteLine("Habilitando el ciclo switch .  .  .");
	}

	public void iswtch(string texto) {

		switch (texto) {
			case "":
                Console.WriteLine("Se envio una cadena vacia");
				break;
			case "escasa" :
                Console.WriteLine("Se envio cadena ESCASA");
				break;
			case "no escasa":
                Console.WriteLine("Se envio cadena NO ESCASA");
				break;
            case "abundante":
                Console.WriteLine("Se envio cadena ABUNDANTE");
                break;
			case "muy abundante":
                Console.WriteLine("Se envio cadena MUY ABUNDANTE");
				break;
			default:
                Console.WriteLine("resopuest apor deafult");
				break;
        }
		Console.WriteLine("stwch .....");
	}
}
