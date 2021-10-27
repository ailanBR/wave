using System;
					
public class Program
{
	public static void Main()
	{
		/*
		1 - Não pode dar palpites repetidos
		2 - Dizer o nome de quem ganhou
		*/
		int valor_maximo = 15;
		Random randNum = new Random();
		
		//JOGADA ALEXSANDRO
		string hello_world_alexsandro = "Alexsandro"; 
		int valor_alexsandro = 3; 
		int palpite_alexsandro = randNum.Next(valor_maximo); 
		Console.WriteLine (valor_alexsandro + " " + hello_world_alexsandro + " " + palpite_alexsandro); 
		
		//JOGADA LUCAS
        string hello_world_lucas = "Lucas";
        int valor_lucas = 2;
        int palpite_lucas = randNum.Next(valor_maximo);
		int contador_lucas = 1;
		while(palpite_lucas == palpite_alexsandro)
		{
			Console.WriteLine("Palpite de Lucas " + palpite_lucas + " igual ao de Leke" + contador_lucas);
			palpite_lucas = randNum.Next(valor_maximo);
			contador_lucas = contador_lucas + 1;
			if (contador_lucas > 10)
			{
				break;
			}
		}
        Console.WriteLine (valor_lucas + " " + hello_world_lucas + " " + palpite_lucas);
		
		//JOGADA FABIO
		string hello_world_fabio = "Fabio";
		int valor_fabio = 1;
		int palpite_fabio = randNum.Next(valor_maximo);
		int contador_fabio = 1;
		//|| (verdeiro E verdadeiro) => executa o comando while com o que estiver dentro das chaves {}
		//&& (verdadeiro OU verdadeiro) => executa o comando while com o que estiver dentro das chaves {}
		while(palpite_lucas == palpite_fabio || palpite_alexsandro == palpite_fabio)
		{
			Console.WriteLine("Palpite de Fabio " + palpite_fabio + " repetiu " + contador_fabio);
			palpite_fabio = randNum.Next(valor_maximo);
			contador_fabio = contador_fabio + 1;
			if (contador_fabio > 10)
			{
				break;
			}
		}
		Console.WriteLine (valor_fabio + " " + hello_world_fabio + " " + palpite_fabio);
		
		//JOGADA Alexandro
		string hello_world_alexandro = "Alexandro";
    	int valor_alexandro = 3;
    	int palpite_alexandro = randNum.Next(valor_maximo);
		int contador_le = 1;
		while(palpite_lucas == palpite_alexandro || palpite_alexsandro == palpite_alexandro || palpite_fabio == palpite_alexandro)
		{
			Console.WriteLine("Palpite de Lê " + palpite_fabio + " repetiu " + contador_fabio);
			palpite_alexandro = randNum.Next(valor_maximo);
			contador_le = contador_le + 1;
			if (contador_le > 10)
			{
				break;
			}
		}
    	Console.WriteLine (valor_alexandro + " " + hello_world_alexandro + " " + palpite_alexandro);
		
		//JOGADA MEILIN
		string hello_world_meilin = "Meilin"; 
		int valor_meilin = 2; 
		int palpite_meilin = randNum.Next(valor_maximo); 
		int contador = 1;
		while(palpite_lucas == palpite_meilin || palpite_alexsandro == palpite_meilin || palpite_alexandro == palpite_meilin || palpite_fabio == palpite_meilin)
		{
			Console.WriteLine("Palpite de Meilin " + palpite_fabio + " repetido " + contador);
			palpite_meilin = randNum.Next(valor_maximo);
			contador = contador + 1;
			if (contador > 10)
			{
				break;
			}
		}
		Console.WriteLine (valor_meilin + " " + hello_world_meilin + " " + palpite_meilin);
		
		int valor_total = valor_meilin + valor_alexandro + valor_fabio + valor_lucas + valor_alexsandro;
		
		if( valor_total == palpite_alexsandro )
		{
			Console.WriteLine("***Alexsandro ganhou !!");
		}
		
		if( valor_total.Equals(palpite_lucas) )
		{
			Console.WriteLine("***Lucas ganhou !!");
		}
		
		if( valor_total.Equals(palpite_fabio) )
		{
			Console.WriteLine("***Fabio ganhou !!");
		}
		
		if( valor_total.Equals(palpite_meilin) )
		{
			Console.WriteLine("*** Meilin ganhou !! ***");
		}
		
		if( valor_total.Equals(palpite_alexandro) )
		{
			Console.WriteLine("***Alexandro ganhou !!");
		}
		
		Console.WriteLine("TOTAL DE PALITOS " + valor_total);
	}
}
